using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL
{
	class Win32Exception : InvalidOperationException
	{
		public Win32Exception(int errorCode)
		{

		}

		public Win32Exception(int errorCode, string errorMessage)
		{

		}
	}
}
