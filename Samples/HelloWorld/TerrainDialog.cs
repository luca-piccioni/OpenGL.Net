using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloNewton
{
	public partial class TerrainDialog : Form
	{
		public TerrainDialog()
		{
			InitializeComponent();
		}

		private void BtnUsgsDownload_Click(object sender, EventArgs e)
		{
			string wd = Directory.GetCurrentDirectory();
			string dataPath = Path.Combine(wd, @"..\..\..\Data");

			int lat = (int)NumLat.Value;
			int lon = (int)NumLon.Value;
			int w = (int)NumSizeX.Value;
			int h = (int)NumSizeY.Value;

			ProgUsgsDownload.Value = 0;
			ProgUsgsDownload.Minimum = 0;
			ProgUsgsDownload.Maximum = w * h;

			for (int x = lat; x < lat + w; x++) {
				for (int y = lon; y < lon + h; y++) {
					ProcessStartInfo wgetStartInfo = new ProcessStartInfo(Path.Combine(dataPath, "wget.exe"));
					const string UsgsEurasiaUrl = "http://dds.cr.usgs.gov/srtm/version2_1/SRTM3/Eurasia";
					string srtmUrl = String.Format("N{0:D2}E{1:D3}.hgt.zip", x, y);

					if (File.Exists(Path.Combine(dataPath, srtmUrl)))
						continue;

					wgetStartInfo.Arguments = String.Format("{0}/{1}", UsgsEurasiaUrl, srtmUrl);
					wgetStartInfo.RedirectStandardOutput = true;
					wgetStartInfo.RedirectStandardError = true;
					wgetStartInfo.UseShellExecute = false;
					wgetStartInfo.WorkingDirectory = dataPath;

					using (Process wgetProcess = new Process()) {
						wgetProcess.StartInfo = wgetStartInfo;
						wgetProcess.OutputDataReceived += WgetProcess_OutputDataReceived;
						wgetProcess.ErrorDataReceived += WgetProcess_ErrorDataReceived;
						
						wgetProcess.Start();

						//wgetProcess.BeginOutputReadLine();
						//wgetProcess.BeginErrorReadLine();

						wgetProcess.WaitForExit();

						//while (!wgetProcess.WaitForExit(100))
						//	Application.DoEvents();
					}

					ProgUsgsDownload.Value++;
				}
			} 
		}

		private void WgetProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			Invoke(new Action(delegate () { TxtUsgsLog.AppendText(e.Data); }));
		}

		private void WgetProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			Invoke(new Action(delegate () { TxtUsgsLog.AppendText(e.Data); }));
		}
	}
}
