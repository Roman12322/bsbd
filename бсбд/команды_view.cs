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
    public partial class команды_view : Form
    {
        private static команды_view команды_view_form;
        public static команды_view команды_view_f
        {
            get
            {
                if (команды_view_form == null || команды_view_form.IsDisposed) команды_view_form = new команды_view();
                return команды_view_form;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public команды_view()
        {
            InitializeComponent();
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void команды_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Team". При необходимости она может быть перемещена или удалена.
            this.teamTableAdapter.Fill(this.programmnoeObespechenieDataset.Team);

        }
    }
}
