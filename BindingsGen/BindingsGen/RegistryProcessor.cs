
// Copyright (C) 2011-2013 Luca Piccioni
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
using BindingsGen.GLSpecs;

namespace BindingsGen
{
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

			Console.WriteLine("Generate registry enums to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Modern OpenGL bindings.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public partial class Gl");
				sw.WriteLine("{");
				sw.Indent();

				foreach (Enumerant enumerant in mRegistry.Enumerants) {
					if ((filter != null) && (filter(enumerant) == false))
						continue;

					enumerant.GenerateSource(sw);
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

			Console.WriteLine("Generate registry enums (stronly types) to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
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

					enumerantGroup.GenerateSource(sw, mRegistry);
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

			if ((filter != null) && (mRegistry.Commands.FindIndex(delegate(Command item) { return (filter(item) ); }) < 0))
				return;

			Console.WriteLine("Generate registry commands to {0}.", path);

			using (SourceStreamWriter sw = new SourceStreamWriter(path, false)) {
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Diagnostics;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Modern OpenGL bindings.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public partial class Gl");
				sw.WriteLine("{");
				sw.Indent();

				#region Function Implementations

				foreach (Command command in mRegistry.Commands) {
					if (command.Alias != null)
						continue;
					if ((filter != null) && (filter(command) == false))
						continue;

					command.GenerateImplementations(ctx, sw, mRegistry);
					sw.WriteLine();
				}

				#endregion

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
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Security;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Modern OpenGL bindings.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public unsafe partial class Gl");
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

					command.GenerateImport(sw, mRegistry);
					sw.WriteLine();
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
				sw.WriteLine();

				sw.WriteLine("#pragma warning disable 649, 1572, 1573");
				sw.WriteLine();

				sw.WriteLine("using System;");
				sw.WriteLine("using System.Security;");
				sw.WriteLine("using System.Runtime.InteropServices;");
				sw.WriteLine();

				sw.WriteLine("namespace OpenGL");
				sw.WriteLine("{");
				sw.Indent();

				sw.WriteLine("/// <summary>");
				sw.WriteLine("/// Modern OpenGL bindings.");
				sw.WriteLine("/// </summary>");
				sw.WriteLine("public unsafe partial class Gl");
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

					command.GenerateDelegate(sw, mRegistry);
					sw.WriteLine();
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

		public delegate bool EnumerantFilterDelegate(Enumerant item);

		public delegate bool EnumerantGroupFilterDelegate(EnumerantGroup item);

		public delegate bool CommandFilterDelegate(Command item);

		/// <summary>
		/// The OpenGL registry.
		/// </summary>
		private readonly Registry mRegistry;
	}
}
