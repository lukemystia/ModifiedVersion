using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultipleTimer.Common;
using MultipleTimer.MyControl;

namespace MultipleTimer
{
	public partial class FormConfiguration : Form
	{
		/// <summary>
		/// ツリービュー設定
		/// </summary>
		public FormConfiguration()
		{
			InitializeComponent();

			var timerNode = new ExtendedTreeNode("タイマー設定" , new TimerConfig());
			var soundNode = new ExtendedTreeNode("終了音設定", new SoundConfig());

			// ツリーに追加
			this.treeView1.Nodes.Add(timerNode);
			this.treeView1.Nodes.Add(soundNode);
		}

		/// <summary>
		/// ツリービュー選択
		/// 右画面表示切り替え
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var selected = e.Node as ExtendedTreeNode;
			this.UserControlPanel.Controls.Clear();	// 消去

			if (selected != null)
			{
				// 表示
				this.UserControlPanel.Controls.Add(selected.control);
				selected.control.Dock = DockStyle.Fill;
			}
		}
	}
}
