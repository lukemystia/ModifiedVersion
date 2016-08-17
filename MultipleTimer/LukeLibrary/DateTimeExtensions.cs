using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeLibrary
{
	/// <summary>
	/// DateTime拡張
	/// </summary>
	public static class DateTimeExtensions
	{
		/// <summary>
		/// 指定時刻の通算秒取得
		/// </summary>
		/// <returns></returns>
		public static int getUnixTime(this DateTime dt)
		{
			return (int)(dt - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
		}
	}
}
