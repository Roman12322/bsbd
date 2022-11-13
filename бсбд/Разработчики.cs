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
    public partial class Developers : Form
    {
        private static Developers Developers_form;
        public static Developers Developers_f
        {
            get
            {
                if (Developers_form == null || Developers_form.IsDisposed) Developers_form = new Developers();
                return Developers_form;
            }
        }
        public Developers()
        {
            InitializeComponent();
        }

        private void developerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.developerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Developers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Developer". При необходимости она может быть перемещена или удалена.
            this.developerTableAdapter.Fill(this.programmnoeObespechenieDataset.Developer);

        }
    }
}
