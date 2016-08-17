using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MultipleTimer.Models
{
	/// <summary>
	/// タイマーデータリストモデルクラス
	/// </summary>
	[XmlRoot("timers")]
	public class TimerDataList
	{
		[XmlElement("timer")]
		public List<TimerData> timers { set; get; }
	}

	/// <summary>
	/// タイマーデータモデルクラス
	/// </summary>
	public class TimerData
	{
		/// <summary>
		/// ID
		/// </summary>
		[XmlAttribute("id")]
		public string id { set; get; }

		/// <summary>
		/// タイマーの項目名
		/// </summary>
		[XmlElement("name")]
		public string name { set; get; }

		/// <summary>
		/// タイマーの時間
		/// </summary>
		[XmlElement("time")]
		public string time { set; get; }
	}

	/// <summary>
	/// タイマーデータ読み込みクラス
	/// </summary>
	public class TimerDataRead
	{
		public TimerDataList timerDataList { private set; get; }

		public TimerDataRead(string filepath)
		{
			timerDataList = new TimerDataList();

			using (var fs = new FileStream(filepath, FileMode.Open))
			{
				var serializer = new XmlSerializer(typeof(TimerDataList));
				timerDataList = (TimerDataList)serializer.Deserialize(fs);
			}
		}
	}

}
