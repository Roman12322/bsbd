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
    public partial class Компании__View : Form
    {
        private static Компании__View Компании__View_form;
        public static Компании__View Компании__View_f
        {
            get
            {
                if (Компании__View_form == null || Компании__View_form.IsDisposed) Компании__View_form = new Компании__View();
                return Компании__View_form;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        public Компании__View()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Компании__View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.programmnoeObespechenieDataset.Company);

        }
    }
}
