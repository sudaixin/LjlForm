namespace LjlForm
{
	partial class CreateForm
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
			this.txt_Content = new System.Windows.Forms.TextBox();
			this.lbl_Guide = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_Content
			// 
			this.txt_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_Content.Location = new System.Drawing.Point(12, 28);
			this.txt_Content.Multiline = true;
			this.txt_Content.Name = "txt_Content";
			this.txt_Content.Size = new System.Drawing.Size(560, 221);
			this.txt_Content.TabIndex = 0;
			// 
			// lbl_Guide
			// 
			this.lbl_Guide.AutoSize = true;
			this.lbl_Guide.Location = new System.Drawing.Point(10, 9);
			this.lbl_Guide.Name = "lbl_Guide";
			this.lbl_Guide.Size = new System.Drawing.Size(203, 12);
			this.lbl_Guide.TabIndex = 1;
			this.lbl_Guide.Text = "内容已复制，可直接切到EXCEL粘贴。";
			// 
			// CreateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.lbl_Guide);
			this.Controls.Add(this.txt_Content);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MinimizeBox = false;
			this.Name = "CreateForm";
			this.Text = "生成内容";
			this.Load += new System.EventHandler(this.CreateForm_Load);
			this.Shown += new System.EventHandler(this.CreateForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Content;
		private System.Windows.Forms.Label lbl_Guide;
	}
}