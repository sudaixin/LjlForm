namespace LjlForm
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_ShowList = new System.Windows.Forms.Button();
			this.txt_Sum = new System.Windows.Forms.TextBox();
			this.btn_CreateContent = new System.Windows.Forms.Button();
			this.lbl_yuan = new System.Windows.Forms.Label();
			this.Date_Select = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// btn_ShowList
			// 
			this.btn_ShowList.Location = new System.Drawing.Point(137, 66);
			this.btn_ShowList.Name = "btn_ShowList";
			this.btn_ShowList.Size = new System.Drawing.Size(75, 23);
			this.btn_ShowList.TabIndex = 0;
			this.btn_ShowList.Text = "管理列表";
			this.btn_ShowList.UseVisualStyleBackColor = true;
			this.btn_ShowList.Click += new System.EventHandler(this.btn_ShowList_Click);
			// 
			// txt_Sum
			// 
			this.txt_Sum.Location = new System.Drawing.Point(35, 39);
			this.txt_Sum.Name = "txt_Sum";
			this.txt_Sum.Size = new System.Drawing.Size(100, 21);
			this.txt_Sum.TabIndex = 1;
			// 
			// btn_CreateContent
			// 
			this.btn_CreateContent.Location = new System.Drawing.Point(12, 66);
			this.btn_CreateContent.Name = "btn_CreateContent";
			this.btn_CreateContent.Size = new System.Drawing.Size(75, 23);
			this.btn_CreateContent.TabIndex = 2;
			this.btn_CreateContent.Text = "生成";
			this.btn_CreateContent.UseVisualStyleBackColor = true;
			this.btn_CreateContent.Click += new System.EventHandler(this.btn_CreateContent_Click);
			// 
			// lbl_yuan
			// 
			this.lbl_yuan.AutoSize = true;
			this.lbl_yuan.Location = new System.Drawing.Point(12, 42);
			this.lbl_yuan.Name = "lbl_yuan";
			this.lbl_yuan.Size = new System.Drawing.Size(17, 12);
			this.lbl_yuan.TabIndex = 3;
			this.lbl_yuan.Text = "￥";
			// 
			// Date_Select
			// 
			this.Date_Select.CustomFormat = "M月d日";
			this.Date_Select.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Date_Select.Location = new System.Drawing.Point(12, 12);
			this.Date_Select.Name = "Date_Select";
			this.Date_Select.Size = new System.Drawing.Size(200, 21);
			this.Date_Select.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 96);
			this.Controls.Add(this.Date_Select);
			this.Controls.Add(this.lbl_yuan);
			this.Controls.Add(this.btn_CreateContent);
			this.Controls.Add(this.txt_Sum);
			this.Controls.Add(this.btn_ShowList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "送货单内容生成";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ShowList;
		private System.Windows.Forms.TextBox txt_Sum;
		private System.Windows.Forms.Button btn_CreateContent;
		private System.Windows.Forms.Label lbl_yuan;
		private System.Windows.Forms.DateTimePicker Date_Select;
	}
}

