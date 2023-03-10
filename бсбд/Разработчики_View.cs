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
    public partial class Разработчики_View : Form
    {
        private readonly checkuser _user;
        public void ShowForm()
        {
            Show();
            Activate();
        }
        public Разработчики_View(checkuser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void developerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.developerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.programmnoeObespechenieDataset);

        }

        private void Разработчики_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "programmnoeObespechenieDataset.Developer". При необходимости она может быть перемещена или удалена.
            this.developerTableAdapter.FillByDEV_ID(this.programmnoeObespechenieDataset.Developer, _user.id_user);

        }
        string GetSelectedFieldName()
        {
            return
           developerDataGridView.Columns[developerDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
               developerBindingSource.Find(GetSelectedFieldName(),
               toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                developerBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких разработчиков нет", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                developerBindingSource.Position = 0;
            }

        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        developerBindingSource.Filter =
                       GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                developerBindingSource.Filter = "";

            if (developerBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                developerBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
 }
