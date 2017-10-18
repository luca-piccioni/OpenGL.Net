
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#pragma warning disable 169

namespace OpenVX
{
	/*! \brief Matrix Multiply Parameters 
	 *
	 * transpose_input1/input2/input3 : if True the matrix is transposed before the operation, otherwise the matrix is used as is. \n
	 * \ingroup group_vision_function_tensor_matrix_multiply
	 */			
	public struct MatrixMulParams
	{
		/*! \brief if True the matrix is transposed before the operation, otherwise the matrix is used as is*/
		bool  transpose_input1;
		/*! \brief if True the matrix is transposed before the operation, otherwise the matrix is used as is*/
		bool  transpose_input2;
		/*! \brief if True the matrix is transposed before the operation, otherwise the matrix is used as is*/
		bool  transpose_input3;
	}
}
