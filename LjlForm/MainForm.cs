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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btn_ShowList_Click(object sender, EventArgs e)
		{
			new ListForm().ShowDialog(this);
		}

		private void btn_CreateContent_Click(object sender, EventArgs e)
		{
			if (decimal.TryParse(txt_Sum.Text, out decimal priceSum))
			{
				new CreateForm(priceSum, Date_Select.Value.ToString("M月d日")).ShowDialog(this);
			}
			else
			{
				MessageBox.Show("数字输入有误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
