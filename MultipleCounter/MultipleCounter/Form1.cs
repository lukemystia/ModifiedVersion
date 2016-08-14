using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MultipleCounter.Bzlogic;
using static MultipleCounter.Const.ConstStr;

namespace MultipleCounter
{
	public partial class Form1 : Form
	{
		#region 固定値
		/// <summary>
		/// カウンタの左
		/// </summary>
		private static readonly int COUNTER_LEFT_LOCATION = 60;

		/// <summary>
		/// 削除ボタンの左
		/// </summary>
		private static readonly int DEL_BTN_LEFT_LOCATION = 10;

		/// <summary>
		/// カウンタの上
		/// </summary>
		private static readonly int COUNTER_TOP_LOCATION = 20;

		/// <summary>
		/// 削除ボタンの上調整用
		/// </summary>
		private static readonly int DEL_BTN_TOP_LOCATION = 3;

		/// <summary>
		/// カウンタ同士の間
		/// </summary>
		private static readonly int COUNTER_BETWEEN = 30;
		#endregion 固定値

		/// <summary>
		/// カウンタの通し番号
		/// </summary>
		private int cntNum = 0;

		/// <summary>
		/// カウンタNoを格納
		/// </summary>
		List<int> counterNo = new List<int>();

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// ロードイベント
		/// 配置とイベント追加
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				// 終了時の位置記憶を行い、復元するか検討
				this.Top = 100;
				this.Left = 100;

				if (File.Exists(SAVE_FILE_NAME))
				{
					readSaveFile();
				}
				else
				{
					addCounterItem();
				}
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void addCounterItem(string name = "", string num = "0")
		{
			addCounter(name, num);
			addDelBtn();
			delBtnEnableCheck();
			formHeightChange();
		}

		/// <summary>
		/// カウンタの追加
		/// </summary>
		private void addCounter(string name, string num)
		{
			cntNum++;
			// カウンタNoを記録
			counterNo.Add(cntNum);

			var counter = new Counter();
			// プロパティ設定
			counter.Name = "cnt" + cntNum.ToString();
			counter.Text = "カウンタ" + cntNum.ToString();
			counter.Top = (counterNo.Count * COUNTER_BETWEEN) + COUNTER_TOP_LOCATION;
			counter.Left = COUNTER_LEFT_LOCATION;

			this.Controls.Add(counter);

			counter.setNameAndNum(name, num);
		}

		/// <summary>
		/// 削除ボタンの追加
		/// </summary>
		private void addDelBtn()
		{
			var delBtn = new Button();
			// プロパティ設定
			delBtn.Name = "delBtn" + cntNum.ToString();
			delBtn.Text = "削除";
			delBtn.Top = (counterNo.Count * COUNTER_BETWEEN) + COUNTER_TOP_LOCATION + DEL_BTN_TOP_LOCATION;
			delBtn.Left = DEL_BTN_LEFT_LOCATION;
			delBtn.Width = 50;

			this.Controls.Add(delBtn);

			delBtn.Click += DelBtn_Click;
		}

		/// <summary>
		/// 削除ボタンの有効無効切り替え
		/// 一つしか表示されていない時は無効化
		/// </summary>
		private void delBtnEnableCheck()
		{
			var contloritem = this.Controls.Find("delBtn" + counterNo[0], true);
			contloritem[0].Enabled = (counterNo.Count != 1) ? true : false;
		}

		/// <summary>
		/// フォーム自体の高さ
		/// </summary>
		private void formHeightChange()
		{
			this.Height = counterNo.Count * COUNTER_BETWEEN + 100;
		}

		/// <summary>
		/// カウンタを増やす
		/// 削除ボタンも同時に増やす
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonAddCounter_Click(object sender, EventArgs e)
		{
			try
			{
				addCounterItem();
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// 削除ボタン押下イベント
		/// 自身と連動しているカウンタを消す
		/// その後アイテムの表示を詰める
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DelBtn_Click(object sender, EventArgs e)
		{
			if (counterNo.Count == 1) return;

			// 自身の番号
			var no = ((Button)sender).Name.Substring(6);
			// 削除
			deleteItem(no);
			// 抜けたところを埋める
			itemLocationChange();

			delBtnEnableCheck();
			formHeightChange();
		}

		/// <summary>
		/// 削除
		/// </summary>
		/// <param name="no"></param>
		private void deleteItem(string no)
		{
			var contloritem = this.Controls.Find("cnt" + no, true);
			if (this.Controls.Contains(contloritem[0]))
			{
				this.Controls.Remove(contloritem[0]);
			}

			contloritem = this.Controls.Find("delBtn" + no, true);
			if (this.Controls.Contains(contloritem[0]))
			{
				this.Controls.Remove(contloritem[0]);
			}

			counterNo.Remove(int.Parse(no));
		}

		/// <summary>
		/// 抜けたところを埋める
		/// </summary>
		private void itemLocationChange()
		{
			itemLocationChange("cnt");
			itemLocationChange("delBtn");
		}

		private void itemLocationChange(string name)
		{
			var adju = (name == "cnt") ? 0 : 3;
			var tempCntNum = 0;

			foreach (var item in counterNo)
			{
				var contloritem = this.Controls.Find(name + item.ToString(), true);
				if (this.Controls.Contains(contloritem[0]))
				{
					tempCntNum++;
					contloritem[0].Top = (tempCntNum * COUNTER_BETWEEN) + COUNTER_TOP_LOCATION + adju;
				}
			}
		}

		/// <summary>
		/// 保存ボタン
		/// 表示されているカウンタの項目名と項目カウント数をcsvファイルに出力
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSave_Click(object sender, EventArgs e)
		{
			var writeData = makeWriteData();

			var logic = new SaveFile();
			logic.makeSaveFile(writeData);
		}

		/// <summary>
		/// 書き込みデータ取得
		/// </summary>
		/// <returns></returns>
		private string makeWriteData()
		{
			var writeData = new StringBuilder();
			foreach (var item in counterNo)
			{
				var contloritem = this.Controls.Find("cnt" + item.ToString(), true);
				if (this.Controls.Contains((Counter)contloritem[0]))
				{
					writeData.Append(((Counter)contloritem[0]).getNameAndNum());
					writeData.Append("\n");
				}
			}

			return writeData.ToString();
		}

		/// <summary>
		/// セーブファイルを読み込み、復元する
		/// </summary>
		private void readSaveFile()
		{
			try
			{
				// データ取得
				var logic = new SaveFile();
				var getDataList = logic.readSaveFile();

				foreach (var item in getDataList)
				{
					var temp = item.Split(',');
					var name = temp[0];
					var num = temp[1];

					addCounterItem(name, num);
				}
			}
			catch (Exception)
			{

			}
		}
	}
}
