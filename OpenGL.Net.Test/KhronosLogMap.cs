
// Copyright (C) 2018 Luca Piccioni
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

using NUnit.Framework;

using Khronos;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class KhronosLogMapTest
	{
		[Test]
		public void KhronosLogMap_Constructor()
		{
			KhronosLogMap m = null;

			Assert.DoesNotThrow(() => m = new KhronosLogMap());
			Assert.IsNotNull(m.Commands);
			CollectionAssert.IsEmpty(m.Commands);
		}

		[Test]
		public void KhronosLogMap_Commands()
		{
			KhronosLogMap m = new KhronosLogMap();

			Assert.IsNotNull(m.Commands);
			CollectionAssert.IsEmpty(m.Commands);

			m.Commands = new[] {
				new KhronosLogMap.Command {
					Name = "command",
					Params = new[] {
						new KhronosLogMap.CommandParam {Name = "arg0", Flags = KhronosLogCommandParameterFlags.Enum},
						new KhronosLogMap.CommandParam {Name = "arg1", Flags = KhronosLogCommandParameterFlags.None},
						new KhronosLogMap.CommandParam {Name = "arg2", /* Flags defaults to None */}
					}
				}
			};

			Assert.IsNotNull(m.Commands);
			Assert.AreEqual(1, m.Commands.Length);

			Assert.DoesNotThrow(() => m.Commands = null);
			Assert.IsNotNull(m.Commands);
			CollectionAssert.IsEmpty(m.Commands);
		}

#if NETFRAMEWORK

		[Test]
		public void KhronosLogMap_Load()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosLogMap.Load(null));
		}

		[Test]
		public void KhronosLogMap_Save()
		{
			KhronosLogMap m = new KhronosLogMap {
				Commands = new[] {
					new KhronosLogMap.Command {
						Name = "command",
						Params = new[] {
							new KhronosLogMap.CommandParam {Name = "arg0", Flags = KhronosLogCommandParameterFlags.Enum},
							new KhronosLogMap.CommandParam {Name = "arg1", Flags = KhronosLogCommandParameterFlags.None},
							new KhronosLogMap.CommandParam {Name = "arg2", /* Flags defaults to None */}
						}
					}
				}
			};

			Assert.DoesNotThrow(() => KhronosLogMap.Save("KhronosLogMap_Save.xml", m));
		}

#endif

		[Test]
		public void KhronosLogMap_GetCommandParameterFlag()
		{
			KhronosLogMap m = new KhronosLogMap();

			Assert.Throws<ArgumentNullException>(() => m.GetCommandParameterFlag(null, 0));
			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetCommandParameterFlag("command", -1));

			m.Commands = new[] {
				new KhronosLogMap.Command {
					Name = "command",
					Params = new[] {
						new KhronosLogMap.CommandParam { Name = "arg0", Flags = KhronosLogCommandParameterFlags.Enum },
						new KhronosLogMap.CommandParam { Name = "arg1", Flags = KhronosLogCommandParameterFlags.None },
						new KhronosLogMap.CommandParam { Name = "arg2", /* Flags defaults to None */ }
					}
				}
			};

			Assert.AreEqual(KhronosLogCommandParameterFlags.Enum, m.GetCommandParameterFlag("command", 0));
			Assert.AreEqual(KhronosLogCommandParameterFlags.None, m.GetCommandParameterFlag("command", 1));
			Assert.AreEqual(KhronosLogCommandParameterFlags.None, m.GetCommandParameterFlag("command", 2));
			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetCommandParameterFlag("command", 3));

			Assert.AreEqual(KhronosLogCommandParameterFlags.None, m.GetCommandParameterFlag("command2", 0));
			Assert.AreEqual(KhronosLogCommandParameterFlags.None, m.GetCommandParameterFlag("command2", 1));
			// Unknown commands cannot check parameter index
			Assert.DoesNotThrow(() => m.GetCommandParameterFlag("command2", 1024));
			Assert.AreEqual(KhronosLogCommandParameterFlags.None, m.GetCommandParameterFlag("command2", 1024));
		}
	}
}
