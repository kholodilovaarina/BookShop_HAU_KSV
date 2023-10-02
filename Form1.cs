using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop_HAU_KSV
{
    public partial class FormLogin_HAU_KSV : Form
    {
        public FormLogin_HAU_KSV()
        {
            InitializeComponent();
        }

        private void ViewProdBut_Click(object sender, EventArgs e)
        {
            Products_HAU_KSV Dialog = new Products_HAU_KSV();
            Dialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=U43-03;Initial Catalog=BookShop;Integrated Security=True";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            var cn = new OleDbConnection();
            cn.ConnectionString = Properties.Settings.Default.BookShopConnectionString;
            cn.Open();
            var sql = new OleDbCommand("SELECT COUNT(*) FROM Service WHERE Логин = '" + textBox1.Text + ", Пароль = '" + textBox2.Text + "'", cn); // текст запроса
            int UserExist = Convert.ToInt32(sql.ExecuteScalar());
            int count = (int)sql.ExecuteScalar();

                    if (count > 0)
                    {
                        // Пользователь аутентифицирован, разрешите доступ.
                        MessageBox.Show("Вход успешно выполнен!");
                        // Здесь можно открыть основную форму вашего приложения.
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа. Проверьте правильность заполнения логина и пароля.");
                    }
                }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
        }
    }
}
