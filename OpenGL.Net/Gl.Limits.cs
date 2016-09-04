
// Copyright (C) 2016 Luca Piccioni
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
	public partial class Gl
	{
		/// <summary>
		/// Class collecting the OpenGL implementation limits.
		/// </summary>
		public sealed class Limits
		{
			#region Query

			/// <summary>
			/// Query the OpenGL implementation limits.
			/// </summary>
			/// <param name="glExtensions">
			/// A <see cref="Gl.Extensions"/> that specify the supported OpenGL extension by the current
			/// implementation.
			/// </param>
			/// <returns>
			/// It returns a <see cref="GraphicsLimits"/> that specify the current OpenGL implementation limits.
			/// </returns>
			/// <remarks>
			/// It is assumed to have a valid OpenGL context current on the calling thread.
			/// </remarks>
			public static Limits Query(Extensions glExtensions)
			{
				if (glExtensions == null)
					throw new ArgumentNullException("glExtensions");

				LogComment("Query OpenGL implementation limits.");

				Limits graphicsLimits = new Limits();
				FieldInfo[] graphicsLimitsFields = typeof(Limits).GetFields(BindingFlags.Public | BindingFlags.Instance);

				foreach (FieldInfo field in graphicsLimitsFields) {
					LimitAttribute graphicsLimitAttribute = (LimitAttribute)Attribute.GetCustomAttribute(field, typeof(LimitAttribute));
					Attribute[] graphicsExtensionAttributes = Attribute.GetCustomAttributes(field, typeof(KhronosApi.ExtensionAttribute));
					MethodInfo getMethod;

					if (graphicsLimitAttribute == null)
						continue;

					// Check extension support
					if ((graphicsExtensionAttributes != null) && (graphicsExtensionAttributes.Length > 0)) {
						bool supported = Array.Exists(graphicsExtensionAttributes, delegate(Attribute item) {
							return glExtensions.HasExtensions(((KhronosApi.ExtensionAttribute)item).ExtensionName);
						});

						if (supported == false)
							continue;
					}

					// Determine which method is used to get the OpenGL limit
					if (field.FieldType != typeof(String)) {
						if (field.FieldType.IsArray == true)
							getMethod = typeof(Gl).GetMethod("Get", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32), field.FieldType }, null);
						else
							getMethod = typeof(Gl).GetMethod("Get", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32), field.FieldType.MakeByRefType() }, null);
					} else
						getMethod = typeof(Gl).GetMethod("GetString", BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(Int32) }, null);

					if (getMethod != null) {
						if (field.FieldType != typeof(String)) {
							object obj;

							if (field.FieldType.IsArray == false)
								obj = Activator.CreateInstance(field.FieldType);
							else
								obj = Array.CreateInstance(field.FieldType.GetElementType(), graphicsLimitAttribute.ArrayLenght);

							try {
								object[] @params = new object[] { graphicsLimitAttribute.EnumValue, obj };
								getMethod.Invoke(null, @params);
								field.SetValue(graphicsLimits, @params[1]);
							} catch (GlException) {

							} catch (Exception) {
								
							}
						} else {
							try {
								string s = (string)getMethod.Invoke(null, new object[] { graphicsLimitAttribute.EnumValue });
								field.SetValue(graphicsLimits, s);
							} catch (GlException) {

							} catch (Exception) {
							
							}
						}
					} else
						throw new InvalidOperationException("GraphicsLimits field " + field.Name + " doesn't have a OpenGL compatible type");
				}

				return (graphicsLimits);
			}

			#endregion

			#region OpenGL 1.1 Limits

			/// <summary>
			/// Range of the widths supported for smooth lines.
			/// </summary>
			[Limit(Gl.LINE_WIDTH_RANGE, ArrayLenght = 2)]
			public float[] LineWidthRange = new float[] { 0.0f, 0.0f };

			/// <summary>
			/// Granularity of the effective value set by <see cref="Gl.LineWidth(float)"/> (minimum and maximum).
			/// </summary>
			[Limit(Gl.LINE_WIDTH_GRANULARITY)]
			public int LineWidthGranularity;

			/// <summary>
			/// Maximum 2D texture extents.
			/// </summary>
			[Limit(Gl.MAX_TEXTURE_SIZE)]
			public int MaxTexture2DSize;

			/// <summary>
			/// Maximum viewport dimensions (width and height).
			/// </summary>
			[Limit(Gl.MAX_VIEWPORT_DIMS, ArrayLenght = 2)]
			public int[] MaxViewportDims = new int[] { 0, 0 };

			#endregion

			#region OpenGL 1.2 Limits

			/// <summary>
			/// Range of the widths supported for aliased lines.
			/// </summary>
			[Limit(Gl.ALIASED_LINE_WIDTH_RANGE, ArrayLenght = 2)]
			public float[] AliasedLineWidthRange = new float[] { 0.0f, 0.0f };

			/// <summary>
			/// Maximum number of drawable attribute array length.
			/// </summary>
			[Limit(Gl.MAX_ELEMENTS_VERTICES)]
			public int MaxElementsVertices;

			/// <summary>
			/// Maximum number of drawable attribute elements.
			/// </summary>
			[Limit(Gl.MAX_ELEMENTS_INDICES)]
			public int MaxElementsIndices;

			/// <summary>
			/// Maximum 3D texture extents.
			/// </summary>
			[Limit(Gl.MAX_3D_TEXTURE_SIZE)]
			[Extension("GL_EXT_texture3D")]
			public int MaxTexture3DSize;

			#endregion

			#region OpenGL 1.3 Limits

			/// <summary>
			/// Maximum cube map texture extents.
			/// </summary>
			[Limit(Gl.MAX_CUBE_MAP_TEXTURE_SIZE)]
			[Extension("GL_ARB_texture_cube_map")]
			public int MaxTextureCubeSize;

			#endregion

			#region OpenGL 2.0 Limits

			/// <summary>
			/// Maximum number of texture image units usable by all shader program stages at once.
			/// </summary>
			[Limit(Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS)]
			[Extension("GL_ARB_shader_program")]
			public int MaxCombinedTextureImageUnits;

			/// <summary>
			/// The maximum number of color attachments that a shader support.
			/// </summary>
			[Limit(Gl.MAX_DRAW_BUFFERS)]
			public int MaxDrawBuffers;

			/// <summary>
			/// Maximum number of texture coordinate units usable by a fragment shader.
			/// </summary>
			[Limit(Gl.MAX_TEXTURE_COORDS)]
			[Extension("GL_ARB_fragment_shader")]
			public int MaxFragmentTextureCoordUnits;

			/// <summary>
			/// Maximum number of texture units usable  by a fragment shader.
			/// </summary>
			[Limit(Gl.MAX_TEXTURE_IMAGE_UNITS)]
			[Extension("GL_ARB_fragment_shader")]
			public int MaxFragmentTextureImageUnits;

			/// <summary>
			/// Maximum number of components for a fragment shader uniform variable.
			/// </summary>
			[Limit(Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS)]
			[Extension("GL_ARB_fragment_shader")]
			public int MaxFragmentUniformComponents;

			/// <summary>
			/// Maximum number of varying vertex attributes.
			/// </summary>
			[Limit(Gl.MAX_VERTEX_ATTRIBS)]
			[Extension("GL_ARB_vertex_shader")]
			public int MaxVertexAttrib;

			/// <summary>
			/// Maximum number of texture units usable  by a vertex shader.
			/// </summary>
			[Limit(Gl.MAX_VERTEX_TEXTURE_IMAGE_UNITS)]
			[Extension("GL_ARB_vertex_shader")]
			public int MaxVertexTextureImageUnits;

			/// <summary>
			/// Maximum number of components for a vertex shader uniform variable.
			/// </summary>
			[Limit(Gl.MAX_VERTEX_UNIFORM_COMPONENTS)]
			[Extension("GL_ARB_vertex_shader")]
			public int MaxVertexUniformComponents;

			#endregion

			#region OpenGL 3.0 Limits

			/// <summary>
			/// The maximum number of layers that the array texture support.
			/// </summary>
			[Limit(Gl.MAX_ARRAY_TEXTURE_LAYERS)]
			[KhronosApi.CoreExtension(3, 0)]
			[Extension("GL_EXT_texture_array")]
			public int MaxArrayTextureLayers;

			/// <summary>
			/// The maximum number of color attachments that the frambuffer support.
			/// </summary>
			[Limit(Gl.MAX_COLOR_ATTACHMENTS)]
			[Extension("GL_ARB_framebuffer_object")]
			[Extension("GL_EXT_framebuffer_object")]
			public int MaxColorAttachments;

			/// <summary>
			/// The maximum size of render buffers.
			/// </summary>
			[Limit(Gl.MAX_RENDERBUFFER_SIZE)]
			[Extension("GL_ARB_framebuffer_object")]
			[Extension("GL_EXT_framebuffer_object")]
			public int MaxRenderBufferSize;

			/// <summary>
			/// The maximum number of components allowed in an inteleaved feedback buffer.
			/// </summary>
			[Limit(Gl.MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS)]
			[Extension("GL_EXT_transform_feedback")]
			[Extension("GL_NV_transform_feedback")]
			public int MaxTransformFeedbackInterleavedComponents;

			/// <summary>
			/// The maximum number of seperate feedback buffers allowed.
			/// </summary>
			[Limit(Gl.MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS)]
			[Extension("GL_EXT_transform_feedback")]
			[Extension("GL_NV_transform_feedback")]
			public int MaxTransformFeedbackSeparateComponents;

			/// <summary>
			/// Maximum sample bits for framebuffer attachments standard format.
			/// </summary>
			[Limit(Gl.MAX_SAMPLES)]
			public int MaxSamples = 0;

			#endregion

			#region OpenGL 3.1 Limits

			/// <summary>
			/// Maximum rectangle texture extents.
			/// </summary>
			[Limit(Gl.MAX_RECTANGLE_TEXTURE_SIZE)]
			[Extension("GL_ARB_texture_rectangle")]
			public int MaxTextureRectSize;

			/// <summary>
			/// Maximum number of uniform blocks on a vertex shader.
			/// </summary>
			[Limit(Gl.MAX_VERTEX_UNIFORM_BLOCKS)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int MaxVertexUniformBlocks;

			/// <summary>
			/// Maximum number of uniform blocks on a fragment shader.
			/// </summary>
			[Limit(Gl.MAX_FRAGMENT_UNIFORM_BLOCKS)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int MaxFragmentUniformBlocks;

			/// <summary>
			/// Maximum number of combined uniform blocks.
			/// </summary>
			[Limit(Gl.MAX_COMBINED_UNIFORM_BLOCKS)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int MaxCombinedUniformBlocks;

			/// <summary>
			/// Maximum size for an uniform block.
			/// </summary>
			[Limit(Gl.MAX_UNIFORM_BLOCK_SIZE)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int MaxUniformBlockSize;

			/// <summary>
			/// Maximum number of indexed bindings for an uniform buffer.
			/// </summary>
			[Limit(Gl.MAX_UNIFORM_BUFFER_BINDINGS)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int MaxUniformBufferBindings;

			/// <summary>
			/// The required offset alignment for binding an uniform buffer with an offset.
			/// </summary>
			[Limit(Gl.UNIFORM_BUFFER_OFFSET_ALIGNMENT)]
			[Extension("GL_ARB_uniform_buffer_object")]
			public int UniformBufferOffsetAlignment;

			#endregion

			#region OpenGL 3.2 Limits

			/// <summary>
			/// Maximum sample bits for framebuffer attachments with integer format.
			/// </summary>
			[Limit(Gl.MAX_INTEGER_SAMPLES)]
			[Extension("GL_ARB_texture_multisample")]
			public int MaxIntegerSamples = 0;

			/// <summary>
			/// Maximum number of inputs for fragment shader.
			/// </summary>
			[Limit(Gl.MAX_FRAGMENT_INPUT_COMPONENTS)]
			[Extension("GL_ARB_fragment_shader")]
			public int MaxFragmentInputComponents;

			/// <summary>
			/// Maximum vertices outputtable by a geometry shader.
			/// </summary>
			[Limit(Gl.MAX_GEOMETRY_OUTPUT_VERTICES)]
			[Extension("GL_ARB_geometry_shader4")]
			public int MaxGeometryOutputVertices = 0;

			/// <summary>
			/// Maximum number of texture units usable  by a geometry shader.
			/// </summary>
			[Limit(Gl.MAX_GEOMETRY_TEXTURE_IMAGE_UNITS)]
			[Extension("GL_ARB_geometry_shader4")]
			public int MaxGeometryTextureImageUnits;

			/// <summary>
			/// Maximum number of components for a geometry shader uniform variable.
			/// </summary>
			[Limit(Gl.MAX_GEOMETRY_UNIFORM_COMPONENTS)]
			[Extension("GL_ARB_geometry_shader4")]
			public int MaxGeometryUniformComponents;

			/// <summary>
			/// Maximum number of outputs for vertex shader.
			/// </summary>
			[Limit(Gl.MAX_VERTEX_OUTPUT_COMPONENTS)]
			[Extension("GL_ARB_vertex_shader")]
			public int MaxVertexOutputsComponents = 0;

			#endregion
		}
	}
}
