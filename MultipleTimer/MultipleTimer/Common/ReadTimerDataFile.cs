using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultipleTimer.Models;

namespace MultipleTimer.Common
{
	/// <summary>
	/// タイマーデータファイル読み込み汎用クラス
	/// </summary>
	public class ReadTimerDataFile
	{
		/// <summary>
		/// ファイル取得
		/// </summary>
		/// <returns></returns>
		public List<TimerDataFileView> getTimerDataFile()
		{
			var timerKind = new List<TimerDataFileView>();

			var files = Directory.EnumerateFiles(@"timerData", "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var temp = new TimerDataFileView();
				temp.setTimerDataFileView(file);

				timerKind.Add(temp);
			}

			return timerKind;
		}
	}
}
