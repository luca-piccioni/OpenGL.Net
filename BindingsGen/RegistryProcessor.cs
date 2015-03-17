
// Copyright (C) 2015 Luca Piccioni
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
using System.IO;
using System.Collections.Generic;
using System.Reflection;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL registry processor.
	/// </summary>
	class RegistryProcessor
	{
		#region Constructors

		public RegistryProcessor(Registry registry)
		{
			if (registry == null)
				throw new ArgumentNullException("registry");

			mRegistry = registry;
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <param name="filter"></param>
		public void GenerateEnums(RegistryContext ctx, string path, EnumerantFilterDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

            List<Enumerant> enumerants = mRegistry.Enumerants;

            if ((filter != null) && (enumerants.FindIndex(delegate(Enumerant item) { return (filter(item)); }) < 0))
                return;

			Console.WriteLine("Generate registry enums to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				foreach (Enumerant enumerant in mRegistry.Enumerants) {
					if ((filter != null) && (filter(enumerant) == false))
						continue;

					enumerant.GenerateSource(sw, ctx);
					sw.WriteLine();
				}

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateStronglyTypedEnums(RegistryContext ctx, string path, EnumerantGroupFilterDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			if (mRegistry.Groups.Count == 0)
				return;

			Console.WriteLine("Generate registry enums (strognly typed) to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine();

				sw.WriteLine("// Disable \"'token' is obsolete\" warnings");
				sw.WriteLine("#pragma warning disable 618");

				sw.WriteLine("using System;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				foreach (EnumerantGroup enumerantGroup in mRegistry.Groups) {
					if ((filter != null) && (filter(enumerantGroup) == false))
						continue;

					enumerantGroup.GenerateSource(sw, ctx);
					sw.WriteLine();
				}

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateCommands(RegistryContext ctx, string path, CommandFilterDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			if ((filter != null) && (mRegistry.Commands.FindIndex(delegate(Command item) { return (filter(item)); }) < 0))
				return;

			GenerateCommands(ctx, path, (CommandSerializerDelegate)delegate(RegistryContext cctx, SourceStreamWriter sw)
			{
				foreach (Command command in mRegistry.Commands)
				{
					if ((filter != null) && (filter(command) == false))
						continue;

					command.GenerateImplementations(sw, cctx);
					sw.WriteLine();
				}
			});
			
		}

		public void GenerateCommands(RegistryContext ctx, string path, CommandSerializerDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			Console.WriteLine("Generate registry commands to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Diagnostics;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine("using System.Text;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				// Function implementations
				filter(ctx, sw);

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateCommandsImports(RegistryContext ctx, string path, CommandFilterDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Security;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public unsafe partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				#region Function Imports

				// Write delegates
				sw.WriteLine("internal unsafe static partial class Imports");
				sw.WriteLine("{");
				sw.Indent();

				foreach (Command command in mRegistry.Commands) {
					if ((filter != null) && (filter(command) == false))
						continue;

					if ((command.Flags & CommandFlags.Disable) == 0) {
						command.GenerateImport(sw, ctx);
						sw.WriteLine();
					}
				}

				sw.Unindent();
				sw.WriteLine("}");

				#endregion

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		public void GenerateCommandsDelegates(RegistryContext ctx, string path, CommandFilterDelegate filter)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				GenerateLicensePreamble(sw);

				sw.WriteLine();

				sw.WriteLine("#pragma warning disable 649, 1572, 1573");
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Security;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine("using System.Text;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("public unsafe partial class {0}", ctx.Class);
				sw.WriteLine("{");
				sw.Indent();

				#region Function Delegates

				// Write delegates
				sw.WriteLine("internal unsafe static partial class Delegates");
				sw.WriteLine("{");
				sw.Indent();

				foreach (Command command in mRegistry.Commands) {
					if ((filter != null) && (filter(command) == false))
						continue;

					if ((command.Flags & CommandFlags.Disable) == 0) {
						command.GenerateDelegate(sw, ctx);
						sw.WriteLine();
					}
				}

				sw.Unindent();
				sw.WriteLine("}");

				#endregion

				sw.Unindent();
				sw.WriteLine("}");
				sw.Unindent();

				sw.WriteLine();
				sw.WriteLine("}");
			}
		}

		private void GenerateLicensePreamble(SourceStreamWriter sw)
		{
			using (StreamReader sr = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("BindingsGen.Licenses.LGPL2.txt"))) {
				string line;

				sw.WriteLine();
				while ((line = sr.ReadLine()) != null)
					sw.WriteLine("// {0}", line);
			}
		}

		public delegate bool EnumerantFilterDelegate(Enumerant item);

		public delegate bool EnumerantGroupFilterDelegate(EnumerantGroup item);

		public delegate void CommandSerializerDelegate(RegistryContext ctx, SourceStreamWriter sw);

		public delegate bool CommandFilterDelegate(Command item);

		/// <summary>
		/// The OpenGL registry.
		/// </summary>
		private readonly Registry mRegistry;
	}
}
