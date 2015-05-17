
// Copyright (C) 2009-2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Reflection;

namespace OpenGL
{
	/// <summary>
	/// OpenGL implementation capabilities.
	/// </summary>
	public class GraphicsCapabilities
	{
		#region Query

		/// <summary>
		/// Query OpenGL implementation extensions.
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public static GraphicsCapabilities Query(GraphicsContext ctx, IDeviceContext deviceContext)
		{
			GraphicsCapabilities graphicsCapabilities = new GraphicsCapabilities();
			FieldInfo[] capsFields = typeof(GraphicsCapabilities).GetFields(BindingFlags.Public | BindingFlags.Instance);

			#region Platform Extension Reload

			// Since at this point there's a current OpenGL context, it's possible to use
			// {glx|wgl}GetExtensionsString to retrieve platform specific extensions

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32Windows:
				case PlatformID.Win32S:
				case PlatformID.WinCE:
					Wgl.SyncDelegates();
					break;
			}

			#endregion

			// Only boolean fields are considered
			FieldInfo[] extsFields = Array.FindAll<FieldInfo>(capsFields, delegate(FieldInfo info) {
				return (info.FieldType == typeof(bool));
			});

			foreach (FieldInfo field in extsFields) {
				Attribute[] graphicsExtensionAttributes = Attribute.GetCustomAttributes(field, typeof(GraphicsExtensionAttribute));
				GraphicsExtensionDisabledAttribute graphicsExtensionDisabled = (GraphicsExtensionDisabledAttribute)Attribute.GetCustomAttribute(field, typeof(GraphicsExtensionDisabledAttribute));
				bool implemented = false;

				// Check whether at least one extension is implemented
				implemented = Array.Exists(graphicsExtensionAttributes, delegate(Attribute item) {
					return ((GraphicsExtensionAttribute)item).IsSupported(ctx, deviceContext);
				});
				// Check whether the required extensions are artifically disabled
				if (graphicsExtensionDisabled != null)
					implemented = false;

				field.SetValue(graphicsCapabilities, implemented);
			}

			return (graphicsCapabilities);
		}

		#endregion

		#region OpenGL Information

		/// <summary>
		/// The graphic adapter used as renderer.
		/// </summary>
		[GraphicsInfoAttribute(Gl.RENDERER)]
		public string RendererString;

		/// <summary>
		/// The renderer vendor.
		/// </summary>
		[GraphicsInfoAttribute(Gl.VENDOR)]
		public string VendorString;

		/// <summary>
		/// The implemented OpenGL version.
		/// </summary>
		[GraphicsInfoAttribute(Gl.VERSION)]
		public string VersionString;

		/// <summary>
		/// The implemented OpenGL Shading Language version.
		/// </summary>
		[GraphicsInfoAttribute(Gl.SHADING_LANGUAGE_VERSION)]
		public string ShadingLanguageVersion;

		/// <summary>
		/// Extensions implemeneted by renderer.
		/// </summary>
		[GraphicsInfoAttribute(Gl.EXTENSIONS)]
		public string Extensions;

		#endregion

		#region OpenGL Extensions (ARB)

		/// <summary>
		/// Multisample rendering availability flag (5. {GL|WGL|GLX}_ARB_multisample).
		/// </summary>
		/// <remarks>
		/// Core implementation differences
		///
		/// Multisampling was promoted from the GL ARB multisample extension; The
		/// definition of the extension was changed slightly to support both multisampling and
		/// supersampling implementations.
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_multisample", "WGL_ARB_multisample", "GLX_ARB_multisample")]
		public bool Multisample;

		/// <summary>
		/// Depth texture format available (22. GL_ARB_depth_texture).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_depth_texture")]
		public bool DepthTexture;

		/// <summary>
		/// Vertex buffer object available (28. GL_ARB_vertex_buffer_object, GLX_ARB_vertex_buffer_object).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation:
		/// 
		/// Buffer objects allow various types of data (especially vertex array data) to be
		/// cached in high-performance graphics memory on the server, thereby increasing
		/// the rate of data transfers to the GL.
		/// Buffer objects were promoted from the GL ARB vertex buffer object extension.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_vertex_buffer_object", "GLX_ARB_vertex_buffer_object")]
		public bool VertexBufferObject;

		/// <summary>
		/// Occlusion query available (29. GL_ARB_occlusion_query).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation has no differences.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_occlusion_query")]
		public bool OcclusionQuery;

		/// <summary>
		/// Shader objects (30. GL_ARB_shader_objects)
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation differences (Shader Objects)
		/// 
		/// Shader objects provides mechanisms necessary to manage shader and program objects.
		/// Shader objects were promoted from the GL ARB shader objects extension.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_shader_objects")]
		public bool ShaderObjects;

