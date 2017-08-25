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
			// Trying to get the value of an undefined symbol will throw an exception
			Assert.Throws<InvalidOperationException>(delegate() { parser.GetSymbol("SYMBOL"); });

			// Symbol can be defined without associating a value
			parser.Define("SYMBOL", null);
			Assert.IsTrue(parser.IsDefined("SYMBOL"));
			// Trying to get the value of an null symbol will throw an exception
			Assert.Throws<InvalidOperationException>(delegate() { parser.GetSymbol("SYMBOL"); });

			// If symbol is already defined, do not throw any exception
			Assert.DoesNotThrow(delegate() { parser.Define("SYMBOL", null); });
			Assert.IsTrue(parser.IsDefined("SYMBOL"));

			Assert.DoesNotThrow(delegate() { parser.Define("SYMBOL", "115"); });
			Assert.IsTrue(parser.IsDefined("SYMBOL"));
			Assert.DoesNotThrow(delegate() { parser.GetSymbol("SYMBOL"); });
			Assert.AreEqual("115", parser.GetSymbol("SYMBOL"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_SymbolDefinition()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();
			
			// Symbols can be undefined
			Assert.Throws<InvalidOperationException>(delegate() { parser.EvaluateExpression("SYMBOL"); });
			Assert.IsFalse(parser.EvaluateExpression("defined(SYMBOL)"));
			Assert.IsFalse(parser.EvaluateExpression("defined SYMBOL"));
			Assert.IsFalse(parser.EvaluateExpression("defined ( SYMBOL )"));

			// Symbol can be defined without associating a value
			parser.Define("SYMBOL", null);

			Assert.Throws<InvalidOperationException>(delegate() { parser.EvaluateExpression("SYMBOL"); });
			Assert.Throws<InvalidOperationException>(delegate() { parser.EvaluateExpression("(SYMBOL)"); });
			Assert.Throws<InvalidOperationException>(delegate() { parser.EvaluateExpression("( SYMBOL )"); });
			Assert.IsTrue(parser.EvaluateExpression("defined(SYMBOL)"));
			Assert.IsTrue(parser.EvaluateExpression("defined SYMBOL"));
			Assert.IsTrue(parser.EvaluateExpression("defined ( SYMBOL )"));

			// Symbol can be re-defined
			parser.Define("SYMBOL", "1");

			Assert.IsTrue(parser.EvaluateExpression("SYMBOL"));
			Assert.IsTrue(parser.EvaluateExpression("(SYMBOL)"));
			Assert.IsTrue(parser.EvaluateExpression("( SYMBOL )"));
			Assert.IsTrue(parser.EvaluateExpression("defined(SYMBOL)"));
			Assert.IsTrue(parser.EvaluateExpression("defined SYMBOL"));
			Assert.IsTrue(parser.EvaluateExpression("defined ( SYMBOL )"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_Number()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();

			Assert.IsTrue(parser.EvaluateExpression("1"));
			Assert.IsTrue(parser.EvaluateExpression("(1)"));

			Assert.IsTrue(parser.EvaluateExpression("2"));
			Assert.IsTrue(parser.EvaluateExpression("(2)"));

			Assert.IsFalse(parser.EvaluateExpression("0"));
			Assert.IsFalse(parser.EvaluateExpression("(0)"));
			Assert.IsFalse(parser.EvaluateExpression("( 0 )"));
		}

		[Test(Description = "Test EvaluateExpression method")]
		public void TestEvaluateExpression_Relational()
		{
			ShaderPreprocessorParser parser = new ShaderPreprocessorParser();

			Assert.IsFalse(parser.EvaluateExpression("0 > 1"));
			Assert.IsTrue (parser.EvaluateExpression("1 > 0"));
		}
	}
}
