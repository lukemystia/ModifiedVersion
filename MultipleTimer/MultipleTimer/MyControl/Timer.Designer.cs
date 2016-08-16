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
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.labelTimer = new System.Windows.Forms.Label();
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
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.buttonStart.Location = new System.Drawing.Point(211, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(25, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "▶";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// labelTimer
			// 
			this.labelTimer.AutoSize = true;
			this.labelTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTimer.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.labelTimer.Location = new System.Drawing.Point(141, 6);
			this.labelTimer.Name = "labelTimer";
			this.labelTimer.Size = new System.Drawing.Size(64, 18);
			this.labelTimer.TabIndex = 4;
			this.labelTimer.Text = "00:00:00";
			// 
			// Timer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelTimer);
			this.Controls.Add(this.buttonRestart);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.textBoxItemName);
			this.Name = "Timer";
			this.Size = new System.Drawing.Size(271, 28);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxItemName;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonRestart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelTimer;
	}
}