		/// <summary>
		/// Vertex shader extension (31. GL_ARB_vertex_shader).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation differences (Changes To Shader APIs)
		/// 
		/// Small changes to the APIs for managing shader and program objects were made
		/// in the process of promoting the shader extensions to the OpenGL 2.0 core. These
		/// changes do not affect the functionality of the shader APIs, but include use of the
		/// existing uint core GL type rather than the new handleARB type introduced by
		/// the extensions, and changes in some function names, for example mapping the extension
		/// function CreateShaderObjectARB into the core function CreateShader.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_vertex_shader")]
		public bool VertexShader;

		/// <summary>
		/// Fragment shader extension (32. GL_ARB_fragment_shader).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation differences (Changes To Shader APIs)
		/// 
		/// Small changes to the APIs for managing shader and program objects were made
		/// in the process of promoting the shader extensions to the OpenGL 2.0 core. These
		/// changes do not affect the functionality of the shader APIs, but include use of the
		/// existing uint core GL type rather than the new handleARB type introduced by
		/// the extensions, and changes in some function names, for example mapping the extension
		/// function CreateShaderObjectARB into the core function CreateShader.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_fragment_shader")]
		public bool FragmentShader;

		/// <summary>
		/// Shading language version support (33. GL_ARB_shading_language_100).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_shading_language_100")]
		public bool ShadingLanguage100;

		/// <summary>
		/// Texture Non Power Of Two extension (34. GL_ARB_texture_non_power_of_two).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_non_power_of_two")]
		public bool TextureNPOT;

		/// <summary>
		/// Rectangle texture extension (38. GL_ARB_texture_rectangle).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_rectangle")]
		public bool TextureRectangle;

		/// <summary>
		/// Half float pixel extension (40. GL_ARB_half_float_pixel).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_half_float_pixel")]
		public bool HalfFloatPixel;

		/// <summary>
		/// Floating point texture extention (41. GL_ARB_texture_float).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_float")]
		public bool TextureFloat;

		/// <summary>
		/// Floating-point depth texture extension (43. GL_ARB_depth_buffer_float).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_depth_buffer_float")]
		public bool DepthTextureFloat;

		/// <summary>
		/// Framebuffer object (45. GL_ARB_framebuffer_object).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_framebuffer_object")]
		public bool FrambufferObject;

		/// <summary>
		/// sRGB framebuffer extension (46. GL_ARB_framebuffer_sRGB).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_framebuffer_sRGB", "WGL_ARB_framebuffer_sRGB", "GLX_ARB_framebuffer_sRGB")]
		public bool FramebufferSRGB;

		/// <summary>
		/// Geometry shader extension (47. GL_ARB_geometry_shader4).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_geometry_shader4")]
		public bool GeometryShader;

		/// <summary>
		/// Vertex array (54. GL_ARB_vertex_array_object).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_vertex_array_object")]
		public bool VertexArrayObject;

		/// <summary>
		/// Texture RG format available (53. GL_ARB_texture_rg).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_rg")]
		public bool TextureRg;

		/// <summary>
		/// Uniform buffer object extension (57. GL_ARB_uniform_buffer_object);
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_uniform_buffer_object")]
		public bool UniformBufferObject;

		/// <summary>
		/// Compatibility extension (58. GL_ARB_compatibility).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_compatibility")]
		public bool Compatibility;

		/// <summary>
		/// Cube map texture extension (65. GL_ARB_texture_cube_map).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_cube_map")]
		public bool TextureCubeMap;

		/// <summary>
		/// Shading language include preprocessor directive (76. GL_ARB_shading_language_include).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_shading_language_include")]
		public bool ShaderInclude;

		/// <summary>
		/// Occlusion query (2th version) available (80. GL_ARB_occlusion_query2).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_occlusion_query2")]
		public bool OcclusionQuery2;

		/// <summary>
		/// Texture swizzle available (84. GL_ARB_texture_swizzle).
		/// </summary>
		/// <remarks>
		/// The GL_ARB_texture_swizzle and GL_EXT_texture_swizzle are exactly the same extention, having the same functionalities, declarations and
		/// specification. Indeed, they share also the minimum version and the core version.
		/// </remarks>
		[GraphicsExtensionAttribute("GL_ARB_texture_swizzle", "GL_EXT_texture_swizzle")]
		public bool TextureSwizzle;

		/// <summary>
		/// Timer query available (85. GL_ARB_timer_query).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_timer_query")]
		public bool TimerQuery;

		/// <summary>
		/// 5th generation shader available (88. GL_ARB_gpu_shader5).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_gpu_shader5")]
		public bool GpuShader5;

		/// <summary>
		/// Double precision floating-point shader uniform/input/instructions available (89. GL_ARB_gpu_shader_fp64).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_gpu_shader_fp64")]
		public bool GpuShaderFp64;

