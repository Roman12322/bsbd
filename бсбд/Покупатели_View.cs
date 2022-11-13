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
    public partial class Покупатели_View : Form
    {
        private static Покупатели_View Покупатели_View_form;
        public static Покупатели_View Покупатели_View_f
        {
            get
            {
                if (Покупатели_View_form == null || Покупатели_View_form.IsDisposed) Покупатели_View_form = new Покупатели_View();
                return Покупатели_View_form;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public Покупатели_View()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Покупатели_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.programmnoeObespechenieDataset.Customer);

        }
    }
}
