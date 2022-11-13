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
    public partial class Customers : Form
    {
        private static Customers Customers_form;
        public static Customers Customers_f
        {
            get
            {
                if (Customers_form == null || Customers_form.IsDisposed) Customers_form = new Customers();
                return Customers_form;
            }
        }
        public Customers()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Покупатели_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.programmnoeObespechenieDataset.Customer);

        }
    }
}
