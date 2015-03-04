
// Copyright (C) 2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PIXEL_PACK_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_PACK_BUFFER = 0x88EB;

		/// <summary>
		/// Value of GL_PIXEL_UNPACK_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_UNPACK_BUFFER = 0x88EC;

		/// <summary>
		/// Value of GL_PIXEL_PACK_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_PACK_BUFFER_BINDING = 0x88ED;

		/// <summary>
		/// Value of GL_PIXEL_UNPACK_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT2x3 = 0x8B65;

		/// <summary>
		/// Value of GL_FLOAT_MAT2x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT2x4 = 0x8B66;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT3x2 = 0x8B67;

		/// <summary>
		/// Value of GL_FLOAT_MAT3x4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT3x4 = 0x8B68;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT4x2 = 0x8B69;

		/// <summary>
		/// Value of GL_FLOAT_MAT4x3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int FLOAT_MAT4x3 = 0x8B6A;

		/// <summary>
		/// Value of GL_SRGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB = 0x8C40;

		/// <summary>
		/// Value of GL_SRGB8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB8 = 0x8C41;

		/// <summary>
		/// Value of GL_SRGB_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB_ALPHA = 0x8C42;

		/// <summary>
		/// Value of GL_SRGB8_ALPHA8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int SRGB8_ALPHA8 = 0x8C43;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int COMPRESSED_SRGB = 0x8C48;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		public const int COMPRESSED_SRGB_ALPHA = 0x8C49;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_SECONDARY_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_RASTER_SECONDARY_COLOR = 0x845F;

		/// <summary>
		/// Value of GL_SLUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE_ALPHA = 0x8C44;

		/// <summary>
		/// Value of GL_SLUMINANCE8_ALPHA8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE8_ALPHA8 = 0x8C45;

		/// <summary>
		/// Value of GL_SLUMINANCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE = 0x8C46;

		/// <summary>
		/// Value of GL_SLUMINANCE8 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SLUMINANCE8 = 0x8C47;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_SLUMINANCE = 0x8C4A;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix2x3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix2x3fv != null) {
						Delegates.pglUniformMatrix2x3fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix2x3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix2x3fvNV != null) {
						Delegates.pglUniformMatrix2x3fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix2x3fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix2x3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix3x2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix3x2fv != null) {
						Delegates.pglUniformMatrix3x2fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix3x2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix3x2fvNV != null) {
						Delegates.pglUniformMatrix3x2fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix3x2fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix3x2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix2x4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix2x4fv != null) {
						Delegates.pglUniformMatrix2x4fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix2x4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix2x4fvNV != null) {
						Delegates.pglUniformMatrix2x4fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix2x4fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix2x4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix4x2(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix4x2fv != null) {
						Delegates.pglUniformMatrix4x2fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix4x2fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix4x2fvNV != null) {
						Delegates.pglUniformMatrix4x2fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix4x2fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix4x2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix3x4(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix3x4fv != null) {
						Delegates.pglUniformMatrix3x4fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix3x4fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix3x4fvNV != null) {
						Delegates.pglUniformMatrix3x4fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix3x4fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix3x4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// be modified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on 
		/// the program object that was made part of current state by calling glUseProgram.
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// the values passed as arguments. The number specified in the command should match the number of components in the data 
		/// type of the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.). The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values 
		/// are being passed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match 
		/// the data type of the specified uniform variable. The i variants of this function should be used to provide values for 
		/// uniform variables defined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be 
		/// used to provide values for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f 
		/// variants should be used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. 
		/// Either the i, ui or f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or 
		/// arrays of these. The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true 
		/// otherwise.
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully. They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurs on the program object, when they are once again initialized to 0.
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// These commands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable 
		/// array. A count of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can 
		/// be used to modify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a 
		/// uniform variable array, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger 
		/// than the size of the uniform variable array, values for all array elements beyond the end of the array will be ignored. 
		/// The number specified in the name of the command indicates the number of components for each element in value, and it 
		/// should match the number of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 
		/// 2 for vec2, ivec2, bvec2, etc.). The data type specified in the name of the command must match the data type for the 
		/// specified uniform variable as described previously for glUniform{1|2|3|4}{f|i|ui}.
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command (e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elements of the uniform variable array to be modified is specified by count
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbers in the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e., 4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e., 16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of 
		/// columns and the second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns 
		/// and 4 rows (i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transpose is GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// of matrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater 
		/// than 1 can be used to modify an array of matrices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object.
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicated by the glUniform command.
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   array of these.
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   is not equal to -1.
		/// - GL_INVALID_VALUE is generated if count is less than 0.
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable
		/// - glGetUniform with the handle of a program object and the location of a uniform variable
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_2_1")]
		public static void UniformMatrix4x3(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglUniformMatrix4x3fv != null) {
						Delegates.pglUniformMatrix4x3fv(location, count, transpose, p_value);
						CallLog("glUniformMatrix4x3fv({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else if (Delegates.pglUniformMatrix4x3fvNV != null) {
						Delegates.pglUniformMatrix4x3fvNV(location, count, transpose, p_value);
						CallLog("glUniformMatrix4x3fvNV({0}, {1}, {2}, {3})", location, count, transpose, value);
					} else
						throw new NotImplementedException("glUniformMatrix4x3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

	}

}
