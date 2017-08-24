using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test ShaderPreprocessorParser class.
	/// </summary>
	[TestFixture(Category = @"Objects\ShaderPreprocessorParser")]
	class ShaderPreprocessorParserTest
	{
		[Test(Description = "Test Define/IsDefined methods")]
		public void TestSymbolDefinition()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();
			
			// Symbols can be undefined
			Assert.IsFalse(parser.IsDefined("SYMBOL"));
			Assert.IsFalse(parser.IsDefined("defined(SYMBOL)"));

			// Symbol can be defined without associating a value
			parser.Define("SYMBOL", null);

			Assert.IsTrue(parser.IsDefined("SYMBOL"));

			// If symbol is already defined, do not throw any exception
			Assert.DoesNotThrow(delegate() { parser.Define("SYMBOL", null); });
			Assert.DoesNotThrow(delegate() { parser.Define("SYMBOL", "115"); });
			Assert.IsTrue(parser.IsDefined("SYMBOL"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_SymbolDefinition()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();
			
			// Symbols can be undefined
			Assert.IsFalse(parser.EvaluateExpression("SYMBOL"));
			Assert.IsFalse(parser.EvaluateExpression("defined(SYMBOL)"));

			// Symbol can be defined without associating a value
			parser.Define("SYMBOL", null);

			Assert.IsTrue(parser.EvaluateExpression("SYMBOL"));
			Assert.IsTrue(parser.EvaluateExpression("(SYMBOL)"));
			Assert.IsTrue(parser.EvaluateExpression("( SYMBOL )"));
			Assert.IsTrue(parser.EvaluateExpression("defined(SYMBOL)"));
			Assert.IsTrue(parser.EvaluateExpression("defined ( SYMBOL )"));

			parser.Define("SYMBOL", "115");

			Assert.IsTrue(parser.EvaluateExpression("SYMBOL == 115"));
			Assert.IsTrue(parser.EvaluateExpression("(SYMBOL == 115)"));
			Assert.IsTrue(parser.EvaluateExpression("( SYMBOL == 115 )"));
			Assert.IsFalse(parser.EvaluateExpression("SYMBOL != 115"));
			Assert.IsFalse(parser.EvaluateExpression("(SYMBOL != 115)"));
			Assert.IsFalse(parser.EvaluateExpression("( SYMBOL != 115 )"));
			Assert.IsTrue(parser.EvaluateExpression("SYMBOL >= 115"));
			Assert.IsTrue(parser.EvaluateExpression("(SYMBOL >= 115)"));
			Assert.IsTrue(parser.EvaluateExpression("( SYMBOL >= 115 )"));
			Assert.IsTrue(parser.EvaluateExpression("SYMBOL <= 115"));
			Assert.IsTrue(parser.EvaluateExpression("(SYMBOL <= 115)"));
			Assert.IsTrue(parser.EvaluateExpression("( SYMBOL <= 115 )"));
			Assert.IsFalse(parser.EvaluateExpression("SYMBOL < 115"));
			Assert.IsFalse(parser.EvaluateExpression("(SYMBOL < 115)"));
			Assert.IsFalse(parser.EvaluateExpression("( SYMBOL < 115 )"));
			Assert.IsFalse(parser.EvaluateExpression("SYMBOL > 115"));
			Assert.IsFalse(parser.EvaluateExpression("(SYMBOL > 115)"));
			Assert.IsFalse(parser.EvaluateExpression("( SYMBOL > 115 )"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_Number()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();

			Assert.IsTrue(parser.EvaluateExpression("1"));
			Assert.IsTrue(parser.EvaluateExpression("2"));
			Assert.IsFalse(parser.EvaluateExpression("0"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_Symbol()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();

			Assert.IsFalse(parser.EvaluateExpression("SYMBOL"));

			parser.Define("SYMBOL", "1");
			Assert.IsTrue(parser.EvaluateExpression("SYMBOL"));

			parser.Define("SYMBOL", "2");
			Assert.IsTrue(parser.EvaluateExpression("SYMBOL"));

			parser.Define("SYMBOL", "0");
			Assert.IsFalse(parser.EvaluateExpression("SYMBOL"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_Relational()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();

			Assert.IsFalse(parser.EvaluateExpression("0 > 1"));
			Assert.IsTrue (parser.EvaluateExpression("1 > 0"));

			parser.Define("__VERSION__", "150");
		}
	}
}
