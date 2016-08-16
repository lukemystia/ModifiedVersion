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

namespace MultipleTimer.MyControl
{
	public partial class Timer : UserControl
	{
		/// <summary>
		/// タイマー設定可能時刻
		/// </summary>
		private List<TimerData> timerData = new List<TimerData>();

		/// <summary>
		/// 終了時刻の通算秒
		/// </summary>
		private double endUT = 0;

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
			timer1.Enabled = false;

			var nowUT = getUnixTime(DateTime.Now);
			var setUT = changeTextTimeToUnixTime(labelTimer.Text);

			endUT = nowUT + setUT;

			timer1.Enabled = true;
		}

		/// <summary>
		/// 指定時刻の通算秒取得
		/// </summary>
		/// <returns></returns>
		private double getUnixTime(DateTime dt)
		{
			var startTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);

			var diff = dt - startTime;

			return diff.TotalSeconds;
		}

		/// <summary>
		/// 通算秒を日付データに変換する
		/// </summary>
		/// <returns></returns>
		private DateTime changeUnixTimeToDatetime(double ut)
		{
			return new DateTime(1970, 1, 1).AddSeconds(ut);
		}

		/// <summary>
		/// 文字列の時間を通算秒に変える
		/// </summary>
		/// <returns></returns>
		private double changeTextTimeToUnixTime(string time)
		{
			time = time.Replace(":", "");

			return int.Parse(time.Substring(0, 2)) * 60*60 + int.Parse(time.Substring(2, 2)) * 60 + int.Parse(time.Substring(4, 2));
		}

		/// <summary>
		/// 通算秒を文字列の時間に変える
		/// </summary>
		/// <param name="time"></param>
		/// <returns></returns>
		private string changeUnixTimeToTextTime(int time)
		{
			var hour = time / (60 * 60);
			time -= hour * 60 * 60;
			var min = time / 60;
			time -= min * 60;
			var sec = time;

			var retstr = new StringBuilder();
			retstr.Append(hour.ToString().PadLeft(2, '0'));
			retstr.Append(":");
			retstr.Append(min.ToString().PadLeft(2, '0'));
			retstr.Append(":");
			retstr.Append(sec.ToString().PadLeft(2, '0'));

			return retstr.ToString();
		}

		/// <summary>
		/// タイマー動作
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			var nowUT = getUnixTime(DateTime.Now);

			// 残り時間
			var resultTime = endUT - nowUT;

			if (resultTime < 1)
			{
				timer1.Enabled = false;
				labelTimer.Text = "  終了  ";
			}
			else
			{
				labelTimer.Text = changeUnixTimeToTextTime((int)resultTime);
			}
		}
	}
}
