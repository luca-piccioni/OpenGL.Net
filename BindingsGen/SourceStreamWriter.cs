
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

using System;
using System.IO;
using System.Text;

namespace BindingsGen
{
	class SourceStreamWriter : StreamWriter
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

		public void Indent()
		{
			mIdentation = mIdentation + '\t';
		}

		public void Unindent()
		{
			if (mIdentation.Length == 0)
				return;
			mIdentation = mIdentation.Substring(1);
		}

		public void WriteIdentation()
		{
			base.Write(mIdentation);
		}

		/// <summary>
		/// 
		/// </summary>
		private string mIdentation = string.Empty;

		#endregion

		#region StreamWriter Overrides

		public override void WriteLine(string value)
		{
			if (!value.StartsWith("\t"))
				base.WriteLine(mIdentation + value);
			else {
				base.WriteLine(value);
			}
		}

		public override void WriteLine(string format, object arg0)
		{
			base.WriteLine(mIdentation + format, arg0);
		}

		public override void WriteLine(string format, object arg0, object arg1)
		{
			base.WriteLine(mIdentation + format, arg0, arg1);
		}

		public override void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			base.WriteLine(mIdentation + format, arg0, arg1, arg2);
		}
		
		public override void WriteLine(string format, params object[] arg)
		{
			base.WriteLine(mIdentation + format, arg);
		}

		#endregion
	}
}
