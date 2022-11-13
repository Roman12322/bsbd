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
    public partial class MainForm : Form
    {
        private SqlConnection sql_connection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql_connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database_1"].ConnectionString);
            sql_connection.Open();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Муромцев Роман Максимович, 740-1, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
           "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
           DialogResult.Yes;
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C) ТУСУР, КИБЭВС, Муромцев Роман Максимович, 740-1, 2022", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Companies.Companies_f.Show();
        }

        private void разработчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developers.Developers_f.Show();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers.Customers_f.Show();
        }

        private void прототипыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prototypes.Prototypes_f.Show();
        }

        private void техническиеЗаданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Technical_requirements.Technical_requirements_f.Show();
        }

        private void командыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teams.teams_f.Show();
        }

        private void компанииViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Компании__View.Компании__View_f.ShowForm();
        }

        private void разработчикиViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Разработчики_View.Разработчики_View_f.ShowForm();
        }

        private void покупателиViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Покупатели_View.Покупатели_View_f.ShowForm();
        }

        private void прототипыViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Прототипы_View.Прототипы_View_f.ShowForm();
        }

        private void техническиезаданияViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Технические_задания_View.Технические_задания_View_f.ShowForm();
        }

        private void командыViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            команды_view.команды_view_f.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.FormSQL_f.Show();
        }
    }
}
