
using System;

using OpenGL;

namespace HelloTriangle.OpenWF
{
	public class Program
	{
		static void Main()
		{
			try {
				string envDebug = Environment.GetEnvironmentVariable("GL_DEBUG");

				if (envDebug == "YES") {
					KhronosApi.RegisterApplicationLogDelegate(delegate (string format, object[] args) {
						Console.WriteLine(format, args);
					});
				}

				
			} catch (Exception exception) {
				Console.WriteLine(exception.ToString());
			}
		}
	}
}
