using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleContext
{
	public partial class SharingForm : Form
	{
		public SharingForm()
		{
			InitializeComponent();
		}

		private void glControl1_Click(object sender, EventArgs e)
		{
			using (SharingDialog sharingDialog = new SharingDialog()) {
				// Run modal dialog
				sharingDialog.ShowDialog(this);
			}
		}
	}
}
