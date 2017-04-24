
using System;

using OpenGL;

namespace HelloTriangle.OpenWF
{
	public class Program
	{
		static void Main()
		{
			try {
				string envDebug = Environment.GetEnvironmentVariable("DEBUG");
				if (envDebug == "GL") {
					KhronosApi.Log += delegate(object sender, KhronosLogEventArgs e) {
						Console.WriteLine(e.ToString());
					};
					KhronosApi.LogEnabled = true;
				}

				
			} catch (Exception exception) {
				Console.WriteLine(exception.ToString());
			}
		}
	}
}
