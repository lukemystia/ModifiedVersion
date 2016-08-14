namespace MultipleCounter
{
	partial class Form1
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
			this.buttonAddCounter = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAddCounter
			// 
			this.buttonAddCounter.Location = new System.Drawing.Point(12, 12);
			this.buttonAddCounter.Name = "buttonAddCounter";
			this.buttonAddCounter.Size = new System.Drawing.Size(205, 23);
			this.buttonAddCounter.TabIndex = 0;
			this.buttonAddCounter.Text = "カウンタを追加";
			this.buttonAddCounter.UseVisualStyleBackColor = true;
			this.buttonAddCounter.Click += new System.EventHandler(this.buttonAddCounter_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(223, 12);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(205, 23);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Text = "保存";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 47);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonAddCounter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "複数カウンタ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAddCounter;
		private System.Windows.Forms.Button buttonSave;
	}
}

