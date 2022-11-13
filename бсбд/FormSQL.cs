using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace бсбд
{
    public partial class FormSQL : Form
    {
        private SqlConnection sql_connection = null;
        private static FormSQL FormSQL_form;
        public static FormSQL FormSQL_f
        {
            get
            {
                if (FormSQL_form == null || FormSQL_form.IsDisposed) FormSQL_form = new FormSQL();
                return FormSQL_form;
            }
        }
        public FormSQL()
        {
            InitializeComponent();
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database_1"].ConnectionString);
            sql_connection.Open();
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект command для SQL команды
            SqlCommand command = sql_connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
             DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }
        private void radiobuttonDevs_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("select * from Technical_requirements"); 
        }

        private void radioButtonCustomers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("select  Customer.email, Customer.phone_number, " +
                "Technical_requirements.Goal, Technical_requirements.Cost from \r" +
                "\nCustomer inner join Technical_requirements on Customer.Id= Technical_requirements.customer_id\r" +
                "\norder by Cost");
        }

        private void radioButtonCompanies_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("select customer_id, Cost as [цена заказа], " +
                "cast(Cost*1.2 AS decimal(16,2)) as [цена с вычетом налога] from Technical_requirements\r" +
                "\norder by [цена с вычетом налога]");
        }


        private void Queries_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_company_id_for_query.Text))
            {
                MessageBox.Show("Обязательно укажите id компании",
               "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonKorZapros.Checked)
            {
                sqlSelect = @"SELECT * FROM Developer WHERE company_id = (SELECT Id From Company WHERE Id = @number_id)";
            }
            else
            if (radioButtonNeKorZapros.Checked)
                sqlSelect = "SELECT * FROM Developer WHERE company_id = @number_id";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand command = sql_connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
               command.Parameters.Add("@number_id", SqlDbType.Int).Value =
               int.Parse(textBox_company_id_for_query.Text);
            }
            catch
            {
                MessageBox.Show("Номер заказа в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubQueries.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void radioButtonCheck_project_cost_CheckedChanged_1(object sender, EventArgs e)
        {
            dataGridViewSELECT_FULL.DataSource = FillDataGridView("select customer_id, AVG(Cost) as Average_cost from Technical_requirements\r" +
                "\nwhere customer_id > 1\r" +
                "\ngroup by customer_id\r" +
                "\nhaving AVG(Cost) > 1000000\r" +
                "\norder by customer_id");
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            if (radioButtonInsertDev.Checked == true)
            {
                textBoxIdDev.Enabled = false;
                if (string.IsNullOrEmpty(textBoxSurname.Text) == false && string.IsNullOrEmpty(textBoxName.Text) == false 
                    && string.IsNullOrEmpty(textBoxMiddleName.Text) == false && string.IsNullOrEmpty(textBoxSpeakEng.Text) == false 
                    && string.IsNullOrEmpty(textBoxCoding.Text) == false && string.IsNullOrEmpty(textBoxKnowScrum.Text) == false 
                    && string.IsNullOrEmpty(textBoxEmail.Text) == false && string.IsNullOrEmpty(textBoxPhoneNum.Text) == false 
                    && string.IsNullOrEmpty(textBoxCompany_id.Text) == false)
                {
                    string sqlcommand = "INSERT INTO Developer (Surname, Name, Midde_name, Coding, Speak_eng, Know_Scrum, email," +
                        "phone_number, company_id) VALUES" +
                        "(@surname, @name, @middle_name, @coding, @speak_eng, @know_scrum, @email, @phone_number, @company_id)";
                    SqlCommand command = sql_connection.CreateCommand();
                    command.CommandText = sqlcommand;
                    command.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@middle_name", textBoxMiddleName.Text);
                    command.Parameters.AddWithValue("@coding", textBoxCoding.Text);
                    command.Parameters.AddWithValue("@speak_eng", textBoxSpeakEng.Text);
                    command.Parameters.AddWithValue("@know_scrum", textBoxKnowScrum.Text);
                    command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    command.Parameters.AddWithValue("@phone_number", textBoxPhoneNum.Text);
                    command.Parameters.AddWithValue("@company_id", textBoxCompany_id.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Succesfully inserted", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    dataGridViewChangingdata.DataSource = FillDataGridView("select * FROM Developer");
                }
                else
                {
                    MessageBox.Show("Обязательно заполните все поля",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBoxIdDev.Enabled = true;
            }
            if (radioButtonUpdateDev.Checked == true)
            {
                if (string.IsNullOrEmpty(textBoxKnowScrum.Text) == false)
                {
                    string sqlcommand = "UPDATE Developer SET Know_Scrum = @state WHERE company_id = @Number_cmp_id";
                    SqlCommand command = sql_connection.CreateCommand();
                    command.CommandText = sqlcommand;
                    command.Parameters.AddWithValue("@state", textBoxKnowScrum.Text);
                    command.Parameters.AddWithValue("@Number_cmp_id", textBoxCompany_id.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Succesfully updated", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    dataGridViewChangingdata.DataSource = FillDataGridView("select * FROM Developer");
                }
                else
                {
                    MessageBox.Show("Обязательно заполните все поля",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                textBoxIdDev.Enabled = true;
            }
            if (radioButtonDeleteDev.Checked == true)
            {
                    string sqlcommand = "DELETE FROM Developer WHERE Id = @id_dev";
                    SqlCommand command = sql_connection.CreateCommand();
                    command.CommandText = sqlcommand;
                    command.Parameters.AddWithValue("@id_dev", textBoxIdDev.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Succesfully deleted", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    dataGridViewChangingdata.DataSource = FillDataGridView("select * FROM Developer");
            }
        }
    }
}
