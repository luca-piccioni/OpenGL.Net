using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloTriangle.Hal
{
	static class Program
	{
		/// <summary>
		/// Punto di ingresso principale dell'applicazione.
		/// </summary>
		[STAThread]
		static void Main()
		{
			OpenGL.Gl.RegisterApplicationLogDelegate(delegate(string format, object[] args) {
				Console.WriteLine(format, args);
			});
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SampleForm());
		}
	}
}
