using System;
using System.Drawing;
using System.Drawing.Imaging;

using OpenGL;

namespace WindowlessTriangle
{
	class Program
	{
		public static void Main(string[] args)
		{
			string envDebug = Environment.GetEnvironmentVariable("DEBUG");
			if (envDebug == "GL")
			{
				KhronosApi.Log += delegate (object sender, KhronosLogEventArgs e)
				{
					Console.WriteLine(e.ToString());
				};
				KhronosApi.LogEnabled = true;
			}


		}
	}
}
