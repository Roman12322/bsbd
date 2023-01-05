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
    public partial class Технические_задания_View : Form
    {
        private readonly checkuser _user;
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public Технические_задания_View(checkuser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void technical_requirementsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.technical_requirementsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Технические_задания_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Technical_requirements". При необходимости она может быть перемещена или удалена.
            this.technical_requirementsTableAdapter.FillByCUSTOMER_ID(this.programmnoeObespechenieDataset.Technical_requirements, _user.id_user);

        }
    }
}
