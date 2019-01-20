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
	public partial class EditForm : Form
	{
		public EditForm()
		{
			InitializeComponent();
		}

		public EditForm(string id) : this()
		{
			_Id = id;
			Text = "编辑";
		}

		private string _Id = null;

		private void EditForm_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(_Id))
			{
				ListItem[] items = Program.ReadXml();
				foreach (ListItem item in items)
				{
					if (item.Id == _Id)
					{
						txt_Name.Text = item.Name;
						txt_Color.Text = item.Color;
						txt_Price.Text = item.Price.ToString();
						return;
					}
				}
				throw new Exception("发生错误：没找到ID");
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(txt_Price.Text, out decimal txtPrice))
			{
				if (string.IsNullOrEmpty(_Id))
				{
					Program.SaveXml(new ListItem { Name = txt_Name.Text, Color = txt_Color.Text, Price = txtPrice }, Program.SaveXmlType.Add);
				}
				else
				{
					Program.SaveXml(new ListItem { Id = _Id, Name = txt_Name.Text, Color = txt_Color.Text, Price = txtPrice }, Program.SaveXmlType.Edit);
				}
				//MessageBox.Show("保存完成。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				(Owner as ListForm).RefreshDataGrid();
				Close();
			}
			else
			{
				MessageBox.Show("数字输入有误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
