namespace MultipleTimer.MyControl
{
	partial class TimerConfig
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxTimerKind = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewTime = new System.Windows.Forms.DataGridView();
			this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "タイマープリセット設定";
			// 
			// comboBoxTimerKind
			// 
			this.comboBoxTimerKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTimerKind.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.comboBoxTimerKind.FormattingEnabled = true;
			this.comboBoxTimerKind.Location = new System.Drawing.Point(6, 28);
			this.comboBoxTimerKind.Name = "comboBoxTimerKind";
			this.comboBoxTimerKind.Size = new System.Drawing.Size(248, 24);
			this.comboBoxTimerKind.TabIndex = 2;
			this.comboBoxTimerKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimerKind_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.label2.Location = new System.Drawing.Point(3, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "現在設定されているタイマー";
			// 
			// dataGridViewTime
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time});
			this.dataGridViewTime.Location = new System.Drawing.Point(6, 100);
			this.dataGridViewTime.Name = "dataGridViewTime";
			this.dataGridViewTime.RowHeadersVisible = false;
			this.dataGridViewTime.RowTemplate.Height = 21;
			this.dataGridViewTime.Size = new System.Drawing.Size(99, 221);
			this.dataGridViewTime.TabIndex = 4;
			// 
			// time
			// 
			this.time.HeaderText = "time";
			this.time.Name = "time";
			this.time.Width = 96;
			// 
			// TimerConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridViewTime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxTimerKind);
			this.Controls.Add(this.label1);
			this.Name = "TimerConfig";
			this.Size = new System.Drawing.Size(406, 324);
			this.Load += new System.EventHandler(this.TimerConfig_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxTimerKind;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn time;
	}
}
