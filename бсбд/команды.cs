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
    public partial class teams : Form
    {
        private static teams teams_form;
        public static teams teams_f
        {
            get
            {
                if (teams_form == null || teams_form.IsDisposed) teams_form = new teams();
                return teams_form;
            }
        }
        public teams()
        {
            InitializeComponent();
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void teams_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Developer". При необходимости она может быть перемещена или удалена.
            this.developerTableAdapter.Fill(this.programmnoeObespechenieDataset.Developer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.programmnoeObespechenieDataset.Team);

        }

    }
}
