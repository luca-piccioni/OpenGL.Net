
// Copyright (C) 2016-2017 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using Khronos;

namespace BindingsGen.GLSpecs
{
	/// <summary>
	/// Utility class for processing C header files to generate XML specification files.
	/// </summary>
	class Header : IRegistry
	{
		#region Constructors

		public Header(string @class)
		{
			if (@class == null)
				throw new ArgumentNullException(nameof(@class));
			Class = @class;
		}

		#endregion

		#region Class

		public readonly string Class;

		#endregion

		#region Header Parsing

		public string CommandExportRegex;

		public string CommandCallConventionRegex;

		public string CommandExitRegex = String.Empty;

		/// <summary>
		/// Append definitions recognized in a header file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specified the path of the header file.
		/// </param>
		public void AppendHeader(string path, KhronosVersion feature)
		{
			string headerFeatureName = String.Format("{0}_VERSION_{1}_{2}", Class.ToUpperInvariant(), feature.Major, feature.Minor);

			AppendHeader(path, headerFeatureName);
		}

		/// <summary>
		/// Append definitions recognized in a header file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specified the path of the header file.
		/// </param>
		public void AppendHeader(string path, string headerFeatureName)
		{
			if (path == null)
				throw new ArgumentNullException(nameof(path));

			string headerText;

			// Read the whole header
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				using (StreamReader sr = new StreamReader(fs)) {
					headerText = sr.ReadToEnd();
				}
			}

			// Remove comments
			string inlineComment = @"//(.*?)\r?\n";
			string blockComment = @"/\*(.*?)\*/";
			
			headerText = Regex.Replace(headerText, String.Format("{0}|{1}", inlineComment, blockComment), delegate (Match match) {
				if (match.Value.StartsWith("/*"))
					return (String.Empty);
				if (match.Value.StartsWith("//"))
					return (Environment.NewLine);
				return (match.Value);
			}, RegexOptions.Singleline);

			// Extract C preprocessor #define directives
			string defineDirective = @"#define (?<Symbol>[\w\d_]+) +(?<Value>.*)\r?\n";

			EnumerantBlock definesBlock = new EnumerantBlock();
			definesBlock.Group = "Defines";

			headerText = Regex.Replace(headerText, defineDirective, delegate (Match match) {
				// Collect symbol/value
				if (match.Value.StartsWith("#define ")) {
					Enumerant enumerant = new Enumerant();

					// Replace enumeration macros
					string enumDefinition = ReplaceEnumMacros(match.Groups["Value"].Value.Trim());
					// Replace constants in enumeration value
					enumDefinition = ReplaceEnumConstants(enumDefinition);

					enumerant.Name = match.Groups["Symbol"].Value.Trim();
					enumerant.Value = enumDefinition;
					enumerant.ParentEnumerantBlock = definesBlock;

					bool useDefine = true;

					if (enumerant.Value.StartsWith("__"))
						useDefine = false;
					if (enumerant.Value.StartsWith("{") && enumerant.Value.EndsWith("}"))
						useDefine = false;

					if (useDefine) {
						definesBlock.Enums.Add(enumerant);
						// Collect enumerant
						_Enumerants.Add(enumerant);
					}

					return (String.Empty);
				}
					
				return (match.Value);
			}, RegexOptions.Multiline);

			// Remove no more necessary C preprocessor
			string preprocessorDirective = @"#(if|ifndef|else|endif|define|include) ?.*\r?\n";

			headerText = Regex.Replace(headerText, preprocessorDirective, String.Empty);

			// Remove new lines
			headerText = Regex.Replace(headerText, @"\r?\n", String.Empty);
			// Remove structures typedefs
			string structTypedef = @"typedef struct ?\{(.*?)\}( +?)(.*?);";
			headerText = Regex.Replace(headerText, structTypedef, String.Empty);
			// Remove multiple spaces
			headerText = Regex.Replace(headerText, @" +", " ");

			// Extract extern "C" scope
			string externBlock = "extern \"C\" {";
			if (headerText.StartsWith(externBlock))
				headerText = headerText.Substring(externBlock.Length, headerText.Length - externBlock.Length - 1);

			// Split into statements
			string[] statements = Regex.Split(headerText, ";");

