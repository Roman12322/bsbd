namespace бсбд
{
    partial class Technical_requirements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technical_requirements));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label goalLabel;
            System.Windows.Forms.Label tasksLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label finish_dateLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label company_idLabel;
            this.programmnoeObespechenieDataset = new бсбд.programmnoeObespechenieDataset();
            this.technical_requirementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technical_requirementsTableAdapter = new бсбд.programmnoeObespechenieDatasetTableAdapters.Technical_requirementsTableAdapter();
            this.tableAdapterManager = new бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager();
            this.technical_requirementsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.technical_requirementsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.goalTextBox = new System.Windows.Forms.TextBox();
            this.tasksTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finish_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.company_idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            goalLabel = new System.Windows.Forms.Label();
            tasksLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            finish_dateLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            company_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingNavigator)).BeginInit();
            this.technical_requirementsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // programmnoeObespechenieDataset
            // 
            this.programmnoeObespechenieDataset.DataSetName = "ProgrammnoeObespechenieDataset";
            this.programmnoeObespechenieDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DeveloperTableAdapter = null;
            this.tableAdapterManager.PrototypeTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = null;
            this.tableAdapterManager.Technical_requirementsTableAdapter = this.technical_requirementsTableAdapter;
            this.tableAdapterManager.UpdateOrder = бсбд.programmnoeObespechenieDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // technical_requirementsBindingNavigator
            // 
            this.technical_requirementsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.technical_requirementsBindingNavigator.BindingSource = this.technical_requirementsBindingSource;
            this.technical_requirementsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.technical_requirementsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.technical_requirementsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.technical_requirementsBindingNavigatorSaveItem});
            this.technical_requirementsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.technical_requirementsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.technical_requirementsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.technical_requirementsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.technical_requirementsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.technical_requirementsBindingNavigator.Name = "technical_requirementsBindingNavigator";
            this.technical_requirementsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.technical_requirementsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.technical_requirementsBindingNavigator.TabIndex = 0;
            this.technical_requirementsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // technical_requirementsBindingNavigatorSaveItem
            // 
            this.technical_requirementsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.technical_requirementsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("technical_requirementsBindingNavigatorSaveItem.Image")));
            this.technical_requirementsBindingNavigatorSaveItem.Name = "technical_requirementsBindingNavigatorSaveItem";
            this.technical_requirementsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.technical_requirementsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.technical_requirementsBindingNavigatorSaveItem.Click += new System.EventHandler(this.technical_requirementsBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 61);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(84, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(263, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // goalLabel
            // 
            goalLabel.AutoSize = true;
            goalLabel.Location = new System.Drawing.Point(14, 87);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new System.Drawing.Size(32, 13);
            goalLabel.TabIndex = 3;
            goalLabel.Text = "Goal:";
            // 
            // goalTextBox
            // 
            this.goalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "Goal", true));
            this.goalTextBox.Location = new System.Drawing.Point(84, 84);
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(263, 20);
            this.goalTextBox.TabIndex = 4;
            // 
            // tasksLabel
            // 
            tasksLabel.AutoSize = true;
            tasksLabel.Location = new System.Drawing.Point(14, 113);
            tasksLabel.Name = "tasksLabel";
            tasksLabel.Size = new System.Drawing.Size(39, 13);
            tasksLabel.TabIndex = 5;
            tasksLabel.Text = "Tasks:";
            // 
            // tasksTextBox
            // 
            this.tasksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "Tasks", true));
            this.tasksTextBox.Location = new System.Drawing.Point(84, 110);
            this.tasksTextBox.Name = "tasksTextBox";
            this.tasksTextBox.Size = new System.Drawing.Size(263, 20);
            this.tasksTextBox.TabIndex = 6;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(14, 139);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 7;
            costLabel.Text = "Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "Cost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.costTextBox.Location = new System.Drawing.Point(84, 136);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(263, 20);
            this.costTextBox.TabIndex = 8;
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Location = new System.Drawing.Point(14, 166);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(56, 13);
            start_dateLabel.TabIndex = 9;
            start_dateLabel.Text = "Start date:";
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.technical_requirementsBindingSource, "Start_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(84, 162);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.start_dateDateTimePicker.TabIndex = 10;
            // 
            // finish_dateLabel
            // 
            finish_dateLabel.AutoSize = true;
            finish_dateLabel.Location = new System.Drawing.Point(14, 192);
            finish_dateLabel.Name = "finish_dateLabel";
            finish_dateLabel.Size = new System.Drawing.Size(61, 13);
            finish_dateLabel.TabIndex = 11;
            finish_dateLabel.Text = "Finish date:";
            // 
            // finish_dateDateTimePicker
            // 
            this.finish_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.technical_requirementsBindingSource, "Finish_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.finish_dateDateTimePicker.Location = new System.Drawing.Point(84, 188);
            this.finish_dateDateTimePicker.Name = "finish_dateDateTimePicker";
            this.finish_dateDateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.finish_dateDateTimePicker.TabIndex = 12;
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(14, 217);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 13;
            customer_idLabel.Text = "customer id:";
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(84, 214);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(263, 20);
            this.customer_idTextBox.TabIndex = 14;
            // 
            // company_idLabel
            // 
            company_idLabel.AutoSize = true;
            company_idLabel.Location = new System.Drawing.Point(14, 243);
            company_idLabel.Name = "company_idLabel";
            company_idLabel.Size = new System.Drawing.Size(64, 13);
            company_idLabel.TabIndex = 15;
            company_idLabel.Text = "company id:";
            // 
            // company_idTextBox
            // 
            this.company_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.technical_requirementsBindingSource, "company_id", true));
            this.company_idTextBox.Location = new System.Drawing.Point(84, 240);
            this.company_idTextBox.Name = "company_idTextBox";
            this.company_idTextBox.Size = new System.Drawing.Size(263, 20);
            this.company_idTextBox.TabIndex = 16;
            // 
            // Technical_requirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(goalLabel);
            this.Controls.Add(this.goalTextBox);
            this.Controls.Add(tasksLabel);
            this.Controls.Add(this.tasksTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(finish_dateLabel);
            this.Controls.Add(this.finish_dateDateTimePicker);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(company_idLabel);
            this.Controls.Add(this.company_idTextBox);
            this.Controls.Add(this.technical_requirementsBindingNavigator);
            this.Name = "Technical_requirements";
            this.Text = "Технические_задания";
            this.Load += new System.EventHandler(this.Technical_requirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technical_requirementsBindingNavigator)).EndInit();
            this.technical_requirementsBindingNavigator.ResumeLayout(false);
            this.technical_requirementsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private programmnoeObespechenieDataset programmnoeObespechenieDataset;
        private System.Windows.Forms.BindingSource technical_requirementsBindingSource;
        private programmnoeObespechenieDatasetTableAdapters.Technical_requirementsTableAdapter technical_requirementsTableAdapter;
        private programmnoeObespechenieDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator technical_requirementsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton technical_requirementsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.TextBox tasksTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker finish_dateDateTimePicker;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox company_idTextBox;
    }
}