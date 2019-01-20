namespace LjlForm
{
	partial class EditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.txt_Color = new System.Windows.Forms.TextBox();
			this.lbl_Price = new System.Windows.Forms.Label();
			this.txt_Price = new System.Windows.Forms.TextBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_Name
			// 
			this.txt_Name.Location = new System.Drawing.Point(47, 12);
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(100, 21);
			this.txt_Name.TabIndex = 0;
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Location = new System.Drawing.Point(12, 15);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(29, 12);
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "品种";
			// 
			// lbl_Color
			// 
			this.lbl_Color.AutoSize = true;
			this.lbl_Color.Location = new System.Drawing.Point(12, 42);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(29, 12);
			this.lbl_Color.TabIndex = 2;
			this.lbl_Color.Text = "颜色";
			// 
			// txt_Color
			// 
			this.txt_Color.Location = new System.Drawing.Point(47, 39);
			this.txt_Color.Name = "txt_Color";
			this.txt_Color.Size = new System.Drawing.Size(100, 21);
			this.txt_Color.TabIndex = 3;
			// 
			// lbl_Price
			// 
			this.lbl_Price.AutoSize = true;
			this.lbl_Price.Location = new System.Drawing.Point(12, 69);
			this.lbl_Price.Name = "lbl_Price";
			this.lbl_Price.Size = new System.Drawing.Size(29, 12);
			this.lbl_Price.TabIndex = 4;
			this.lbl_Price.Text = "价格";
			// 
			// txt_Price
			// 
			this.txt_Price.Location = new System.Drawing.Point(47, 66);
			this.txt_Price.Name = "txt_Price";
			this.txt_Price.Size = new System.Drawing.Size(100, 21);
			this.txt_Price.TabIndex = 5;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(47, 93);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 6;
			this.btn_Save.Text = "保存";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(162, 126);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.txt_Price);
			this.Controls.Add(this.lbl_Price);
			this.Controls.Add(this.txt_Color);
			this.Controls.Add(this.lbl_Color);
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.txt_Name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditForm";
			this.Text = "新增";
			this.Load += new System.EventHandler(this.EditForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.TextBox txt_Color;
		private System.Windows.Forms.Label lbl_Price;
		private System.Windows.Forms.TextBox txt_Price;
		private System.Windows.Forms.Button btn_Save;
	}
}