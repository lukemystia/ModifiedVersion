using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTimer.Common
{
	/// <summary>
	/// TreeNode で選択された項目にひも付けたユーザコントロールクラス
	/// </summary>
	public class ExtendedTreeNode : TreeNode
	{
		public UserControl control { get; }

		public ExtendedTreeNode(string text, UserControl control) : base(text)
		{
			this.control = control;
		}
	}
}
