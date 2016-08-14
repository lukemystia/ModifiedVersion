using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using static MultipleCounter.Const.ConstStr;

namespace MultipleCounter.Bzlogic
{
	/// <summary>
	/// セーブファイル関連
	/// </summary>
	public class SaveFile
	{
		/// <summary>
		/// セーブファイル作成
		/// </summary>
		/// <param name="writeData">書き込む内容</param>
		public void makeSaveFile(string writeData)
		{
			try
			{
				//前データ削除
				File.Delete(SAVE_FILE_NAME);

				// 書き込み
				using (var writer = new StreamWriter(SAVE_FILE_NAME, true, Encoding.GetEncoding("utf-8")))
				{
					writer.WriteLine(writeData);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		/// <summary>
		/// セーブファイルを読み込み、返す
		/// </summary>
		public List<string> readSaveFile()
		{
			try
			{
				var retList = new List<string>();

				// 読み込んだ一行格納用
				string tempLine = "";

				using (StreamReader sr = new StreamReader(SAVE_FILE_NAME, Encoding.GetEncoding("utf-8")))
				{
					while ((tempLine = sr.ReadLine()) != null)
					{
						retList.Add(tempLine);
					}
				}

				return retList;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}
}
