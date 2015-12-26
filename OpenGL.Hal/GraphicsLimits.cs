
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
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Class collecting the OpenGL implementation limits.
	/// </summary>
	public sealed class GraphicsLimits
	{
		#region Query

		/// <summary>
		/// Query the OpenGL implementation limits.
		/// </summary>
		/// <param name="glExtensions">
		/// A <see cref="Gl.Extensions"/> that specifies the supported OpenGL extension by the current
		/// implementation.
		/// </param>
		/// <returns>
		/// It returns a <see cref="GraphicsLimits"/> that specifies the current OpenGL implementation limits.
		/// </returns>
		/// <remarks>
		/// It is assumed to have a valid OpenGL context current on the calling thread.
		/// </remarks>
		public static GraphicsLimits Query(Gl.Extensions glExtensions)
		{
			if (glExtensions == null)
				throw new ArgumentNullException("glExtensions");

			KhronosApi.LogComment("Query OpenGL implementation imits.");

			GraphicsLimits graphicsLimits = new GraphicsLimits();
			FieldInfo[] graphicsLimitsFields = typeof(GraphicsLimits).GetFields(BindingFlags.Public | BindingFlags.Instance);

			foreach (FieldInfo field in graphicsLimitsFields) {
				GraphicsLimitAttribute graphicsLimitAttribute = (GraphicsLimitAttribute)Attribute.GetCustomAttribute(field, typeof(GraphicsLimitAttribute));
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
						object[] @params = new object[] { graphicsLimitAttribute.EnumValue, obj };
						getMethod.Invoke(null, @params);

						field.SetValue(graphicsLimits, @params[1]);
					} else {
						string s = (string)getMethod.Invoke(null, new object[] { graphicsLimitAttribute.EnumValue });

						field.SetValue(graphicsLimits, s);
					}
				} else
					throw new InvalidOperationException("GraphicsLimits field " + field.Name + " doesn't have a OpenGL compatible type");

				string fieldValueString;
				object fieldValue = field.GetValue(graphicsLimits);

				if (fieldValue is Array) {
					StringBuilder sb = new StringBuilder();

					sb.Append("{ ");
					if (((Array)fieldValue).Length > 0) {
						foreach (object arrayItem in (Array)fieldValue)
							sb.AppendFormat("{0}, ", arrayItem);
						sb.Remove(sb.Length - 2, 2);
					}
					sb.Append(" }");

					fieldValueString = sb.ToString();
				} else
					fieldValueString = fieldValue.ToString();
			}

			return (graphicsLimits);
		}

		#endregion

		#region Viewport Limits

		/// <summary>
		/// Maximum viewport dimensions (width and height).
		/// </summary>
		[GraphicsLimit(Gl.MAX_VIEWPORT_DIMS, ArrayLenght = 2)]
		public int[] MaxViewport = new int[] { 0, 0 };

		#endregion

		#region Frambuffer Object Limits

		/// <summary>
		/// The maximum number of color attachments that the frambuffer support.
		/// </summary>
		[GraphicsLimit(Gl.MAX_COLOR_ATTACHMENTS)]
		[KhronosApi.Extension("GL_ARB_framebuffer_object")]
		[KhronosApi.Extension("GL_EXT_framebuffer_object")]
		public int MaxColorAttachments;

		/// <summary>
		/// The maximum size of render buffers.
		/// </summary>
		[GraphicsLimit(Gl.MAX_RENDERBUFFER_SIZE)]
		[KhronosApi.Extension("GL_ARB_framebuffer_object")]
		[KhronosApi.Extension("GL_EXT_framebuffer_object")]
		public int MaxRenderBufferSize;

		#endregion

		#region Multisampling Limits

		/// <summary>
		/// Maximum sample bits for framebuffer attachments standard format.
		/// </summary>
		[GraphicsLimit(Gl.MAX_SAMPLES)]
		public int MaxSamples = 0;

		/// <summary>
		/// Maximum sample bits for framebuffer attachments with integer format.
		/// </summary>
		[GraphicsLimit(Gl.MAX_INTEGER_SAMPLES)]
		public int MaxIntegerSamples = 0;

		#endregion

		#region Drawing Limits

		/// <summary>
		/// The maximum number of color attachments that a shader support.
		/// </summary>
		[GraphicsLimit(Gl.MAX_DRAW_BUFFERS)]
		public int MaxDrawBuffers;

		/// <summary>
		/// Maximum number of drawable attribute array length.
		/// </summary>
		[GraphicsLimit(Gl.MAX_ELEMENTS_VERTICES)]
		public int MaxElementsVertices;

		/// <summary>
		/// Maximum number of drawable attribute elements.
		/// </summary>
		[GraphicsLimit(Gl.MAX_ELEMENTS_INDICES)]
		public int MaxElementsIndices;

		#endregion

		#region Texture Size Limits

		/// <summary>
		/// Maximum 2D texture extents.
		/// </summary>
		[GraphicsLimit(Gl.MAX_TEXTURE_SIZE)]
		public int MaxTexture2DSize;

		/// <summary>
		/// Maximum 3D texture extents.
		/// </summary>
		[GraphicsLimit(Gl.MAX_3D_TEXTURE_SIZE)]
		[KhronosApi.Extension("GL_EXT_texture3D")]
		public int MaxTexture3DSize;

		/// <summary>
		/// Maximum rectangle texture extents.
		/// </summary>
		[GraphicsLimit(Gl.MAX_RECTANGLE_TEXTURE_SIZE)]
		[KhronosApi.Extension("GL_ARB_texture_rectangle")]
		public int MaxTextureRectSize;

		/// <summary>
		/// Maximum cube map texture extents.
		/// </summary>
		[GraphicsLimit(Gl.MAX_CUBE_MAP_TEXTURE_SIZE)]
		[KhronosApi.Extension("GL_ARB_texture_cube_map")]
		public int MaxTextureCubeSize;

		#endregion

		#region Shader Attributes

		/// <summary>
		/// Maximum number of varying vertex attributes.
		/// </summary>
		[GraphicsLimit(Gl.MAX_VERTEX_ATTRIBS)]
		[KhronosApi.Extension("GL_ARB_vertex_shader")]
		public int MaxVertexAttrib;

		/// <summary>
		/// Maximum number of outputs for vertex shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_VERTEX_OUTPUT_COMPONENTS)]
		[KhronosApi.Extension("GL_ARB_vertex_shader")]
		public int MaxVertexOutputsComponents = 0;

		/// <summary>
		/// Maximum number of inputs for fragment shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_FRAGMENT_INPUT_COMPONENTS)]
		[KhronosApi.Extension("GL_ARB_fragment_shader")]
		public int MaxFragmentInputComponents;

		#endregion

		#region Geometry Shader Output

		/// <summary>
		/// Maximum vertices outputtable by a geometry shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_GEOMETRY_OUTPUT_VERTICES)]
		[KhronosApi.Extension("GL_ARB_geometry_shader4")]
		public int MaxGeometryOutputVertices = 0;

		#endregion

		#region Texture Cooordinate and Image Units

		/// <summary>
		/// Maximum number of texture units usable  by a vertex shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_VERTEX_TEXTURE_IMAGE_UNITS)]
		[KhronosApi.Extension("GL_ARB_vertex_shader")]
		public int MaxVertexTextureImageUnits;

		/// <summary>
		/// Maximum number of texture units usable  by a geometry shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_GEOMETRY_TEXTURE_IMAGE_UNITS)]
		[KhronosApi.Extension("GL_ARB_geometry_shader4")]
		public int MaxGeometryTextureImageUnits;

		/// <summary>
		/// Maximum number of texture coordinate units usable by a fragment shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_TEXTURE_COORDS)]
		[KhronosApi.Extension("GL_ARB_fragment_shader")]
		public int MaxFragmentTextureCoordUnits;

		/// <summary>
		/// Maximum number of texture units usable  by a fragment shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_TEXTURE_IMAGE_UNITS)]
		[KhronosApi.Extension("GL_ARB_fragment_shader")]
		public int MaxFragmentTextureImageUnits;

		/// <summary>
		/// Maximum number of texture image units usable by all shader program stages at once.
		/// </summary>
		[GraphicsLimit(Gl.MAX_COMBINED_TEXTURE_IMAGE_UNITS)]
		[KhronosApi.Extension("GL_ARB_shader_program")]
		public int MaxCombinedTextureImageUnits;

		#endregion

		#region Default Uniform Block

		/// <summary>
		/// Maximum number of components for a vertex shader uniform variable.
		/// </summary>
		[GraphicsLimit(Gl.MAX_VERTEX_UNIFORM_COMPONENTS)]
		[KhronosApi.Extension("GL_ARB_vertex_shader")]
		public int MaxVertexUniformComponents;

		/// <summary>
		/// Maximum number of components for a geometry shader uniform variable.
		/// </summary>
		[GraphicsLimit(Gl.MAX_GEOMETRY_UNIFORM_COMPONENTS)]
		[KhronosApi.Extension("GL_ARB_geometry_shader4")]
		public int MaxGeometryUniformComponents;

		/// <summary>
		/// Maximum number of components for a fragment shader uniform variable.
		/// </summary>
		[GraphicsLimit(Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS)]
		[KhronosApi.Extension("GL_ARB_fragment_shader")]
		public int MaxFragmentUniformComponents;

		#endregion

		#region Uniform Blocks

		/// <summary>
		/// Maximum number of uniform blocks on a vertex shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_VERTEX_UNIFORM_BLOCKS)]
		[KhronosApi.Extension("GL_ARB_vertex_shader")]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int MaxVertexUniformBlocks;

		/// <summary>
		/// Maximum number of uniform blocks on a fragment shader.
		/// </summary>
		[GraphicsLimit(Gl.MAX_FRAGMENT_UNIFORM_BLOCKS)]
		[KhronosApi.Extension("GL_ARB_fragment_shader")]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int MaxFragmentUniformBlocks;

		/// <summary>
		/// Maximum number of combined uniform blocks.
		/// </summary>
		[GraphicsLimit(Gl.MAX_COMBINED_UNIFORM_BLOCKS)]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int MaxCombinedUniformBlocks;

		/// <summary>
		/// Maximum size for an uniform block.
		/// </summary>
		[GraphicsLimit(Gl.MAX_UNIFORM_BLOCK_SIZE)]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int MaxUniformBlockSize;

		/// <summary>
		/// Maximum number of indexed bindings for an uniform buffer.
		/// </summary>
		[GraphicsLimit(Gl.MAX_UNIFORM_BUFFER_BINDINGS)]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int MaxUniformBufferBindings;

		/// <summary>
		/// The required offset alignment for binding an uniform buffer with an offset.
		/// </summary>
		[GraphicsLimit(Gl.UNIFORM_BUFFER_OFFSET_ALIGNMENT)]
		[KhronosApi.Extension("GL_ARB_uniform_buffer_object")]
		public int UniformBufferOffsetAlignment;

		#endregion
	}
}
