using System;
using BindingsGen.GLSpecs;

namespace BindingsGen
{
	public class RegistryContext
	{
		public RegistryContext(string @class)
		{
			Class = @class;
			ExtensionsDictionary = SpecWordsDictionary.Load("BindingsGen.GLSpecs.ExtWords.xml");
			WordsDictionary = SpecWordsDictionary.Load(String.Format("BindingsGen.GLSpecs.{0}Words.xml", @class));
		}

		public readonly string Class;

		/// <summary>
		/// 
		/// </summary>
		public readonly SpecWordsDictionary ExtensionsDictionary;

		/// <summary>
		/// 
		/// </summary>
		public readonly SpecWordsDictionary WordsDictionary;
	}
}