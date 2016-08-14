namespace MultipleCounter
{
	partial class Counter
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

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxItemName = new System.Windows.Forms.TextBox();
			this.textBoxItemNum = new System.Windows.Forms.TextBox();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.buttonMinus = new System.Windows.Forms.Button();
			this.buttonZero = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxItemName
			// 
			this.textBoxItemName.Location = new System.Drawing.Point(3, 5);
			this.textBoxItemName.Name = "textBoxItemName";
			this.textBoxItemName.Size = new System.Drawing.Size(155, 19);
			this.textBoxItemName.TabIndex = 0;
			// 
			// textBoxItemNum
			// 
			this.textBoxItemNum.Location = new System.Drawing.Point(164, 5);
			this.textBoxItemNum.Name = "textBoxItemNum";
			this.textBoxItemNum.ReadOnly = true;
			this.textBoxItemNum.Size = new System.Drawing.Size(57, 19);
			this.textBoxItemNum.TabIndex = 2;
			this.textBoxItemNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// buttonPlus
			// 
			this.buttonPlus.Location = new System.Drawing.Point(227, 3);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(43, 23);
			this.buttonPlus.TabIndex = 3;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
			// 
			// buttonMinus
			// 
			this.buttonMinus.Location = new System.Drawing.Point(276, 3);
			this.buttonMinus.Name = "buttonMinus";
			this.buttonMinus.Size = new System.Drawing.Size(43, 23);
			this.buttonMinus.TabIndex = 4;
			this.buttonMinus.Text = "-";
			this.buttonMinus.UseVisualStyleBackColor = true;
			this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
			// 
			// buttonZero
			// 
			this.buttonZero.Location = new System.Drawing.Point(325, 3);
			this.buttonZero.Name = "buttonZero";
			this.buttonZero.Size = new System.Drawing.Size(43, 23);
			this.buttonZero.TabIndex = 5;
			this.buttonZero.Text = "0";
			this.buttonZero.UseVisualStyleBackColor = true;
			this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
			// 
			// Counter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonZero);
			this.Controls.Add(this.buttonMinus);
			this.Controls.Add(this.buttonPlus);
			this.Controls.Add(this.textBoxItemNum);
			this.Controls.Add(this.textBoxItemName);
			this.Name = "Counter";
			this.Size = new System.Drawing.Size(374, 29);
			this.Load += new System.EventHandler(this.Counter_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button buttonMinus;
		private System.Windows.Forms.Button buttonZero;
		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.TextBox textBoxItemNum;
	}
}
