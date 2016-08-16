namespace MultipleTimer
{
	partial class FormMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.時間パターン設定TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.タイマーを追加TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(293, 26);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.タイマーを追加TToolStripMenuItem,
            this.時間パターン設定TToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了XToolStripMenuItem});
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.設定ToolStripMenuItem.Text = "オプション(&O)";
			// 
			// 時間パターン設定TToolStripMenuItem
			// 
			this.時間パターン設定TToolStripMenuItem.Name = "時間パターン設定TToolStripMenuItem";
			this.時間パターン設定TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.時間パターン設定TToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.時間パターン設定TToolStripMenuItem.Text = "オプション(&O)";
			this.時間パターン設定TToolStripMenuItem.Click += new System.EventHandler(this.時間パターン設定TToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.終了XToolStripMenuItem.Text = "終了(&X)";
			// 
			// タイマーを追加TToolStripMenuItem
			// 
			this.タイマーを追加TToolStripMenuItem.Name = "タイマーを追加TToolStripMenuItem";
			this.タイマーを追加TToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.タイマーを追加TToolStripMenuItem.Text = "タイマーを追加(&T)";
			this.タイマーを追加TToolStripMenuItem.Click += new System.EventHandler(this.タイマーを追加TToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 252);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "複数タイマー";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 時間パターン設定TToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem タイマーを追加TToolStripMenuItem;
	}
}

