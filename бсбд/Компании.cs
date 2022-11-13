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
    public partial class Companies : Form
    {
        private static Companies Companies_form;
        public static Companies Companies_f
        {
            get
            {
                if (Companies_form == null || Companies_form.IsDisposed) Companies_form = new Companies();
                return Companies_form;
            }
        }
        public Companies()
        {
            InitializeComponent();
        }

        private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Companies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.programmnoeObespechenieDataset.Company);

        }
    }
}
