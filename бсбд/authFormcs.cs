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
using System.Configuration;
using System.Web;

namespace бсбд
{
    public partial class authFormcs : Form
    {
        private SqlConnection sql_connection = null;
        public authFormcs()
        {
            InitializeComponent();
            
        }
        private void authFormcs_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database_1"].ConnectionString);
            sql_connection.Open();
        }

        private void Auth_button_Click(object sender, EventArgs e)
        {
            var user_login = login_txt_box.Text;
            var user_password = pass_txt_box.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            string query = $"select id, login, password, user_status from users where login = '{user_login}' and password = '{user_password}'";

            SqlCommand command = new SqlCommand(query, sql_connection);

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                var user = new checkuser(dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[3].ToString(), Convert.ToInt32(dt.Rows[0].ItemArray[0]));
                MessageBox.Show("Вход произведен успешно");
                MainForm main = new MainForm(user);
                this.Hide();
                sql_connection.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("Пользователя с такими данными не существует");
            }
        }

        private void to_reg_label_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Hide();
            sql_connection.Close();
            registration.Show();
        }
    }
}
