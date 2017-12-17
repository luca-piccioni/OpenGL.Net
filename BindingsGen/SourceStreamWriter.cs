
// Copyright (C) 2015 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BindingsGen
{
	/// <summary>
	/// A <see cref="StreamWriter"/> specilized for writing source code.
	/// </summary>
	public class SourceStreamWriter : StreamWriter
	{
		#region Constructors

		public SourceStreamWriter(Stream stream)
			: base(stream)
		{
			
		}
		
		public SourceStreamWriter(string path)
			: base(path)
		{
			
		}
		
		public SourceStreamWriter(Stream stream, Encoding encoding)
			: base(stream, encoding)
		{
			
		}
		
		public SourceStreamWriter(string path, bool append)
			: base(path, append)
		{
			
		}
		

		public SourceStreamWriter(Stream stream, Encoding encoding, int bufferSize)
			: base(stream, encoding, bufferSize)
		{
			
		}
		

		public SourceStreamWriter(string path, bool append, Encoding encoding)
			: base(path, append, encoding)
		{
			
		}

		#endregion

		#region Indentation

		/// <summary>
		/// Increment the identation.
		/// </summary>
		public void Indent()
		{
			_Identation = _Identation + '\t';
		}

		/// <summary>
		/// Decrement the identation.
		/// </summary>
		public void Unindent()
		{
			if (_Identation.Length == 0)
				return;
			_Identation = _Identation.Substring(1);
		}

		/// <summary>
		/// Writes the current identation.
		/// </summary>
		public void WriteIdentation()
		{
			Write(_Identation);
		}

		/// <summary>
		/// The string representing the current identation.
		/// </summary>
		private string _Identation = string.Empty;

		#endregion

		#region Multiline

		public void WriteLine(string format, IEnumerable<string> lines)
		{
			foreach (string line in lines)
				WriteLine(format, line);
		}

		#endregion

		#region StreamWriter Overrides

		public override void WriteLine(string value)
		{
			if (Program.DummyStream)
				return;

			if (!value.StartsWith("\t"))
				base.WriteLine(_Identation + value);
			else {
				base.WriteLine(value);
			}
		}

		public override void WriteLine(string format, object arg0)
		{
			if (Program.DummyStream)
				return;
			base.WriteLine(_Identation + format, arg0);
		}

		public override void WriteLine(string format, object arg0, object arg1)
		{
			if (Program.DummyStream)
				return;
			base.WriteLine(_Identation + format, arg0, arg1);
		}

		public override void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			if (Program.DummyStream)
				return;
			base.WriteLine(_Identation + format, arg0, arg1, arg2);
		}
		
		public override void WriteLine(string format, params object[] arg)
		{
			if (Program.DummyStream)
				return;
			base.WriteLine(_Identation + format, arg);
		}

		#endregion
	}
}
