namespace бсбд
{
    partial class Developers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Developers));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label midde_nameLabel;
            System.Windows.Forms.Label codingLabel;
            System.Windows.Forms.Label speak_engLabel;
            System.Windows.Forms.Label know_ScrumLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label company_idLabel;
            this.programmnoeObespechenieDataset = new бсбд.ProgrammnoeObespechenieDataset();
            this.developerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.developerTableAdapter = new бсбд.ProgrammnoeObespechenieDatasetTableAdapters.DeveloperTableAdapter();
            this.tableAdapterManager = new бсбд.ProgrammnoeObespechenieDatasetTableAdapters.TableAdapterManager();
            this.developerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.developerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.midde_nameTextBox = new System.Windows.Forms.TextBox();
            this.codingComboBox = new System.Windows.Forms.ComboBox();
            this.speak_engComboBox = new System.Windows.Forms.ComboBox();
            this.know_ScrumComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.company_idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            midde_nameLabel = new System.Windows.Forms.Label();
            codingLabel = new System.Windows.Forms.Label();
            speak_engLabel = new System.Windows.Forms.Label();
            know_ScrumLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            company_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingNavigator)).BeginInit();
            this.developerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // programmnoeObespechenieDataset
            // 
            this.programmnoeObespechenieDataset.DataSetName = "ProgrammnoeObespechenieDataset";
            this.programmnoeObespechenieDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DeveloperTableAdapter = this.developerTableAdapter;
            this.tableAdapterManager.PrototypeTableAdapter = null;
            this.tableAdapterManager.TeamTableAdapter = null;
            this.tableAdapterManager.Technical_requirementsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = бсбд.ProgrammnoeObespechenieDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // developerBindingNavigator
            // 
            this.developerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.developerBindingNavigator.BindingSource = this.developerBindingSource;
            this.developerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.developerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.developerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.developerBindingNavigatorSaveItem});
            this.developerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.developerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.developerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.developerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.developerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.developerBindingNavigator.Name = "developerBindingNavigator";
            this.developerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.developerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.developerBindingNavigator.TabIndex = 0;
            this.developerBindingNavigator.Text = "bindingNavigator1";
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
            // developerBindingNavigatorSaveItem
            // 
            this.developerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.developerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("developerBindingNavigatorSaveItem.Image")));
            this.developerBindingNavigatorSaveItem.Name = "developerBindingNavigatorSaveItem";
            this.developerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.developerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.developerBindingNavigatorSaveItem.Click += new System.EventHandler(this.developerBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(14, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(98, 49);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(194, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(14, 78);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(98, 75);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(194, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(14, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(98, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // midde_nameLabel
            // 
            midde_nameLabel.AutoSize = true;
            midde_nameLabel.Location = new System.Drawing.Point(14, 130);
            midde_nameLabel.Name = "midde_nameLabel";
            midde_nameLabel.Size = new System.Drawing.Size(68, 13);
            midde_nameLabel.TabIndex = 7;
            midde_nameLabel.Text = "Midde name:";
            // 
            // midde_nameTextBox
            // 
            this.midde_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Midde_name", true));
            this.midde_nameTextBox.Location = new System.Drawing.Point(98, 127);
            this.midde_nameTextBox.Name = "midde_nameTextBox";
            this.midde_nameTextBox.Size = new System.Drawing.Size(194, 20);
            this.midde_nameTextBox.TabIndex = 8;
            // 
            // codingLabel
            // 
            codingLabel.AutoSize = true;
            codingLabel.Location = new System.Drawing.Point(14, 156);
            codingLabel.Name = "codingLabel";
            codingLabel.Size = new System.Drawing.Size(43, 13);
            codingLabel.TabIndex = 9;
            codingLabel.Text = "Coding:";
            // 
            // codingComboBox
            // 
            this.codingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Coding", true));
            this.codingComboBox.FormattingEnabled = true;
            this.codingComboBox.Items.AddRange(new object[] {
            "Python",
            "C#, Python",
            "JavaScript, HTML, CSS"});
            this.codingComboBox.Location = new System.Drawing.Point(98, 153);
            this.codingComboBox.Name = "codingComboBox";
            this.codingComboBox.Size = new System.Drawing.Size(194, 21);
            this.codingComboBox.TabIndex = 10;
            // 
            // speak_engLabel
            // 
            speak_engLabel.AutoSize = true;
            speak_engLabel.Location = new System.Drawing.Point(14, 183);
            speak_engLabel.Name = "speak_engLabel";
            speak_engLabel.Size = new System.Drawing.Size(62, 13);
            speak_engLabel.TabIndex = 11;
            speak_engLabel.Text = "Speak eng:";
            // 
            // speak_engComboBox
            // 
            this.speak_engComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Speak_eng", true));
            this.speak_engComboBox.FormattingEnabled = true;
            this.speak_engComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.speak_engComboBox.Location = new System.Drawing.Point(98, 180);
            this.speak_engComboBox.Name = "speak_engComboBox";
            this.speak_engComboBox.Size = new System.Drawing.Size(194, 21);
            this.speak_engComboBox.TabIndex = 12;
            // 
            // know_ScrumLabel
            // 
            know_ScrumLabel.AutoSize = true;
            know_ScrumLabel.Location = new System.Drawing.Point(14, 210);
            know_ScrumLabel.Name = "know_ScrumLabel";
            know_ScrumLabel.Size = new System.Drawing.Size(70, 13);
            know_ScrumLabel.TabIndex = 13;
            know_ScrumLabel.Text = "Know Scrum:";
            // 
            // know_ScrumComboBox
            // 
            this.know_ScrumComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "Know_Scrum", true));
            this.know_ScrumComboBox.FormattingEnabled = true;
            this.know_ScrumComboBox.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.know_ScrumComboBox.Location = new System.Drawing.Point(98, 207);
            this.know_ScrumComboBox.Name = "know_ScrumComboBox";
            this.know_ScrumComboBox.Size = new System.Drawing.Size(194, 21);
            this.know_ScrumComboBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(14, 237);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(98, 234);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 20);
            this.emailTextBox.TabIndex = 16;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(14, 263);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(78, 13);
            phone_numberLabel.TabIndex = 17;
            phone_numberLabel.Text = "phone number:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(98, 260);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(194, 20);
            this.phone_numberTextBox.TabIndex = 18;
            // 
            // company_idLabel
            // 
            company_idLabel.AutoSize = true;
            company_idLabel.Location = new System.Drawing.Point(14, 289);
            company_idLabel.Name = "company_idLabel";
            company_idLabel.Size = new System.Drawing.Size(64, 13);
            company_idLabel.TabIndex = 19;
            company_idLabel.Text = "company id:";
            // 
            // company_idTextBox
            // 
            this.company_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.developerBindingSource, "company_id", true));
            this.company_idTextBox.Location = new System.Drawing.Point(98, 286);
            this.company_idTextBox.Name = "company_idTextBox";
            this.company_idTextBox.Size = new System.Drawing.Size(194, 20);
            this.company_idTextBox.TabIndex = 20;
            // 
            // Developers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(midde_nameLabel);
            this.Controls.Add(this.midde_nameTextBox);
            this.Controls.Add(codingLabel);
            this.Controls.Add(this.codingComboBox);
            this.Controls.Add(speak_engLabel);
            this.Controls.Add(this.speak_engComboBox);
            this.Controls.Add(know_ScrumLabel);
            this.Controls.Add(this.know_ScrumComboBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(company_idLabel);
            this.Controls.Add(this.company_idTextBox);
            this.Controls.Add(this.developerBindingNavigator);
            this.Name = "Developers";
            this.Text = "Разработчики";
            this.Load += new System.EventHandler(this.Developers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programmnoeObespechenieDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.developerBindingNavigator)).EndInit();
            this.developerBindingNavigator.ResumeLayout(false);
            this.developerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgrammnoeObespechenieDataset programmnoeObespechenieDataset;
        private System.Windows.Forms.BindingSource developerBindingSource;
        private ProgrammnoeObespechenieDatasetTableAdapters.DeveloperTableAdapter developerTableAdapter;
        private ProgrammnoeObespechenieDatasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator developerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton developerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox midde_nameTextBox;
        private System.Windows.Forms.ComboBox codingComboBox;
        private System.Windows.Forms.ComboBox speak_engComboBox;
        private System.Windows.Forms.ComboBox know_ScrumComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox company_idTextBox;
    }
}