using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultipleTimer.Common;
using MultipleTimer.Models;

namespace MultipleTimer
{
	public partial class FormMain : Form
	{
		/// <summary>
		/// 表示しているタイマー数
		/// </summary>
		private int viewTimerNum = 0;

		public FormMain()
		{
			InitializeComponent();
		}

		private void 時間パターン設定TToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var formConf = new FormConfiguration();
			formConf.ShowDialog(this);
		}

		private void タイマーを追加TToolStripMenuItem_Click(object sender, EventArgs e)
		{
			viewTimerNum++;

			var readTimerFile = new ReadTimerDataFile();
			var timerKind = readTimerFile.getTimerDataFile();

			var timerfile = timerKind[0];

			var timeData = new TimerDataRead(timerfile.filepath);

			var timer = new MyControl.Timer(timeData.timerDataList.timers);
			timer.Name = "timer" + viewTimerNum.ToString();
			timer.Top = viewTimerNum * 30;
			timer.Left = 10;

			this.Controls.Add(timer);
		}
	}
}