			foreach (string statement in statements) {
				Match match;

				// Parse enumeration block
				if ((match = Regex.Match(statement, @"(typedef )?enum(?<Name> [\w\d_]+)? ?\{(?<Enums>.*)\}(?<Tag> +?[\w\d_]+)?")).Success) {

					string name;

					if (match.Groups["Tag"].Success)
						name = match.Groups["Tag"].Value.Trim();
					else if (match.Groups["Name"].Success)
						name = match.Groups["Name"].Value.Trim();
					else
						throw new InvalidOperationException("unable to determine name of enum");

					if (Regex.IsMatch(name, "WF(C|D)boolean"))
						continue;

					#region Enumeration

					// Skip enumeration if required
					CommandFlagsDatabase.EnumerantItem enumItem =  CommandFlagsDatabase.FindEnumerant(name);
					if (enumItem != null && enumItem.Disable)
						continue;

					EnumerantBlock enumerantBlock = new EnumerantBlock();
					enumerantBlock.Group = headerFeatureName;

					EnumerantGroup enumerantGroup = new EnumerantGroup();
					enumerantGroup.Name = name;

					// Override name
					if (enumItem != null && enumItem.Alias != null)
						enumerantGroup.Name = enumItem.Alias;

					// Replace enumeration macros
					string enumDefinition = ReplaceEnumMacros(match.Groups["Enums"].Value);
					// Replace constants in enumeration value
					enumDefinition = ReplaceEnumConstants(enumDefinition);
					// Parse enumerations
					string[] enumValues = Regex.Split(enumDefinition, ",");

					for (int i = 0; i < enumValues.Length; i++) {
						string enumValue = enumValues[i].Trim();

						if ((match = Regex.Match(enumValue, @"(?<Name>(\w|_)+)\s*=\s*(?<Value>.*)")).Success) {
							Enumerant enumerant = new Enumerant();

							enumerant.Name = match.Groups["Name"].Value;
							enumerant.Value = match.Groups["Value"].Value.Trim();
							enumerant.ParentEnumerantBlock = enumerantBlock;

							enumerantBlock.Enums.Add(enumerant);

							enumerantGroup.Enums.Add(enumerant);

							// Collect enumerant
							_Enumerants.Add(enumerant);
						}
					}

					_Groups.Add(enumerantGroup);

					#endregion

					continue;

				} else if ((match = Regex.Match(statement, CommandExportRegex + @"(?<Return>.*) " + CommandCallConventionRegex + @"(?<Name>.*)\((?<Args>.*)\)" + CommandExitRegex)).Success) {

					#region Command

					Command command = new Command();

					command.Prototype = new CommandPrototype();
					command.Prototype.Type = match.Groups["Return"].Value;
					command.Prototype.Name = match.Groups["Name"].Value;

					string[] args = Regex.Split(match.Groups["Args"].Value, ",");

					for (int i = 0; i < args.Length; i++) {
						string arg = args[i].Trim();

						if (arg == String.Empty)
							break;

						// '*' denotes types, not names
						arg = arg.Replace(" **", "** ");
						arg = arg.Replace(" *", "* ");

						if ((match = Regex.Match(arg, @"(const +)?(?<Type>(\w|_|\* (const)?|\*)+) +(?<Name>[\w\d_]+)(?<ArraySize>\[([\w\d_]+)?\])?$")).Success) {
							string arraySize = match.Groups["ArraySize"].Success ? match.Groups["ArraySize"].Value : null;

							CommandParameter commandParameter = new CommandParameter();

							commandParameter.Name = match.Groups["Name"].Value;
							commandParameter.Type = arraySize != null ? match.Groups["Type"].Value + "*" : match.Groups["Type"].Value;

							command.Parameters.Add(commandParameter);
						} else if (arg == "...") {
							CommandParameter commandParameter = new CommandParameter();

							commandParameter.Name = "vaArgs";
							commandParameter.Type = "IntPtr";

							command.Parameters.Add(commandParameter);
						} else
							throw new InvalidOperationException(String.Format("unable to parse argument '{0}'", arg));
					}

					_Commands.Add(command);

					#endregion

				}
			}

			Feature headerFeature = _Features.Find(delegate(Feature item) { return (item.Name == headerFeatureName); });
			if (headerFeature == null) {
				headerFeature = new Feature();
				headerFeature.Name = headerFeatureName;
				headerFeature.Api = Class.ToLowerInvariant();
				_Features.Add(headerFeature);
			}

			FeatureCommand headerFeatureCommand = new FeatureCommand();

			headerFeature.Requirements.Add(headerFeatureCommand);

			headerFeatureCommand.Enums.AddRange(_Enumerants.ConvertAll(delegate(Enumerant input) {
				return new FeatureCommand.Item(input.Name);
			}));

