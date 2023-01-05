using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бсбд
{
    public partial class RegistrationForm : Form
    {
        private SqlConnection sql_connection = null;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database_1"].ConnectionString);
            sql_connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var reg_login = Reg_log_txt_box.Text;
                var reg_password = Reg_pass_txt_box.Text;

                string query = $"INSERT INTO users (login, password, user_status) " +
                    $"VALUES ('{reg_login}','{reg_password}','customer')";

                SqlCommand cmd = new SqlCommand(query, sql_connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь добавлен успешно");
                authFormcs auth = new authFormcs();
                this.Hide();
                auth.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Не верно введены данные");
            }
            
        }

        private void To_auth_Form_Click(object sender, EventArgs e)
        {
            authFormcs auth = new authFormcs();
            this.Hide();
            auth.Show();
        }

    }
}
