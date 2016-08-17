using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultipleTimer.Models;
using LukeLibrary;

namespace MultipleTimer.MyControl
{
	public partial class Timer : UserControl
	{
		/// <summary>
		/// タイマー設定可能時刻
		/// </summary>
		private List<TimerData> timerData = new List<TimerData>();

		private enum buttonStartStatus
		{
			start,
			stop
		}

		/// <summary>
		/// スタートボタンの状態
		/// </summary>
		private buttonStartStatus buttonStartStatus_ = buttonStartStatus.start;

		/// <summary>
		/// 終了時刻の通算秒
		/// </summary>
		private int endUT = 0;

		public Timer(List<TimerData> td)
		{
			InitializeComponent();

			timerData = td;

			// TODO : 仮決め打ち
			labelTimer.Text = timerData[0].time;
		}

		/// <summary>
		/// タイマーを動かす
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (buttonStartStatus_ == buttonStartStatus.start)
			{
				buttonStartStatus_ = buttonStartStatus.stop;

				timer1.Enabled = false;
				buttonStart.Text = "■";

				var nowUT = DateTime.Now.getUnixTime();
				var setUT = labelTimer.Text.ToUnixTime();

				endUT = nowUT + setUT;

				timer1.Enabled = true;
			}
			else
			{
				buttonStartStatus_ = buttonStartStatus.start;
				timer1.Enabled = false;
				buttonStart.Text = "▶";
			}
		}

		/// <summary>
		/// タイマー動作
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			var nowUT = DateTime.Now.getUnixTime();

			// 残り時間
			var resultTime = endUT - nowUT;

			if (resultTime < 1)
			{
				timer1.Enabled = false;
				labelTimer.Text = "  終了  ";

				buttonStart.Enabled = false;
			}
			else
			{
				labelTimer.Text = resultTime.ToTextTime();
			}
		}
	}
}
