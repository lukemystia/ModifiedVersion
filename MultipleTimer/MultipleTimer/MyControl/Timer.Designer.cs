namespace MultipleTimer.MyControl
{
	partial class Timer
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
			this.components = new System.ComponentModel.Container();
			this.textBoxItemName = new System.Windows.Forms.TextBox();
			this.textBoxTimer = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textBoxItemName
			// 
			this.textBoxItemName.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.textBoxItemName.Location = new System.Drawing.Point(3, 3);
			this.textBoxItemName.Name = "textBoxItemName";
			this.textBoxItemName.Size = new System.Drawing.Size(134, 23);
			this.textBoxItemName.TabIndex = 0;
			// 
			// textBoxTimer
			// 
			this.textBoxTimer.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.textBoxTimer.Location = new System.Drawing.Point(143, 3);
			this.textBoxTimer.Name = "textBoxTimer";
			this.textBoxTimer.ReadOnly = true;
			this.textBoxTimer.Size = new System.Drawing.Size(62, 23);
			this.textBoxTimer.TabIndex = 1;
			this.textBoxTimer.Text = "00:00:00";
			// 
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.buttonStart.Location = new System.Drawing.Point(211, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(25, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "▶";
			this.buttonStart.UseVisualStyleBackColor = true;
			// 
			// buttonRestart
			// 
			this.buttonRestart.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.buttonRestart.Location = new System.Drawing.Point(242, 3);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new System.Drawing.Size(25, 23);
			this.buttonRestart.TabIndex = 3;
			this.buttonRestart.Text = "↶";
			this.buttonRestart.UseVisualStyleBackColor = true;
			// 
			// Timer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonRestart);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textBoxTimer);
			this.Controls.Add(this.textBoxItemName);
			this.Name = "Timer";
			this.Size = new System.Drawing.Size(271, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.TextBox textBoxTimer;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonRestart;
		private System.Windows.Forms.Timer timer1;
	}
}