			headerFeatureCommand.Commands.AddRange(_Commands.ConvertAll(delegate(Command input) {
				return new FeatureCommand.Item(input.Prototype.Name);
			}));
		}

		private static string ReplaceEnumMacros(string enumDefinition)
		{
			MatchCollection macroMatches = Regex.Matches(enumDefinition, @"(?<Macro>[\w\d_]+)\((?<Args>(.*?))\)");

			foreach (Match macroMatch in macroMatches) {
				string[] args = Regex.Split(macroMatch.Groups["Args"].Value, ",");
				string replacement = null;

				switch (macroMatch.Groups["Macro"].Value) {
					case "VX_ENUM_BASE":
						replacement = ReplaceEnumMacro_VM_ENUM_BASE(args);
						break;
					case "VX_DF_IMAGE":
						replacement = ReplaceEnumMacro_VX_DF_IMAGE(args);
						break;
					case "VX_ATTRIBUTE_BASE":
						replacement = ReplaceEnumMacro_VX_ATTRIBUTE_BASE(args);
						break;
					case "VX_KERNEL_BASE":
						replacement = ReplaceEnumMacro_VX_KERNEL_BASE(args);
						break;
				}

				if (replacement != null)
					enumDefinition = enumDefinition.Replace(macroMatch.Value, replacement);
			}

			return (enumDefinition);
		}

		private string ReplaceEnumConstants(string enumDefinition)
		{
			MatchCollection macroMatches = Regex.Matches(enumDefinition, @"[\w\d_]+");

			foreach (Match macroMatch in macroMatches) {
				if (macroMatch.Value.StartsWith(Class.ToUpperInvariant() + "_")) {
					string replacement = macroMatch.Value.Substring(Class.Length + 1);
					enumDefinition = enumDefinition.Replace(macroMatch.Value, replacement);
				}
			}

			return (enumDefinition);
		}

		private static string ReplaceEnumMacro_VM_ENUM_BASE(string[] args)
		{
			return (String.Format("(({0} << 20) | ({1} << 12))", args[0], args[1]));
		}

		private static string ReplaceEnumMacro_VX_DF_IMAGE(string[] args)
		{
			return (String.Format("(((byte){0}) | ((byte){1} << 8) | ((byte){2} << 16) | ((byte){3} << 24))", args[0], args[1], args[2], args[3]));
		}

		private static string ReplaceEnumMacro_VX_ATTRIBUTE_BASE(string[] args)
		{
			return (String.Format("((({0}) << 20) | ({1} << 8))", args[0], args[1]));
		}

		private static string ReplaceEnumMacro_VX_KERNEL_BASE(string[] args)
		{
			return (String.Format("((({0}) << 20) | ({1} << 12))", args[0], args[1]));
		}

		/// <summary>
		/// Regular expression used for recognizing enumeration definition.
		/// </summary>
		private static Regex _RegexEnum = new Regex("^typedef enum");

		/// <summary>
		/// Regular expression used for recognizing enumeration definition.
		/// </summary>
		private static Regex _RegexStatementEnum = new Regex(@"^typedef enum \{ (?<Enum>[\w\d_]+) = (?<Value>[\w\d_]+(,)?)+\}(?<Tag>[\w\d_]+)");

		#endregion

		#region IRegistry Implementation

		public List<Command> Commands { get { return (_Commands); } }

		private readonly List<Command> _Commands = new List<Command>();

		public List<Enumerant> Enumerants { get { return (_Enumerants); } }

		private readonly List<Enumerant> _Enumerants = new List<Enumerant>();

		public List<Extension> Extensions { get { return (new List<Extension>()); } }

		public List<Feature> Features { get { return (_Features); } }

		private readonly List<Feature> _Features = new List<Feature>();

		public List<EnumerantGroup> Groups { get { return (_Groups); } }

		private readonly List<EnumerantGroup> _Groups = new List<EnumerantGroup>();

		public IEnumerable<IFeature> AllFeatures(RegistryContext ctx)
		{
			return Features;
		}

		public Command GetCommand(string name)
		{
			return (_Commands.Find(delegate(Command item) { return (item.Prototype.Name == name); }));
		}

		public Enumerant GetEnumerant(string name)
		{
			return (_Enumerants.Find(delegate(Enumerant item) { return (item.Name == name); }));
		}

		public Enumerant GetEnumerantNoCase(string name)
		{
			return (_Enumerants.Find(delegate(Enumerant item) { return (item.Name.ToLowerInvariant() == name.ToLowerInvariant()); }));
		}

		#endregion
	}
}
