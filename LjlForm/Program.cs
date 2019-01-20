using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LjlForm
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		public static string
			XmlFileName = "LjlForm.xml",
			RootTagName = "Items",
			ChildTagName = "Item",
			IdAttrTag = "Id",
			NameAttrTag = "Name",
			ColorAttrTag = "Color",
			PriceAttrTag = "Price";

		public static ListItem[] ReadXml()
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load(System.IO.Path.Combine(Application.StartupPath, XmlFileName));
			XmlElement rootEl = xDoc.DocumentElement;
			List<ListItem> itemList = new List<ListItem>();
			foreach (XmlElement aEl in rootEl.ChildNodes)
			{
				ListItem item = new ListItem()
				{
					Id = aEl.GetAttribute(IdAttrTag),
					Name = aEl.GetAttribute(NameAttrTag),
					Color = aEl.GetAttribute(ColorAttrTag),
					Price = decimal.Parse(aEl.GetAttribute(PriceAttrTag))
				};
				itemList.Add(item);
			}
			return itemList.ToArray();
		}

		public enum SaveXmlType
		{
			Add,
			Edit,
			Delete
		}

		public static void SaveXml(ListItem item, SaveXmlType saveType)
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load(System.IO.Path.Combine(Application.StartupPath, XmlFileName));
			XmlElement rootEl = xDoc.DocumentElement;
			switch (saveType)
			{
				case SaveXmlType.Add:
					XmlElement aEl = xDoc.CreateElement(ChildTagName);
					aEl.SetAttribute(IdAttrTag, Guid.NewGuid().ToString("N"));
					aEl.SetAttribute(NameAttrTag, item.Name);
					aEl.SetAttribute(ColorAttrTag, item.Color);
					aEl.SetAttribute(PriceAttrTag, item.Price.ToString());
					rootEl.AppendChild(aEl);
					break;
				case SaveXmlType.Edit:
					XmlElement eEl = rootEl.SelectSingleNode(ChildTagName + "[@" + IdAttrTag + "='" + item.Id + "']") as XmlElement;
					eEl.SetAttribute(NameAttrTag, item.Name);
					eEl.SetAttribute(ColorAttrTag, item.Color);
					eEl.SetAttribute(PriceAttrTag, item.Price.ToString());
					break;
				case SaveXmlType.Delete:
					XmlElement dEl = rootEl.SelectSingleNode(ChildTagName + "[@" + IdAttrTag + "='" + item.Id + "']") as XmlElement;
					rootEl.RemoveChild(dEl);
					break;
				default:
					throw new Exception();
			}
			xDoc.Save(System.IO.Path.Combine(Application.StartupPath, XmlFileName));
		}
	}
}
