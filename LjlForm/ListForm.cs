using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LjlForm
{
	public partial class ListForm : Form
	{
		public ListForm()
		{
			InitializeComponent();
		}

		public void RefreshDataGrid()
		{
			ListForm_Load(null, null);
		}

		private void ListForm_Load(object sender, EventArgs e)
		{
			grdv_List.DataSource = Program.ReadXml();
			grdv_List.Columns[Program.IdAttrTag].Visible = false;
			grdv_List.Columns[Program.NameAttrTag].HeaderText = "品种";
			grdv_List.Columns[Program.ColorAttrTag].HeaderText = "颜色";
			grdv_List.Columns[Program.PriceAttrTag].HeaderText = "单价";
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			new EditForm().ShowDialog(this);
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			new EditForm(GetSelectedId()).ShowDialog(this);
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("确认删除选中的条目？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Program.SaveXml(new ListItem { Id = GetSelectedId() }, Program.SaveXmlType.Delete);
				//MessageBox.Show("删除完成。", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
				RefreshDataGrid();
			}
		}

		private string GetSelectedId()
		{
			return grdv_List.SelectedRows[0].Cells["Id"].Value as string;
		}
	}
}