		/// <summary>
		/// Texture buffer object available (92. GL_ARB_texture_buffer_object_rgb32).
		/// </summary>
		[GraphicsExtensionAttribute("GL_ARB_texture_buffer_object_rgb32")]
		public bool TextureBufferObjectRgb32;

		#endregion

		#region OpenGL Extensions (EXT)

		/// <summary>
		/// Constant color blending functions (2. GL_EXT_blend_color).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_blend_color")]
		public bool BlendColor;

		/// <summary>
		/// Texture internal formats (4. GL_EXT_texture).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation (Texture Image Formats)
		/// 
		/// Stored texture arrays have a format, known as the internal format, rather than a
		/// simple count of components. The internal format is represented as a single enumerated
		/// value, indicating both the organization of the image data (LUMINANCE,
		/// RGB, etc.) and the number of bits of storage for each image component. Clients
		/// can use the internal format specification to suggest the desired storage precision
		/// of texture images. New base internal formats, ALPHA and INTENSITY, provide
		/// new texture environment operations. These additions match those of a subset of
		/// the GL EXT texture extension.
		/// </para>
		/// <para>
		/// Core implementation (Texture Replace Environment)
		/// 
		/// A common use of texture mapping is to replace the color values of generated
		/// fragments with texture color data. This could be specified only indirectly in GL
		/// version 1.0, which required that client specified white geometry be modulated
		/// by a texture. GL version 1.1 allows such replacement to be specified explicitly,
		/// possibly improving performance. These additions match those of a subset of the
		/// GL EXT texture extension.
		/// </para>
		/// <para>
		/// Core implementation (Texture Proxies)
		/// 
		/// Texture proxies allow a GL implementation to advertise different maximum texture
		/// image sizes as a function of some other texture parameters, especially of the
		/// internal image format. Clients may use the proxy query mechanism to tailor their
		/// use of texture resources at run time. The proxy interface is designed to allow such
		/// queries without adding new routines to the GL interface. These additions match
		/// those of a subset of the GL EXT texture extension, except that implementations
		/// return allocation information consistent with support for complete mipmap arrays.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_texture")]
		public bool Texture;

		/// <summary>
		/// Texture 3D extension (6. EXT_texture3D).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_texture3D")]
		public bool Texture3D;

		/// <summary>
		/// Sub-texture specification (9. GL_EXT_subtexture).
		/// </summary>
		/// <remarks>
		/// Core implementation
		/// 
		/// Texture array data can be specified from framebuffer memory, as well as from
		/// client memory, and rectangular subregions of texture arrays can be redefined either
		/// from client or framebuffer memory. These additions match those defined by the
		/// GL EXT copy texture and GL EXT subtexture extensions.
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_subtexture")]
		[GraphicsExtensionAttribute("GL_EXT_texture")]
		public bool SubTexture;

		/// <summary>
		/// Texture copy (10. GL_EXT_texture_object).
		/// </summary>
		/// <remarks>
		/// Core implementation
		/// 
		/// Texture array data can be specified from framebuffer memory, as well as from
		/// client memory, and rectangular subregions of texture arrays can be redefined either
		/// from client or framebuffer memory. These additions match those defined by the
		/// GL EXT copy texture and GL EXT subtexture extensions.
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_copy_texture")]
		[GraphicsExtensionAttribute("GL_EXT_texture")]
		public bool CopyTexture;

		/// <summary>
		/// CMYKA pixel format (18. EXT_cmyka).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_cmyka")]
		public bool CmykaFormat;

		/// <summary>
		/// Texture object (20. GL_EXT_texture_object).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation
		/// 
		/// A set of texture arrays and their related texture state can be treated as a single
		/// object. Such treatment allows for greater implementation efficiency when multiple
		/// arrays are used. In conjunction with the subtexture capability, it also allows
		/// clients to make gradual changes to existing texture arrays, rather than completely
		/// redefining them. These additions match those of the GL EXT texture object
		/// extension, with slight additions to the texture residency semantics.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_texture_object")]
		public bool TextureObject;

		/// <summary>
		/// RGB(A)/BGR(A) packed pixel internal formats (23. Gl_EXT_packed_pixels).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation:
		/// 
		/// Packed pixels in client memory are represented entirely by one unsigned byte,
		/// one unsigned short, or one unsigned integer. The fields with the packed pixel are
		/// not proper machine types, but the pixel as a whole is. Thus the pixel storage modes
		/// and their unpacking counterparts all work correctly with packed pixels.
		/// The additions match those of the GL EXT packed pixels extension, with the
		/// further addition of reversed component order packed formats
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_packed_pixels")]
		public bool PackedFormats;

		/// <summary>
		/// Blending separate function (37. GL_EXT_blend_minmax)
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_blend_minmax")]
		public bool BlendMinMax;

