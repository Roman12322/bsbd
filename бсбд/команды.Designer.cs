namespace бсбд
{
    partial class teams
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
            System.Windows.Forms.Label developer_idLabel;
            System.Windows.Forms.Label prototype_idLabel;
            System.Windows.Forms.Label developer_nameLabel;
            System.Windows.Forms.Label prototype_infoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teams));
            this.teamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmnoeObespechenieDataset = new бсбд.programmnoeObespechenieDataset();
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
            this.teamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.developer_idTextBox = new System.Windows.Forms.TextBox();
            this.prototype_idTextBox = new System.Windows.Forms.TextBox();
            this.teamTableAdapter = new бсбд.programmnoeObespechenieDatasetTableAdapters.TeamTableAdapter();
            this.tableAdapterManager = new бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new бсбд.programmnoeObespechenieDatasetTableAdapters.DeveloperTableAdapter();
            this.developer_nameLabel1 = new System.Windows.Forms.Label();
            this.prototype_infoLabel1 = new System.Windows.Forms.Label();
            this.teamDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            developer_idLabel = new System.Windows.Forms.Label();
            prototype_idLabel = new System.Windows.Forms.Label();
            developer_nameLabel = new System.Windows.Forms.Label();
            prototype_infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).BeginInit();
            this.teamBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 69);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // developer_idLabel
            // 
            developer_idLabel.AutoSize = true;
            developer_idLabel.Location = new System.Drawing.Point(12, 101);
            developer_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            developer_idLabel.Name = "developer_idLabel";
            developer_idLabel.Size = new System.Drawing.Size(86, 16);
            developer_idLabel.TabIndex = 3;
            developer_idLabel.Text = "developer id:";
            // 
            // prototype_idLabel
            // 
            prototype_idLabel.AutoSize = true;
            prototype_idLabel.Location = new System.Drawing.Point(12, 133);
            prototype_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prototype_idLabel.Name = "prototype_idLabel";
            prototype_idLabel.Size = new System.Drawing.Size(81, 16);
            prototype_idLabel.TabIndex = 5;
            prototype_idLabel.Text = "prototype id:";
            // 
            // developer_nameLabel
            // 
            developer_nameLabel.AutoSize = true;
            developer_nameLabel.Location = new System.Drawing.Point(16, 186);
            developer_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            developer_nameLabel.Name = "developer_nameLabel";
            developer_nameLabel.Size = new System.Drawing.Size(96, 16);
            developer_nameLabel.TabIndex = 9;
            developer_nameLabel.Text = "developer info:";
            // 
            // prototype_infoLabel
            // 
            prototype_infoLabel.AutoSize = true;
            prototype_infoLabel.Location = new System.Drawing.Point(16, 218);
            prototype_infoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prototype_infoLabel.Name = "prototype_infoLabel";
            prototype_infoLabel.Size = new System.Drawing.Size(91, 16);
            prototype_infoLabel.TabIndex = 10;
            prototype_infoLabel.Text = "prototype info:";
            // 
            // teamBindingNavigator
            // 
            this.teamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamBindingNavigator.BindingSource = this.teamBindingSource;
            this.teamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.teamBindingNavigatorSaveItem});
            this.teamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamBindingNavigator.Name = "teamBindingNavigator";
            this.teamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamBindingNavigator.Size = new System.Drawing.Size(919, 31);
            this.teamBindingNavigator.TabIndex = 0;
            this.teamBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.programmnoeObespechenieDataset;
            // 
            // programmnoeObespechenieDataset
            // 
            this.programmnoeObespechenieDataset.DataSetName = "ProgrammnoeObespechenieDataset";
            this.programmnoeObespechenieDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // teamBindingNavigatorSaveItem
            // 
            this.teamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamBindingNavigatorSaveItem.Image")));
            this.teamBindingNavigatorSaveItem.Name = "teamBindingNavigatorSaveItem";
            this.teamBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.teamBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.teamBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(111, 65);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(263, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // developer_idTextBox
            // 
            this.developer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "developer_id", true));
            this.developer_idTextBox.Location = new System.Drawing.Point(111, 97);
            this.developer_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.developer_idTextBox.Name = "developer_idTextBox";
            this.developer_idTextBox.Size = new System.Drawing.Size(263, 22);
            this.developer_idTextBox.TabIndex = 4;
            // 
            // prototype_idTextBox
            // 
            this.prototype_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "prototype_id", true));
            this.prototype_idTextBox.Location = new System.Drawing.Point(111, 129);
            this.prototype_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prototype_idTextBox.Name = "prototype_idTextBox";
            this.prototype_idTextBox.Size = new System.Drawing.Size(263, 22);
            this.prototype_idTextBox.TabIndex = 6;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.PrototypeTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.Technical_requirementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // developerBindingSource
            // 
            this.developerBindingSource.DataMember = "Developer";
            this.developerBindingSource.DataSource = this.programmnoeObespechenieDataset;
            // 
            // developerTableAdapter
            // 
            this.developerTableAdapter.ClearBeforeFill = true;
            // 
            // developer_nameLabel1
            // 
            this.developer_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "developer_name", true));
            this.developer_nameLabel1.Location = new System.Drawing.Point(127, 186);
            this.developer_nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.developer_nameLabel1.Name = "developer_nameLabel1";
            this.developer_nameLabel1.Size = new System.Drawing.Size(248, 28);
            this.developer_nameLabel1.TabIndex = 10;
            this.developer_nameLabel1.Text = "label1";
            // 
            // prototype_infoLabel1
            // 
            this.prototype_infoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "prototype_info", true));
            this.prototype_infoLabel1.Location = new System.Drawing.Point(127, 218);
            this.prototype_infoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prototype_infoLabel1.Name = "prototype_infoLabel1";
            this.prototype_infoLabel1.Size = new System.Drawing.Size(248, 28);
            this.prototype_infoLabel1.TabIndex = 11;
            this.prototype_infoLabel1.Text = "label1";
            // 
            // teamDataGridView
            // 
            this.teamDataGridView.AutoGenerateColumns = false;
            this.teamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.teamDataGridView.DataSource = this.teamBindingSource;
            this.teamDataGridView.Location = new System.Drawing.Point(17, 279);
            this.teamDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamDataGridView.Name = "teamDataGridView";
            this.teamDataGridView.RowHeadersWidth = 51;
            this.teamDataGridView.Size = new System.Drawing.Size(885, 271);
            this.teamDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "developer_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "developer_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prototype_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "prototype_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 612);
            this.Controls.Add(this.teamDataGridView);
            this.Controls.Add(prototype_infoLabel);
            this.Controls.Add(this.prototype_infoLabel1);
            this.Controls.Add(developer_nameLabel);
            this.Controls.Add(this.developer_nameLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(developer_idLabel);
            this.Controls.Add(this.developer_idTextBox);
            this.Controls.Add(prototype_idLabel);
            this.Controls.Add(this.prototype_idTextBox);
            this.Controls.Add(this.teamBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "teams";
            this.Text = "команды";
            this.Load += new System.EventHandler(this.teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).EndInit();
            this.teamBindingNavigator.ResumeLayout(false);
            this.teamBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private programmnoeObespechenieDataset programmnoeObespechenieDataset;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private programmnoeObespechenieDatasetTableAdapters.TeamTableAdapter teamTableAdapter;
        private programmnoeObespechenieDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton teamBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox developer_idTextBox;
        private System.Windows.Forms.TextBox prototype_idTextBox;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private programmnoeObespechenieDatasetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private System.Windows.Forms.Label developer_nameLabel1;
        private System.Windows.Forms.Label prototype_infoLabel1;
        private System.Windows.Forms.DataGridView teamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}