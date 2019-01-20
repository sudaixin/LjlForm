namespace LjlForm
{
	partial class ListForm
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
			this.grdv_List = new System.Windows.Forms.DataGridView();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdv_List)).BeginInit();
			this.SuspendLayout();
			// 
			// grdv_List
			// 
			this.grdv_List.AllowUserToAddRows = false;
			this.grdv_List.AllowUserToDeleteRows = false;
			this.grdv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdv_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdv_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdv_List.Location = new System.Drawing.Point(13, 13);
			this.grdv_List.MultiSelect = false;
			this.grdv_List.Name = "grdv_List";
			this.grdv_List.ReadOnly = true;
			this.grdv_List.RowTemplate.Height = 23;
			this.grdv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdv_List.Size = new System.Drawing.Size(259, 207);
			this.grdv_List.TabIndex = 0;
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Add.Location = new System.Drawing.Point(13, 226);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 2;
			this.btn_Add.Text = "增加";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Delete.Location = new System.Drawing.Point(175, 226);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 23);
			this.btn_Delete.TabIndex = 3;
			this.btn_Delete.Text = "删除";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Edit.Location = new System.Drawing.Point(94, 226);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(75, 23);
			this.btn_Edit.TabIndex = 4;
			this.btn_Edit.Text = "编辑";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// ListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.grdv_List);
			this.MinimizeBox = false;
			this.Name = "ListForm";
			this.Text = "管理列表";
			this.Load += new System.EventHandler(this.ListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdv_List)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView grdv_List;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Edit;
	}
}