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
        private readonly checkuser _user;
        public Prototypes(checkuser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void prototypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prototypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }
        public void ShowForm()
        {
            Show();
            Activate();
        }
        private void Prototypes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Technical_requirements". При необходимости она может быть перемещена или удалена.
            this.technical_requirementsTableAdapter.Fill(this.programmnoeObespechenieDataset.Technical_requirements);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Prototype". При необходимости она может быть перемещена или удалена.
            this.prototypeTableAdapter.FillByCUST_ID(this.programmnoeObespechenieDataset.Prototype, _user.id_user);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
