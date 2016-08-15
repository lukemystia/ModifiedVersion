using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTimer.Models
{
	public class TimerDataFileView
	{
		/// <summary>
		/// ファイル名
		/// </summary>
		public string filename { private set; get; }

		/// <summary>
		/// ファイルパス
		/// </summary>
		public string filepath { private set; get; }

		/// <summary>
		/// setter
		/// </summary>
		/// <param name="filepath"></param>
		public void setTimerDataFileView(string filepath)
		{
			this.filepath = filepath;

			var splitpath = filepath.Split('\\');
			this.filename = (splitpath[splitpath.Length - 1]).Split('.')[0];
		}

	}
}
