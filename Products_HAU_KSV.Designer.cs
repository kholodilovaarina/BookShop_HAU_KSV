
namespace BookShop_HAU_KSV
{
    partial class Products_HAU_KSV
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
            this.components = new System.ComponentModel.Container();
            this.listView_Products = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip_Products = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКЗаказуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasketBut = new System.Windows.Forms.Button();
            this.bookShopDataSet = new BookShop_HAU_KSV.BookShopDataSet();
            this.тОВАРTableAdapter = new BookShop_HAU_KSV.BookShopDataSetTableAdapters.ТОВАРTableAdapter();
            this.tableAdapterManager = new BookShop_HAU_KSV.BookShopDataSetTableAdapters.TableAdapterManager();
            this.ButDel = new System.Windows.Forms.Button();
            this.contextMenuStrip_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Products.FullRowSelect = true;
            this.listView_Products.GridLines = true;
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(-2, 83);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(1057, 370);
            this.listView_Products.TabIndex = 0;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Номер";
            this.columnHeader6.Width = 1;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Наименование";
            this.columnHeader1.Width = 235;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Производитель";
            this.columnHeader2.Width = 233;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Цена";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Размер скидки";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание";
            this.columnHeader5.Width = 367;
            // 
            // contextMenuStrip_Products
            // 
            this.contextMenuStrip_Products.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКЗаказуToolStripMenuItem});
            this.contextMenuStrip_Products.Name = "contextMenuStrip_Products";
            this.contextMenuStrip_Products.Size = new System.Drawing.Size(173, 26);
            // 
            // добавитьКЗаказуToolStripMenuItem
            // 
            this.добавитьКЗаказуToolStripMenuItem.Name = "добавитьКЗаказуToolStripMenuItem";
            this.добавитьКЗаказуToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.добавитьКЗаказуToolStripMenuItem.Text = "Добавить к заказу";
            // 
            // BasketBut
            // 
            this.BasketBut.Location = new System.Drawing.Point(926, 12);
            this.BasketBut.Name = "BasketBut";
            this.BasketBut.Size = new System.Drawing.Size(67, 32);
            this.BasketBut.TabIndex = 2;
            this.BasketBut.Text = "Корзина";
            this.BasketBut.UseVisualStyleBackColor = true;
            // 
            // bookShopDataSet
            // 
            this.bookShopDataSet.DataSetName = "BookShopDataSet";
            this.bookShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тОВАРTableAdapter
            // 
            this.тОВАРTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BookShop_HAU_KSV.BookShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗАКАЗTableAdapter = null;
            this.tableAdapterManager.КЛИЕНТTableAdapter = null;
            this.tableAdapterManager.ПУНКТ_ВЫДАЧИTableAdapter = null;
            this.tableAdapterManager.РОЛЬTableAdapter = null;
            this.tableAdapterManager.СКЛАДTableAdapter = null;
            this.tableAdapterManager.СОСТАВ_ЗАКАЗАTableAdapter = null;
            this.tableAdapterManager.СОТРУДНИКTableAdapter = null;
            this.tableAdapterManager.СТАТУСTableAdapter = null;
            this.tableAdapterManager.ТОВАРTableAdapter = this.тОВАРTableAdapter;
            // 
            // ButDel
            // 
            this.ButDel.Location = new System.Drawing.Point(13, 13);
            this.ButDel.Name = "ButDel";
            this.ButDel.Size = new System.Drawing.Size(118, 23);
            this.ButDel.TabIndex = 3;
            this.ButDel.Text = "Удалить";
            this.ButDel.UseVisualStyleBackColor = true;
            this.ButDel.Click += new System.EventHandler(this.ButDel_Click);
            // 
            // Products_HAU_KSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 453);
            this.Controls.Add(this.ButDel);
            this.Controls.Add(this.BasketBut);
            this.Controls.Add(this.listView_Products);
            this.Name = "Products_HAU_KSV";
            this.Text = "ООО \"Книжный клуб\" - Товары";
            this.Load += new System.EventHandler(this.Products_HAU_KSV_Load);
            this.contextMenuStrip_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Products;
        private System.Windows.Forms.ToolStripMenuItem добавитьКЗаказуToolStripMenuItem;
        private System.Windows.Forms.Button BasketBut;
        private BookShopDataSet bookShopDataSet;
        private BookShopDataSetTableAdapters.ТОВАРTableAdapter тОВАРTableAdapter;
        private BookShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button ButDel;
    }
}