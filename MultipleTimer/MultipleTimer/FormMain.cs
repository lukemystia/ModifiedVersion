using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTimer
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void 時間パターン設定TToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var formConf = new FormConfiguration();
			formConf.ShowDialog(this);
		}
	}
}
