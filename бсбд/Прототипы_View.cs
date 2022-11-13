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
    public partial class Прототипы_View : Form
    {
        private static Прототипы_View Прототипы_View_form;
        public static Прототипы_View Прототипы_View_f
        {
            get
            {
                if (Прототипы_View_form == null || Прототипы_View_form.IsDisposed) Прототипы_View_form = new Прототипы_View();
                return Прототипы_View_form;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public Прототипы_View()
        {
            InitializeComponent();
        }

        private void prototypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prototypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Прототипы_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Prototype". При необходимости она может быть перемещена или удалена.
            this.prototypeTableAdapter.Fill(this.programmnoeObespechenieDataset.Prototype);

        }
    }
}
