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
	public partial class CreateForm : Form
	{
		private readonly decimal _PriceSum;
		private readonly string _DateString;
		private Random _Random = new Random();
		private int _MaxListCount { get => 6; }
		private readonly ListItem[] _Items;

		private class RandomResult
		{
			public ListItem[] ItemList;
			public int[] ItemCount;
			public int Count;

			public decimal SumPrice
			{
				get
				{
					decimal sum = 0;
					for (int i = 0; i < Count; i++)
					{
						sum += ItemList[i].Price * ItemCount[i];
					}
					return sum;
				}
			}

			public double CountVariance
			{
				get
				{
					double avg = ItemCount.Average();
					return Count > 1 ? ItemCount.Sum(c => Math.Pow(c - avg, 2)) / (Count - 1) : 0;
				}
			}

			public double HowBad(decimal sumPrice)
			{
				if (sumPrice == SumPrice)
				{
					return CountVariance / 10 + (double)(SumPrice - sumPrice) / 10000;
				}
				else
				{
					return CountVariance + (double)(SumPrice - sumPrice) / 10000;
				}
			}

			public void RemoveZeroCount()
			{
				List<ListItem> itemList = new List<ListItem>(ItemList);
				List<int> countList = new List<int>(ItemCount);
				for (int i = 0; i < Count; i++)
				{
					if (countList[i] == 0)
					{
						itemList.RemoveAt(i);
						countList.RemoveAt(i);
						i--;
						Count--;
					}
				}
				ItemList = itemList.ToArray();
				ItemCount = countList.ToArray();
			}
		}

		public CreateForm(decimal priceSum, string date)
		{
			_PriceSum = priceSum;
			_DateString = date;
			InitializeComponent();
			_Items = Program.ReadXml();
		}

		private int random(int max)
		{
			return _Random.Next(max);
		}

		private RandomResult CreateRandomList()
		{
			decimal sum = 0;
			int count = random(_MaxListCount);
			RandomResult result = new RandomResult { ItemList = new ListItem[count + 1], ItemCount = new int[count + 1], Count = count + 1 };
			List<ListItem> itemList = new List<ListItem>(_Items);
			List<int> indexList = new List<int>();
			for (int i = 0; i <= count; i++)
			{
				indexList.Add(i);
			}
			for (int i = 0; i <= count; i++)
			{
				int index = indexList[random(indexList.Count)];
				indexList.Remove(index);
				result.ItemList[index] = itemList[random(itemList.Count)];
				itemList.Remove(result.ItemList[index]);
				decimal last = _PriceSum - sum > 0 ? _PriceSum - sum : 0;
				int needCount = (int)Math.Ceiling(last / result.ItemList[index].Price);
				result.ItemCount[index] = i < count ? random(needCount) : needCount;
				sum += result.ItemList[index].Price * result.ItemCount[index];
			}
			//for (int i = 0; i <= count; i++)
			//{
			//	result.ItemList[i] = itemList[random(itemList.Count)];
			//	itemList.Remove(result.ItemList[i]);
			//	decimal last = _PriceSum - sum > 0 ? _PriceSum - sum : 0;
			//	int needCount = (int)Math.Ceiling(last / result.ItemList[i].Price);
			//	result.ItemCount[i] = i < count ? random(needCount) : needCount;
			//	sum += result.ItemList[i].Price * result.ItemCount[i];
			//}
			result.RemoveZeroCount();
			return result;
		}

		private void CreateForm_Load(object sender, EventArgs e)
		{
			RandomResult[] resultList = new RandomResult[_MaxListCount];
			for (int i = 0; i < _MaxListCount; i++)
			{
				resultList[i] = CreateRandomList();
			}
			for (int i = 0; i < 500; i++)
			{
				RandomResult r = CreateRandomList();
				if (r.HowBad(_PriceSum) < resultList[r.Count - 1].HowBad(_PriceSum) || resultList[r.Count - 1].Count != r.Count)
				{
					resultList[r.Count - 1] = r;
				}
			}
			RandomResult result = resultList[random(_MaxListCount)];
			string resultText = "";
			for (int i = 0; i < result.Count; i++)
			{
				resultText += _DateString + "\t\t" + result.ItemList[i].Name + "\t" + result.ItemList[i].Color + "\t件\t" + result.ItemCount[i] + "\t" + result.ItemList[i].Price + "\t" + result.ItemList[i].Price * result.ItemCount[i] + Environment.NewLine;
			}
			Text = "应收：￥" + result.SumPrice + "，实收：￥" + _PriceSum;
			txt_Content.Text = resultText;
		}

		private void CreateForm_Shown(object sender, EventArgs e)
		{
			Clipboard.SetText(txt_Content.Text);
			//MessageBox.Show("生成的内容已复制至剪贴板，直接转到excel表格中粘贴即可。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
