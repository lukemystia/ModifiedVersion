using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeLibrary
{
	/// <summary>
	/// int拡張
	/// </summary>
	public static class intExtensions
	{
		/// <summary>
		/// 通算秒を日付データに変換する
		/// </summary>
		/// <param name="unixTime">通算秒</param>
		/// <returns></returns>
		public static DateTime ToDatetime(this int unixTime)
		{
			return new DateTime(1970, 1, 1).AddSeconds(unixTime);
		}

		/// <summary>
		/// 通算秒を文字列の時間に変える
		/// </summary>
		/// <param name="unixTime">通算秒</param>
		/// <returns>00:00:00形式</returns>
		public static string ToTextTime(this int unixTime)
		{
			var hour = unixTime / (60 * 60);
			unixTime -= hour * 60 * 60;
			var min = unixTime / 60;
			unixTime -= min * 60;
			var sec = unixTime;

			var retstr = new StringBuilder();
			retstr.Append(hour.ToString().PadLeft(2, '0'));
			retstr.Append(":");
			retstr.Append(min.ToString().PadLeft(2, '0'));
			retstr.Append(":");
			retstr.Append(sec.ToString().PadLeft(2, '0'));

			return retstr.ToString();
		}
	}
}
