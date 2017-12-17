
// Copyright (C) 2015-2017 Luca Piccioni
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

using Khronos;

using BindingsGen.GLSpecs;

namespace BindingsGen
{
	/// <summary>
	/// OpenGL bindings generator.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Application entry point.
		/// </summary>
		/// <param name="args">
		/// The command line invocation arguments.
		/// </param>
		private static void Main(string[] args)
		{
			RegistryContext ctx;
			RegistryProcessor glRegistryProcessor;
			int index;

			DummyStream = Array.FindIndex(args, item => (item == "--dummy")) >= 0;
			DocDisabled= Array.FindIndex(args, item => (item == "--nodoc")) >= 0;

			#region Assembly processing

			if ((args.Length > 0) && ((index = Array.FindIndex(args, item => item == "--assembly")) >= 0)) {
				string assemblyPath = args[index + 1];
				bool overwriteAssembly = Array.Exists(args, item => item.StartsWith("--assembly-overwrite"));
				bool profileOnlyOpts = Array.Exists(args, item => item.StartsWith("--profile-"));

				List<RegistryAssemblyConfiguration> cfgs = new List<RegistryAssemblyConfiguration>();

				if (profileOnlyOpts == false) {
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.CoreProfile.xml"));
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.ES2Profile.xml"));
					cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.SC2Profile.xml"));
				} else {
					if (Array.Exists(args, item => (item.StartsWith("--profile-core"))))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.CoreProfile.xml"));
					if (Array.Exists(args, item => (item.StartsWith("--profile-es2"))))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.ES2Profile.xml"));
					if (Array.Exists(args, item => (item.StartsWith("--profile-sc2"))))
						cfgs.Add(RegistryAssemblyConfiguration.Load("BindingsGen.Profiles.SC2Profile.xml"));
				}

				foreach (RegistryAssemblyConfiguration cfg in cfgs) {
					try {
						RegistryAssembly.CleanAssembly(assemblyPath, cfg, overwriteAssembly);
					} catch (Exception exception) {
						Console.WriteLine("Unable to process assembly: {0}.", exception);
					}
				}

				// Exclusive option
				return;
			}

			#endregion

			#region Log Maps

			if ((args.Length > 0) && (Array.FindIndex(args, item => item == "--only-logmaps") >= 0)) {
				if ((args.Length == 1) || (Array.FindIndex(args, item => item == "--gl") >= 0)) {
					Console.WriteLine("Generating GL log map...");
					ctx = new RegistryContext("Gl", "Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGl.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, item => item == "--wgl") >= 0)) {
					Console.WriteLine("Generating WGL log map...");
					ctx = new RegistryContext("Wgl", "Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapWgl.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, item => item == "--glx") >= 0)) {
					Console.WriteLine("Generating GLX log map...");
					ctx = new RegistryContext("Glx", "Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGlx.xml"));
				}

				if ((args.Length == 1) || (Array.FindIndex(args, item => item == "--egl") >= 0)) {
					Console.WriteLine("Generating EGL log map...");
					ctx = new RegistryContext("Egl", "Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
					glRegistryProcessor = new RegistryProcessor(ctx.Registry);
					glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapEgl.xml"));
				}

				// Exclusive option
				return;
			}

			#endregion

			bool genGL = (args.Length == 0) || (Array.FindIndex(args, item => item == "--gl") >= 0);
			bool genWGL = (args.Length == 0) || (Array.FindIndex(args, item => item == "--wgl") >= 0);
			bool genGLX = (args.Length == 0) || (Array.FindIndex(args, item => item == "--glx") >= 0);
			bool genEGL = (args.Length == 0) || (Array.FindIndex(args, item => item == "--egl") >= 0);

			// (Common) Documentation
			RegistryDocumentation<RegistryDocumentationHandlerGL4> gl4Documentation = new RegistryDocumentation<RegistryDocumentationHandlerGL4>();
			RegistryDocumentation<RegistryDocumentationHandlerGL2> gl2Documentation = new RegistryDocumentation<RegistryDocumentationHandlerGL2>();

			if (genGL || genWGL || genGLX) {
				gl4Documentation.Api = "GL4";
				if (DocDisabled == false)
					gl4Documentation.ScanDocumentation(Path.Combine(BasePath, "RefPages/OpenGL/gl4"));

				gl2Documentation.Api = "GL2.1";
				if (DocDisabled == false)
					gl2Documentation.ScanDocumentation(Path.Combine(BasePath, "RefPages/OpenGL/gl2.1"));
			}

			// XML-based specifications

			// OpenGL
			if (genGL) {
				bool genGL_Features = true, genGL_Commands = false, genGL_Extensions = false, genGL_Limits = false;

				foreach (string arg in Array.FindAll(args, item => (item.StartsWith("--gl-")))) {
					switch (arg.Substring(5, arg.Length - 5)) {
						case "commands":
							genGL_Commands = true;
							break;
						case "extensions":
							genGL_Extensions = true;
							break;
						case "limits":
							genGL_Limits = true;
							break;
					}
					genGL_Features = false;
				}

				// Additional ES documentation
				RegistryDocumentation<RegistryDocumentationHandlerGL4> gles3Documentation =
					new RegistryDocumentation<RegistryDocumentationHandlerGL4> { Api = "GLES3.2" };
				if (DocDisabled == false)
					gles3Documentation.ScanDocumentation(Path.Combine(BasePath, "RefPages/OpenGL/es3"));

				RegistryDocumentation<RegistryDocumentationHandlerGL2> gles1Documentation =
					new RegistryDocumentation<RegistryDocumentationHandlerGL2> { Api = "GLES1.1" };
				if (DocDisabled == false)
					gles1Documentation.ScanDocumentation(Path.Combine(BasePath, "RefPages/OpenGL/es1.1"));

				Console.WriteLine("Loading GL specification...");
				ctx = new RegistryContext("Gl", "Gl", Path.Combine(BasePath, "GLSpecs/gl.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);
				ctx.RefPages.Add(gles3Documentation);
				ctx.RefPages.Add(gles1Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				if (genGL_Features || genGL_Commands)
					glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				if (genGL_Features || genGL_Extensions)
					glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				if (genGL_Features || genGL_Limits)
					glRegistryProcessor.GenerateLimitsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGl.xml"));
			}

			// OpenGL for Windows
			if (genWGL) {
				ctx = new RegistryContext("Wgl", "Wgl", Path.Combine(BasePath, "GLSpecs/wgl.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapWgl.xml"));
			}

			// OpenGL for Unix
			if (genGLX) {
				ctx = new RegistryContext("Glx", "Glx", Path.Combine(BasePath, "GLSpecs/glx.xml"));
				ctx.RefPages.Add(gl4Documentation);
				ctx.RefPages.Add(gl2Documentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapGlx.xml"));
			}

			// EGL
			if (genEGL) {
				RegistryDocumentation<RegistryDocumentationHandlerEGL> eglDocumentation =
					new RegistryDocumentation<RegistryDocumentationHandlerEGL> { Api = "EGL" };
				eglDocumentation.ScanDocumentation(Path.Combine(BasePath, "RefPages/EGL-Registry/sdk/docs/man"));

				ctx = new RegistryContext("Egl", "Egl", Path.Combine(BasePath, "GLSpecs/egl.xml"));
				ctx.RefPages.Add(eglDocumentation);

				glRegistryProcessor = new RegistryProcessor(ctx.Registry);
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
				glRegistryProcessor.GenerateLogMap(ctx, Path.Combine(BasePath, "OpenGL.Net/KhronosLogMapEgl.xml"));
			}

			// OpenWF

			OutputBasePath = "OpenWF.Net";

			// OpenWF(C)
			// Note: you must setup CLI to generate this bindings
			if ((args.Length > 0) && (Array.FindIndex(args, item => item == "--wfc") >= 0)) {
				Header headRegistry = new Header("Wfc")
				{
					CommandExportRegex = "WF(D|C)_APIENTRY ",
					CommandCallConventionRegex = "WF(D|C)_API_CALL ",
					CommandExitRegex = " WF(D|C)_APIEXIT"
				};
				headRegistry.AppendHeader(Path.Combine(BasePath, "GLSpecs/WF/wfc.h"), new KhronosVersion(1, 0, KhronosVersion.ApiWfc));

				ctx = new RegistryContext("Wfc", "Wfc", headRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenWF");
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass( ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
			}

			// OpenWF(D)
			if ((args.Length == 0) || (Array.FindIndex(args, item => item == "--wfd") >= 0)) {
				Header headRegistry = new Header("Wfd")
				{
					CommandExportRegex = "WF(D|C)_APIENTRY ",
					CommandCallConventionRegex = "WF(D|C)_API_CALL ",
					CommandExitRegex = " WF(D|C)_APIEXIT"
				};
				headRegistry.AppendHeader(Path.Combine(BasePath, "GLSpecs/WF/wfd.h"), new KhronosVersion(1, 0, KhronosVersion.ApiWfd));

				ctx = new RegistryContext("Wfd", "Wfd", headRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenWF");
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				glRegistryProcessor.GenerateVersionsSupportClass(ctx);
				glRegistryProcessor.GenerateVbCommands(ctx);
			}

			// OpenVX

			OutputBasePath = "OpenVX.Net";

			if ((args.Length == 0) || (Array.FindIndex(args, item => item == "--vx") >= 0)) {
				Header vxRegistry = new Header("VX")
				{
					CommandExportRegex = "VX_API_ENTRY ",
					CommandCallConventionRegex = "VX_API_CALL "
				};
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_api.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_types.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_kernels.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_nodes.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_vendors.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_import.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));

				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_khr_icd.h"), "VX_KHR_icd");
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_khr_ix.h"), "VX_KHR_ix");
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_khr_nn.h"), "VX_KHR_nn");
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_khr_tiling.h"), "VX_KHR_tiling");
				vxRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vx_khr_xml.h"), "VX_KHR_xml");

				ctx = new RegistryContext("VX", "VX", vxRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenVX");
				glRegistryProcessor.GenerateStronglyTypedEnums(ctx, Path.Combine(BasePath, $"{OutputBasePath}/{ctx.Class}.Enums.cs"));
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
				//glRegistryProcessor.GenerateExtensionsSupportClass(ctx);
				//glRegistryProcessor.GenerateVersionsSupportClass(ctx);

				Header vxuRegistry = new Header("VXU")
				{
					CommandExportRegex = "VX_API_ENTRY ",
					CommandCallConventionRegex = "VX_API_CALL "
				};
				vxuRegistry.AppendHeader(Path.Combine(BasePath, "VXSpecs/1.2/vxu.h"), new KhronosVersion(1, 2, KhronosVersion.ApiVx));

				ctx = new RegistryContext("VXU", "VX", vxuRegistry);
				glRegistryProcessor = new RegistryProcessor(ctx.Registry, "OpenVX");
				glRegistryProcessor.GenerateCommandsAndEnums(ctx);
			}
		}

		public static bool DocDisabled;

		public static bool DummyStream;

		/// <summary>
		/// Base path to construct correct file paths.
		/// </summary>
		public static readonly string BasePath = "../../..";

		/// <summary>
		/// The directory where the output files are placed.
		/// </summary>
		public static string OutputBasePath = "OpenGL.Net";
	}
}
