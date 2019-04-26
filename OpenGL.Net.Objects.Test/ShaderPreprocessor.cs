
// Copyright (C) 2019 Luca Piccioni
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

using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test ShaderPreprocessor class.
	/// </summary>
	[TestFixture]
	class ShaderPreprocessorTest
	{
		[Test(Description = "Test #if/#ifdef/#ifndef/#elif/#else/#endif statements"), Category("Objects")]
		[TestCaseSource("TestStatement_Conditional_Source")]
		public void TestStatement_Conditional(string[] sourceLines)
		{
			using (ShaderIncludeLibrary shaderIncludeLibrary = new ShaderIncludeLibrary()) {
				List<string> ppSource = ShaderPreprocessor.Process(sourceLines, new ShaderCompilerContext(), shaderIncludeLibrary, ShaderPreprocessor.Stage.All);

				Assert.Greater(ppSource.Count, 0);
				foreach (string sourceLine in ppSource)
					Assert.AreNotEqual(sourceLine.Trim(' ', '\t', '\n'), "Fail");
			}
		}

		private static object[] TestStatement_Conditional_Source
		{
			get
			{
				List<string[]> testCaseSource = new List<string[]>();

				testCaseSource.Add(new [] {
					"#define TRUE 1\n",
					"#define FALSE 0\n",
					"#if TRUE\n",
					"	Success\n",
					"#endif\n",
				});

				testCaseSource.Add(new[] {
					"#define TRUE 1\n",
					"#define FALSE 0\n",
					"#if FALSE\n",
					"	Fail\n",
					"#endif\n",
				});

				testCaseSource.Add(new[] {
					"#define TRUE 1\n",
					"#define FALSE 0\n",
					"#if TRUE\n",
					"	Success\n",
					"#else\n",
					"	Fail\n",
					"#endif\n",
				});

				testCaseSource.Add(new[] {
					"#define TRUE 1\n",
					"#define FALSE 0\n",
					"#if TRUE\n",
					"	Success\n",
					"#elif TRUE\n",
					"	Fail\n",
					"#else\n",
					"	Fail\n",
					"#endif\n",
				});

				testCaseSource.Add(new[] {
					"#define TRUE 1\n",
					"#define FALSE 0\n",
					"#if FALSE\n",
					"	Fail\n",
					"#elif TRUE\n",
					"	Success\n",
					"#else\n",
					"	Fail\n",
					"#endif\n",
				});

				return testCaseSource.ToArray();
			}
		}
	}
}
