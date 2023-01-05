namespace бсбд
{
    partial class Prototypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label versionLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label technical_requirements_idLabel;
            System.Windows.Forms.Label company_idLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label prototype_infoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prototypes));
            this.programmnoeObespechenieDataset = new бсбд.programmnoeObespechenieDataset();
            this.prototypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prototypeTableAdapter = new бсбд.programmnoeObespechenieDatasetTableAdapters.PrototypeTableAdapter();
            this.tableAdapterManager = new бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager();
            this.prototypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prototypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.technical_requirements_idTextBox = new System.Windows.Forms.TextBox();
            this.company_idTextBox = new System.Windows.Forms.TextBox();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.technical_requirementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technical_requirementsTableAdapter = new бсбд.programmnoeObespechenieDatasetTableAdapters.Technical_requirementsTableAdapter();
            this.prototype_infoLabel1 = new System.Windows.Forms.Label();
            this.prototypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            technical_requirements_idLabel = new System.Windows.Forms.Label();
            company_idLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            prototype_infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeBindingNavigator)).BeginInit();
            this.prototypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 52);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(13, 84);
            versionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(56, 16);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "Version:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(13, 116);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // technical_requirements_idLabel
            // 
            technical_requirements_idLabel.AutoSize = true;
            technical_requirements_idLabel.Location = new System.Drawing.Point(13, 149);
            technical_requirements_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            technical_requirements_idLabel.Name = "technical_requirements_idLabel";
            technical_requirements_idLabel.Size = new System.Drawing.Size(158, 16);
            technical_requirements_idLabel.TabIndex = 7;
            technical_requirements_idLabel.Text = "technical requirements id:";
            // 
            // company_idLabel
            // 
            company_idLabel.AutoSize = true;
            company_idLabel.Location = new System.Drawing.Point(13, 181);
            company_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            company_idLabel.Name = "company_idLabel";
            company_idLabel.Size = new System.Drawing.Size(80, 16);
            company_idLabel.TabIndex = 9;
            company_idLabel.Text = "company id:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.Location = new System.Drawing.Point(15, 228);
            costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(51, 20);
            costLabel.TabIndex = 11;
            costLabel.Text = "cost:";
            // 
            // prototype_infoLabel
            // 
            prototype_infoLabel.AutoSize = true;
            prototype_infoLabel.Location = new System.Drawing.Point(484, 50);
            prototype_infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prototype_infoLabel.Name = "prototype_infoLabel";
            prototype_infoLabel.Size = new System.Drawing.Size(91, 16);
            prototype_infoLabel.TabIndex = 14;
            prototype_infoLabel.Text = "prototype info:";
            // 
            // programmnoeObespechenieDataset
            // 
            this.programmnoeObespechenieDataset.DataSetName = "ProgrammnoeObespechenieDataset";
            this.programmnoeObespechenieDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prototypeBindingSource
            // 
            this.prototypeBindingSource.DataMember = "Prototype";
            this.prototypeBindingSource.DataSource = this.programmnoeObespechenieDataset;
            // 
            // prototypeTableAdapter
            // 
            this.prototypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.PrototypeTableAdapter = this.prototypeTableAdapter;
            this.tableAdapterManager.TeamTableAdapter = null;
            this.tableAdapterManager.Technical_requirementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // prototypeBindingNavigator
            // 
            this.prototypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prototypeBindingNavigator.BindingSource = this.prototypeBindingSource;
            this.prototypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prototypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prototypeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prototypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.prototypeBindingNavigatorSaveItem});
            this.prototypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prototypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prototypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prototypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prototypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prototypeBindingNavigator.Name = "prototypeBindingNavigator";
            this.prototypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prototypeBindingNavigator.Size = new System.Drawing.Size(1611, 27);
            this.prototypeBindingNavigator.TabIndex = 0;
            this.prototypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // prototypeBindingNavigatorSaveItem
            // 
            this.prototypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prototypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prototypeBindingNavigatorSaveItem.Image")));
            this.prototypeBindingNavigatorSaveItem.Name = "prototypeBindingNavigatorSaveItem";
            this.prototypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.prototypeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.prototypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.prototypeBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(191, 48);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(160, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // versionTextBox
            // 
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "Version", true));
            this.versionTextBox.Location = new System.Drawing.Point(191, 80);
            this.versionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(160, 22);
            this.versionTextBox.TabIndex = 4;
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Accepted",
            "Rejected",
            "In progress"});
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "In progress",
            "Accepted",
            "Rejected"});
            this.statusComboBox.Location = new System.Drawing.Point(191, 112);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(160, 24);
            this.statusComboBox.TabIndex = 6;
            // 
            // technical_requirements_idTextBox
            // 
            this.technical_requirements_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "technical_requirements_id", true));
            this.technical_requirements_idTextBox.Location = new System.Drawing.Point(191, 145);
            this.technical_requirements_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.technical_requirements_idTextBox.Name = "technical_requirements_idTextBox";
            this.technical_requirements_idTextBox.Size = new System.Drawing.Size(160, 22);
            this.technical_requirements_idTextBox.TabIndex = 8;
            // 
            // company_idTextBox
            // 
            this.company_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "company_id", true));
            this.company_idTextBox.Location = new System.Drawing.Point(191, 177);
            this.company_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.company_idTextBox.Name = "company_idTextBox";
            this.company_idTextBox.Size = new System.Drawing.Size(160, 22);
            this.company_idTextBox.TabIndex = 10;
            // 
            // costLabel1
            // 
            this.costLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "cost", true));
            this.costLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel1.Location = new System.Drawing.Point(76, 228);
            this.costLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(276, 28);
            this.costLabel1.TabIndex = 12;
            this.costLabel1.Text = "label1";
            // 
            // technical_requirementsBindingSource
            // 
            this.technical_requirementsBindingSource.DataMember = "Technical_requirements";
            this.technical_requirementsBindingSource.DataSource = this.programmnoeObespechenieDataset;
            // 
            // technical_requirementsTableAdapter
            // 
            this.technical_requirementsTableAdapter.ClearBeforeFill = true;
            // 
            // prototype_infoLabel1
            // 
            this.prototype_infoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prototypeBindingSource, "prototype_info", true));
            this.prototype_infoLabel1.Location = new System.Drawing.Point(591, 50);
            this.prototype_infoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prototype_infoLabel1.Name = "prototype_infoLabel1";
            this.prototype_infoLabel1.Size = new System.Drawing.Size(396, 28);
            this.prototype_infoLabel1.TabIndex = 15;
            this.prototype_infoLabel1.Text = "label1";
            // 
            // prototypeDataGridView
            // 
            this.prototypeDataGridView.AutoGenerateColumns = false;
            this.prototypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prototypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prototypeDataGridView.DataSource = this.prototypeBindingSource;
            this.prototypeDataGridView.Location = new System.Drawing.Point(16, 310);
            this.prototypeDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prototypeDataGridView.Name = "prototypeDataGridView";
            this.prototypeDataGridView.RowHeadersWidth = 51;
            this.prototypeDataGridView.Size = new System.Drawing.Size(1579, 271);
            this.prototypeDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Version";
            this.dataGridViewTextBoxColumn2.HeaderText = "Version";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "technical_requirements_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "technical_requirements_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Prototypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 612);
            this.Controls.Add(this.prototypeDataGridView);
            this.Controls.Add(prototype_infoLabel);
            this.Controls.Add(this.prototype_infoLabel1);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(versionLabel);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(technical_requirements_idLabel);
            this.Controls.Add(this.technical_requirements_idTextBox);
            this.Controls.Add(company_idLabel);
            this.Controls.Add(this.company_idTextBox);
            this.Controls.Add(this.prototypeBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Prototypes";
            this.Text = "Прототипы";
            this.Load += new System.EventHandler(this.Prototypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeBindingNavigator)).EndInit();
            this.prototypeBindingNavigator.ResumeLayout(false);
            this.prototypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private programmnoeObespechenieDataset programmnoeObespechenieDataset;
        private System.Windows.Forms.BindingSource prototypeBindingSource;
        private programmnoeObespechenieDatasetTableAdapters.PrototypeTableAdapter prototypeTableAdapter;
        private programmnoeObespechenieDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prototypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prototypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox technical_requirements_idTextBox;
        private System.Windows.Forms.TextBox company_idTextBox;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.BindingSource technical_requirementsBindingSource;
        private programmnoeObespechenieDatasetTableAdapters.Technical_requirementsTableAdapter technical_requirementsTableAdapter;
        private System.Windows.Forms.Label prototype_infoLabel1;
        private System.Windows.Forms.DataGridView prototypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}