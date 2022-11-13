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
    public partial class Prototypes : Form
    {
        private static Prototypes Prototypes_form;
        public static Prototypes Prototypes_f
        {
            get
            {
                if (Prototypes_form == null || Prototypes_form.IsDisposed) Prototypes_form = new Prototypes();
                return Prototypes_form;
            }
        }
        public Prototypes()
        {
            InitializeComponent();
        }

        private void prototypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prototypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Prototypes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Technical_requirements". При необходимости она может быть перемещена или удалена.
            this.technical_requirementsTableAdapter.Fill(this.programmnoeObespechenieDataset.Technical_requirements);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Prototype". При необходимости она может быть перемещена или удалена.
            this.prototypeTableAdapter.Fill(this.programmnoeObespechenieDataset.Prototype);

        }
    }
}
