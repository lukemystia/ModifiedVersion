using System;
using System.Text;
using System.Windows.Forms;

namespace MultipleCounter
{
	public partial class Counter : UserControl
	{
		public Counter()
		{
			InitializeComponent();
		}

		/// <summary>
		/// カウント数
		/// </summary>
		int countNum = 0;

		private void Counter_Load(object sender, EventArgs e)
		{
			viewCount();
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			countNum++;
			viewCount();
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			if (countNum == 0) return;

			countNum--;
			viewCount();
		}

		private void buttonZero_Click(object sender, EventArgs e)
		{
			countNum = 0;
			viewCount();
		}

		/// <summary>
		/// 表示
		/// </summary>
		private void viewCount()
		{
			this.textBoxItemNum.Text = countNum.ToString();
		}

		/// <summary>
		/// 項目名と数をカンマ区切りで返す
		/// </summary>
		/// <returns></returns>
		public string getNameAndNum()
		{
			var ret = new StringBuilder();

			ret.Append(textBoxItemName.Text);
			ret.Append(",");
			ret.Append(textBoxItemNum.Text);

			return ret.ToString();
		}

		/// <summary>
		/// 項目名と数を設定する
		/// </summary>
		/// <param name="name"></param>
		/// <param name="num"></param>
		public void setNameAndNum(string name = "", string num = "0")
		{
			this.textBoxItemName.Text = name;
			this.textBoxItemNum.Text = num;
		}
	}
}
