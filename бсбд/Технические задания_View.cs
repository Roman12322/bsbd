using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бсбд
{
    public partial class Технические_задания_View : Form
    {
        private static Технические_задания_View Технические_задания_View_form;
        public static Технические_задания_View Технические_задания_View_f
        {
            get
            {
                if (Технические_задания_View_form == null || Технические_задания_View_form.IsDisposed) Технические_задания_View_form = new Технические_задания_View();
                return Технические_задания_View_form;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public Технические_задания_View()
        {
            InitializeComponent();
        }

        private void technical_requirementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technical_requirementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Технические_задания_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Technical_requirements". При необходимости она может быть перемещена или удалена.
            this.technical_requirementsTableAdapter.Fill(this.programmnoeObespechenieDataset.Technical_requirements);

        }
    }
}
