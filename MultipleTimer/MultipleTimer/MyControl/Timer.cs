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

		/// <summary>
		/// ボタンの状態
		/// </summary>
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

		/// <summary>
		/// セットした時間
		/// </summary>
		private string setTimerTime = "";

		public Timer(List<TimerData> td)
		{
			InitializeComponent();

			timerData = td;

			foreach (var item in timerData)
			{
				comboBoxTimer.Items.Add(item.time);
			}
		}

		/// <summary>
		/// タイマーを動かす
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonStart_Click(object sender, EventArgs e)
		{
			switch (buttonStartStatus_)
			{
				case buttonStartStatus.start:
					{
						buttonStartStatus_ = buttonStartStatus.stop;

						comboBoxTimer.Enabled = false;

						timer1.Enabled = false;
						buttonStart.Text = "■";

						var nowUT = DateTime.Now.getUnixTime();
						var setUT = comboBoxTimer.Text.ToUnixTime();

						endUT = nowUT + setUT;

						timer1.Enabled = true;

						break;
					}
				case buttonStartStatus.stop:
					{
						comboBoxTimer.Enabled = true;

						buttonStartStatus_ = buttonStartStatus.start;
						timer1.Enabled = false;
						buttonStart.Text = "▶";

						break;
					}
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
				comboBoxTimer.Text = "  終了  ";

				buttonStart.Enabled = false;

				comboBoxTimer.Enabled = true;
			}
			else
			{
				comboBoxTimer.Text = resultTime.ToTextTime();
			}
		}
		
		/// <summary>
		/// リスタートボタン
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonRestart_Click(object sender, EventArgs e)
		{
			comboBoxTimer.Text = setTimerTime;

			buttonStart.Enabled = true;
			buttonStartStatus_ = buttonStartStatus.start;
			buttonStart_Click(sender, e);
		}

		private void comboBoxTimer_SelectedIndexChanged(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			buttonStart.Enabled = true;
			buttonStart.Text = "▶";
			buttonStartStatus_ = buttonStartStatus.start;
		}
	}
}
