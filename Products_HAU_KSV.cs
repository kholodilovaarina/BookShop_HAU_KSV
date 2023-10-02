using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_HAU_KSV
{
    public partial class Products_HAU_KSV : Form
    {
        ListViewItem LastSelectedItem;
        public Products_HAU_KSV()
        {
            InitializeComponent();
        }

        private void Products_HAU_KSV_Load(object sender, EventArgs e)
        {
            FillProductsList();
        }
        public void FillProductsList()
        {
            this.тОВАРTableAdapter.Fill(this.bookShopDataSet.ТОВАР);
            listView_Products.Items.Clear();
            foreach(DataRow Row in bookShopDataSet.ТОВАР.Rows)
            {
                string[] items = new string[6];
                items[1] = Row["Наименование"].ToString();
                items[2] = Row["Производитель"].ToString();
                items[3] = String.Format("{0:00.00}", Convert.ToDouble(Row["Цена"]));
                items[4] = $"{Row["Скидка"].ToString()}%";
                items[5] = Row["Описание"].ToString();
                ListViewItem it = new ListViewItem();
                it.Text = Row["Номер_товара"].ToString();
                it.SubItems.AddRange(items);
                listView_Products.Items.Add(it);
            }
        }

        private void ButDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in listView_Products.SelectedItems)
            {
                DataRow Row = bookShopDataSet.ТОВАР.Select($"Номер_товара = '{ Item.Text}'")[0];
                DataRow[] TempRows = Row.GetChildRows("FK_СОСТАВ_ЗАКАЗА_ТОВАР");

                if (TempRows.Length != 0)
                {
                    MessageBox.Show("На этот товар уже есть заказ.\nЕго невозможно удалить.", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                Item.Remove();
                Row.Delete();
            }
            тОВАРTableAdapter.Update(bookShopDataSet.ТОВАР);
            тОВАРTableAdapter.Fill(bookShopDataSet.ТОВАР);
        }
    }
}
