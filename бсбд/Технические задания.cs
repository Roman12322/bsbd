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
    public partial class Technical_requirements : Form
    {
        private static Technical_requirements Technical_requirements_form;
        public static Technical_requirements Technical_requirements_f
        {
            get
            {
                if (Technical_requirements_form == null || Technical_requirements_form.IsDisposed) Technical_requirements_form = new Technical_requirements();
                return Technical_requirements_form;
            }
        }
        public Technical_requirements()
        {
            InitializeComponent();
        }

        private void technical_requirementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technical_requirementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Technical_requirements_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Technical_requirements". При необходимости она может быть перемещена или удалена.
            this.technical_requirementsTableAdapter.Fill(this.programmnoeObespechenieDataset.Technical_requirements);

        }
    }
}
