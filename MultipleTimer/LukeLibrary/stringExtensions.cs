using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeLibrary
{
	/// <summary>
	/// string拡張
	/// </summary>
	public static class stringExtensions
	{
		/// <summary>
		/// 文字列の時間を通算秒に変える
		/// </summary>
		/// <returns></returns>
		public static int ToUnixTime(this string time)
		{
			time = time.Replace(":", "");

			int result = 0;
			if (int.TryParse(time, out result))
			{
				return int.Parse(time.Substring(0, 2)) * 60 * 60 + int.Parse(time.Substring(2, 2)) * 60 + int.Parse(time.Substring(4, 2));
			}

			throw new FormatException(time);
		}
	}
}
