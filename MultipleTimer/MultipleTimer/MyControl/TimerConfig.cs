using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MultipleTimer.Models;

namespace MultipleTimer.MyControl
{
	public partial class TimerConfig : UserControl
	{
		private List<TimerDataFileView> timerKind;


		public TimerConfig()
		{
			InitializeComponent();
		}

		/// <summary>
		/// ロードイベント
		/// タイマーデータファイルを読み込みコンボボックスへ追加
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TimerConfig_Load(object sender, EventArgs e)
		{
			getTimerDataFile();

			foreach (var item in timerKind)
			{
				comboBoxTimerKind.Items.Add(item.filename);
			}
			comboBoxTimerKind.Items.Add("(新規追加)");

			comboBoxTimerKind.SelectedIndex = 0;
		}

		/// <summary>
		/// ファイル取得
		/// </summary>
		/// <returns></returns>
		private void getTimerDataFile()
		{
			timerKind = new List<TimerDataFileView>();

			var files = Directory.EnumerateFiles(@"timerData", "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var temp = new TimerDataFileView();
				temp.setTimerDataFileView(file);

				timerKind.Add(temp);
			}
		}

		/// <summary>
		/// コンボボックスの選択しているものが変わった時
		/// 表示項目を選択しているタイマー情報にする
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBoxTimerKind_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridViewTime.Rows.Clear();

			// 新規作成かどうか
			if (comboBoxTimerKind.SelectedIndex == timerKind.Count)
			{
				MessageBox.Show("新規作成!");
			}
			else
			{
				var timerfile = timerKind[comboBoxTimerKind.SelectedIndex];

				var timeData = new TimerDataRead(timerfile.filepath);

				foreach (var item in timeData.timerDataList.timers)
				{
					dataGridViewTime.Rows.Add(item.time);
				}
				dataGridViewTime.Font = new Font(dataGridViewTime.Font.Name, 12);






			}
		}
	}
}