		/// <summary>
		/// Blending subtract equations (38. GL_EXT_blend_subtract)
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_blend_subtract")]
		public bool BlendSubtract;

		/// <summary>
		/// BGRA pixel format (128. GL_EXT_bgra).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation:
		/// 
		/// BGRA extends the list of client memory color formats. Specifically, it provides
		/// a component order matching file and framebuffer formats common on Windows
		/// platforms. The additions match those of the GL EXT bgra extension.
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_bgra")]
		public bool BgraFormat;

		/// <summary>
		/// Blending separate function (173. GL_EXT_blend_func_separate)
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_blend_func_separate")]
		public bool BlendFuncSeparate;

		/// <summary>
		/// Yuv 422 pixel format (178. GL_EXT_422_pixels).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_422_pixels")]
		public bool Yuv422Format;

		/// <summary>
		/// Blending separate equation (299. GL_EXT_blend_equation_separate)
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_blend_equation_separate")]
		public bool BlendEquationSeparate;

		/// <summary>
		/// Texture sRGB internal format (315. GL_EXT_texture_sRGB).
		/// </summary>
		/// <remarks>
		/// <para>
		/// Core implementation
		/// 
		/// New uncompressed and compressed color texture formats with sRGB color components
		/// are defined. The sRGB color space is based on typical (non-linear) monitor
		/// characteristics expected in a dimly lit office. It has been standardized by the International
		/// Electrotechnical Commission (IEC) as IEC 61966-2-1. The sRGB color
		/// space roughly corresponds to 2.2 gamma correction.
		/// sRGB textures was promoted from the GL EXT texture sRGB extension.
		/// Specific compressed sRGB internal formats defined by the extension were not included
		/// in OpenGL 2.1, while the generic uncompressed and compressed formats
		/// were retained
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_texture_sRGB")]
		public bool TextureSRGB;

		/// <summary>
		/// Framebuffer object (310. GL_EXT_framebuffer_object).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_framebuffer_object")]
		public bool FrambufferObject_EXT;

		/// <summary>
		/// 4th shader generation available (326. GL_EXT_gpu_shader4).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_gpu_shader4")]
		public bool GpuShader4;

		/// <summary>
		/// sRGB framebuffer extension (337. GL_EXT_framebuffer_sRGB).
		/// </summary>
		/// <remarks>
		/// This extention is almost similar to the extention GL_ARB_framebuffer_sRGB, except for one particular; the following
		/// text shall be removed in order to obtain an equivalent GL_ARB_framebuffer_sRGB specification:
		/// <para>
		/// Accepted by the <i>pname</i> parameter of GetBooleanv, GetIntegerv,
		/// GetFloatv, and GetDoublev:
		///			FRAMEBUFFER_SRGB_CAPABLE_EXT                 0x8DBA
		/// </para>
		/// </remarks>
		[GraphicsExtensionAttribute("GL_EXT_framebuffer_sRGB", "GLX_EXT_framebuffer_sRGB", "WGL_EXT_framebuffer_sRGB")]
		public bool FramebufferSRGB_EXT;

		/// <summary>
		/// Texture integer extension (343. GL_EXT_texture_integer).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_texture_integer")]
		public bool TextureInteger;

		/// <summary>
		/// Transform feedback extension (343. GL_EXT_transform_feedback).
		/// </summary>
		[GraphicsExtensionAttribute("GL_EXT_transform_feedback")]
		public bool FeedbackBuffer;

		#endregion

		#region OpenGL Extensions (WGL/GLX)

		/// <summary>
		/// Fundation for querying OpenGL extension using WGL.
		/// </summary>
		[GraphicsExtensionAttribute("WGL_ARB_extensions_string")]
		public bool ExtensionString;

		/// <summary>
		/// Choose a window pixel format (9. WGL_ARB_pixel_format).
		/// </summary>
		[GraphicsExtensionAttribute("WGL_ARB_pixel_format")]
		[GraphicsExtensionAttribute("WGL_ARB_extensions_string")]
		public bool ExtendedPixelFormat;

		/// <summary>
		/// Create a compatible context (55. WGL_ARB_create_context, 56. GLX_ARB_create_context).
		/// </summary>
		[GraphicsExtensionAttribute("WGL_ARB_create_context", "GLX_ARB_create_context")]
		[GraphicsExtensionAttribute("WGL_ARB_extensions_string")]
		public bool CreateContext;

		/// <summary>
		/// Create a forward compatible context (74. WGL_ARB_create_context_profile, 75. GLX_ARB_create_context_profile).
		/// </summary>
		[GraphicsExtensionAttribute("WGL_ARB_create_context_profile", "GLX_ARB_create_context_profile")]
		[GraphicsExtensionAttribute("WGL_ARB_extensions_string")]
		public bool CreateContextProfile;

		#endregion
	}
}
