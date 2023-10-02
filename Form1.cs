using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_HAU_KSV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=U43-03;Initial Catalog=BookShop;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;

                string query = "SELECT COUNT(*) FROM СОТРУДНИК, КЛИЕНТ WHERE Логин = @Логин AND Пароль = @Пароль";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Логин", username);
                    command.Parameters.AddWithValue("@Пароль", password);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Пользователь аутентифицирован, разрешите доступ.
                        MessageBox.Show("Вход успешно выполнен!");
                        // Здесь можно открыть основную форму вашего приложения.
                    }
                    else
                    {
                        MessageBox.Show("Ошибка входа. Проверьте логин и пароль.");
                    }
                }
            }
        }
    }
}
