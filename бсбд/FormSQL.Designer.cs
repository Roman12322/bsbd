namespace бсбд
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonCost_with_taxes = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomers = new System.Windows.Forms.RadioButton();
            this.radiobuttonTechReq = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.groupBoxCost_project = new System.Windows.Forms.GroupBox();
            this.radioButtonCheck_project_cost = new System.Windows.Forms.RadioButton();
            this.dataGridViewSELECT_FULL = new System.Windows.Forms.DataGridView();
            this.tabPageSubQueries = new System.Windows.Forms.TabPage();
            this.groupBoxSubQueries = new System.Windows.Forms.GroupBox();
            this.dataGridViewSubQueries = new System.Windows.Forms.DataGridView();
            this.radioButtonKorZapros = new System.Windows.Forms.RadioButton();
            this.radioButtonNeKorZapros = new System.Windows.Forms.RadioButton();
            this.textBox_company_id_for_query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Queries = new System.Windows.Forms.Button();
            this.tabPageChangingData = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChangingdata = new System.Windows.Forms.DataGridView();
            this.radioButtonInsertDev = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateDev = new System.Windows.Forms.RadioButton();
            this.radioButtonDeleteDev = new System.Windows.Forms.RadioButton();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxCoding = new System.Windows.Forms.TextBox();
            this.textBoxSpeakEng = new System.Windows.Forms.TextBox();
            this.textBoxKnowScrum = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxCompany_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIdDev = new System.Windows.Forms.TextBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.groupBoxCost_project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSELECT_FULL)).BeginInit();
            this.tabPageSubQueries.SuspendLayout();
            this.groupBoxSubQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubQueries)).BeginInit();
            this.tabPageChangingData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangingdata)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubQueries);
            this.tabControlSQL.Controls.Add(this.tabPageChangingData);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(800, 450);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(792, 424);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonCost_with_taxes);
            this.groupBoxSelect.Controls.Add(this.radioButtonCustomers);
            this.groupBoxSelect.Controls.Add(this.radiobuttonTechReq);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonCost_with_taxes
            // 
            this.radioButtonCost_with_taxes.AutoSize = true;
            this.radioButtonCost_with_taxes.Location = new System.Drawing.Point(227, 20);
            this.radioButtonCost_with_taxes.Name = "radioButtonCost_with_taxes";
            this.radioButtonCost_with_taxes.Size = new System.Drawing.Size(96, 17);
            this.radioButtonCost_with_taxes.TabIndex = 2;
            this.radioButtonCost_with_taxes.TabStop = true;
            this.radioButtonCost_with_taxes.Text = "Cost with taxes";
            this.radioButtonCost_with_taxes.UseVisualStyleBackColor = true;
            this.radioButtonCost_with_taxes.CheckedChanged += new System.EventHandler(this.radioButtonCompanies_CheckedChanged);
            // 
            // radioButtonCustomers
            // 
            this.radioButtonCustomers.AutoSize = true;
            this.radioButtonCustomers.Location = new System.Drawing.Point(148, 20);
            this.radioButtonCustomers.Name = "radioButtonCustomers";
            this.radioButtonCustomers.Size = new System.Drawing.Size(73, 17);
            this.radioButtonCustomers.TabIndex = 1;
            this.radioButtonCustomers.TabStop = true;
            this.radioButtonCustomers.Text = "customers";
            this.radioButtonCustomers.UseVisualStyleBackColor = true;
            this.radioButtonCustomers.CheckedChanged += new System.EventHandler(this.radioButtonCustomers_CheckedChanged);
            // 
            // radiobuttonTechReq
            // 
            this.radiobuttonTechReq.AutoSize = true;
            this.radiobuttonTechReq.Location = new System.Drawing.Point(7, 20);
            this.radiobuttonTechReq.Name = "radiobuttonTechReq";
            this.radiobuttonTechReq.Size = new System.Drawing.Size(135, 17);
            this.radiobuttonTechReq.TabIndex = 0;
            this.radiobuttonTechReq.TabStop = true;
            this.radiobuttonTechReq.Text = "Technical requirements";
            this.radiobuttonTechReq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobuttonTechReq.UseVisualStyleBackColor = true;
            this.radiobuttonTechReq.CheckedChanged += new System.EventHandler(this.radiobuttonDevs_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewSELECT_FULL);
            this.tabPageSelect.Controls.Add(this.groupBoxCost_project);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(792, 424);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // groupBoxCost_project
            // 
            this.groupBoxCost_project.Controls.Add(this.radioButtonCheck_project_cost);
            this.groupBoxCost_project.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCost_project.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCost_project.Name = "groupBoxCost_project";
            this.groupBoxCost_project.Size = new System.Drawing.Size(786, 100);
            this.groupBoxCost_project.TabIndex = 0;
            this.groupBoxCost_project.TabStop = false;
            this.groupBoxCost_project.Text = "Просмотр цены проектов";
            // 
            // radioButtonCheck_project_cost
            // 
            this.radioButtonCheck_project_cost.AutoSize = true;
            this.radioButtonCheck_project_cost.Location = new System.Drawing.Point(7, 20);
            this.radioButtonCheck_project_cost.Name = "radioButtonCheck_project_cost";
            this.radioButtonCheck_project_cost.Size = new System.Drawing.Size(95, 17);
            this.radioButtonCheck_project_cost.TabIndex = 0;
            this.radioButtonCheck_project_cost.TabStop = true;
            this.radioButtonCheck_project_cost.Text = "Цена проекта";
            this.radioButtonCheck_project_cost.UseVisualStyleBackColor = true;
            this.radioButtonCheck_project_cost.CheckedChanged += new System.EventHandler(this.radioButtonCheck_project_cost_CheckedChanged_1);
            // 
            // dataGridViewSELECT_FULL
            // 
            this.dataGridViewSELECT_FULL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSELECT_FULL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSELECT_FULL.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSELECT_FULL.Name = "dataGridViewSELECT_FULL";
            this.dataGridViewSELECT_FULL.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSELECT_FULL.TabIndex = 1;
            // 
            // tabPageSubQueries
            // 
            this.tabPageSubQueries.Controls.Add(this.dataGridViewSubQueries);
            this.tabPageSubQueries.Controls.Add(this.groupBoxSubQueries);
            this.tabPageSubQueries.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubQueries.Name = "tabPageSubQueries";
            this.tabPageSubQueries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubQueries.Size = new System.Drawing.Size(792, 424);
            this.tabPageSubQueries.TabIndex = 2;
            this.tabPageSubQueries.Text = "Примеры подзапросов";
            this.tabPageSubQueries.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubQueries
            // 
            this.groupBoxSubQueries.Controls.Add(this.Queries);
            this.groupBoxSubQueries.Controls.Add(this.label1);
            this.groupBoxSubQueries.Controls.Add(this.textBox_company_id_for_query);
            this.groupBoxSubQueries.Controls.Add(this.radioButtonNeKorZapros);
            this.groupBoxSubQueries.Controls.Add(this.radioButtonKorZapros);
            this.groupBoxSubQueries.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubQueries.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubQueries.Name = "groupBoxSubQueries";
            this.groupBoxSubQueries.Size = new System.Drawing.Size(786, 100);
            this.groupBoxSubQueries.TabIndex = 0;
            this.groupBoxSubQueries.TabStop = false;
            this.groupBoxSubQueries.Text = "Подзапросы по данным";
            // 
            // dataGridViewSubQueries
            // 
            this.dataGridViewSubQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubQueries.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSubQueries.Name = "dataGridViewSubQueries";
            this.dataGridViewSubQueries.Size = new System.Drawing.Size(786, 318);
            this.dataGridViewSubQueries.TabIndex = 1;
            // 
            // radioButtonKorZapros
            // 
            this.radioButtonKorZapros.AutoSize = true;
            this.radioButtonKorZapros.Location = new System.Drawing.Point(7, 20);
            this.radioButtonKorZapros.Name = "radioButtonKorZapros";
            this.radioButtonKorZapros.Size = new System.Drawing.Size(157, 17);
            this.radioButtonKorZapros.TabIndex = 0;
            this.radioButtonKorZapros.TabStop = true;
            this.radioButtonKorZapros.Text = "Коррелированный запрос";
            this.radioButtonKorZapros.UseVisualStyleBackColor = true;
            // 
            // radioButtonNeKorZapros
            // 
            this.radioButtonNeKorZapros.AutoSize = true;
            this.radioButtonNeKorZapros.Location = new System.Drawing.Point(191, 20);
            this.radioButtonNeKorZapros.Name = "radioButtonNeKorZapros";
            this.radioButtonNeKorZapros.Size = new System.Drawing.Size(170, 17);
            this.radioButtonNeKorZapros.TabIndex = 1;
            this.radioButtonNeKorZapros.TabStop = true;
            this.radioButtonNeKorZapros.Text = "Некоррелированный запрос";
            this.radioButtonNeKorZapros.UseVisualStyleBackColor = true;
            // 
            // textBox_company_id_for_query
            // 
            this.textBox_company_id_for_query.Location = new System.Drawing.Point(144, 66);
            this.textBox_company_id_for_query.Name = "textBox_company_id_for_query";
            this.textBox_company_id_for_query.Size = new System.Drawing.Size(217, 20);
            this.textBox_company_id_for_query.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id компании работников";
            // 
            // Queries
            // 
            this.Queries.Location = new System.Drawing.Point(700, 62);
            this.Queries.Name = "Queries";
            this.Queries.Size = new System.Drawing.Size(75, 23);
            this.Queries.TabIndex = 4;
            this.Queries.Text = "Выполнить";
            this.Queries.UseVisualStyleBackColor = true;
            this.Queries.Click += new System.EventHandler(this.Queries_Click);
            // 
            // tabPageChangingData
            // 
            this.tabPageChangingData.Controls.Add(this.dataGridViewChangingdata);
            this.tabPageChangingData.Controls.Add(this.groupBox1);
            this.tabPageChangingData.Location = new System.Drawing.Point(4, 22);
            this.tabPageChangingData.Name = "tabPageChangingData";
            this.tabPageChangingData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangingData.Size = new System.Drawing.Size(792, 424);
            this.tabPageChangingData.TabIndex = 3;
            this.tabPageChangingData.Text = "Запросы изменения данных";
            this.tabPageChangingData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGO);
            this.groupBox1.Controls.Add(this.textBoxIdDev);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCompany_id);
            this.groupBox1.Controls.Add(this.textBoxPhoneNum);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxKnowScrum);
            this.groupBox1.Controls.Add(this.textBoxSpeakEng);
            this.groupBox1.Controls.Add(this.textBoxCoding);
            this.groupBox1.Controls.Add(this.textBoxMiddleName);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.radioButtonDeleteDev);
            this.groupBox1.Controls.Add(this.radioButtonUpdateDev);
            this.groupBox1.Controls.Add(this.radioButtonInsertDev);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операторы";
            // 
            // dataGridViewChangingdata
            // 
            this.dataGridViewChangingdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangingdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChangingdata.Location = new System.Drawing.Point(3, 237);
            this.dataGridViewChangingdata.Name = "dataGridViewChangingdata";
            this.dataGridViewChangingdata.Size = new System.Drawing.Size(786, 184);
            this.dataGridViewChangingdata.TabIndex = 1;
            // 
            // radioButtonInsertDev
            // 
            this.radioButtonInsertDev.AutoSize = true;
            this.radioButtonInsertDev.Location = new System.Drawing.Point(7, 29);
            this.radioButtonInsertDev.Name = "radioButtonInsertDev";
            this.radioButtonInsertDev.Size = new System.Drawing.Size(148, 17);
            this.radioButtonInsertDev.TabIndex = 0;
            this.radioButtonInsertDev.TabStop = true;
            this.radioButtonInsertDev.Text = "Добавить разработчика";
            this.radioButtonInsertDev.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateDev
            // 
            this.radioButtonUpdateDev.AutoSize = true;
            this.radioButtonUpdateDev.Location = new System.Drawing.Point(161, 29);
            this.radioButtonUpdateDev.Name = "radioButtonUpdateDev";
            this.radioButtonUpdateDev.Size = new System.Drawing.Size(232, 17);
            this.radioButtonUpdateDev.TabIndex = 1;
            this.radioButtonUpdateDev.TabStop = true;
            this.radioButtonUpdateDev.Text = "Изменить информацию по разработчику";
            this.radioButtonUpdateDev.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeleteDev
            // 
            this.radioButtonDeleteDev.AutoSize = true;
            this.radioButtonDeleteDev.Location = new System.Drawing.Point(400, 29);
            this.radioButtonDeleteDev.Name = "radioButtonDeleteDev";
            this.radioButtonDeleteDev.Size = new System.Drawing.Size(141, 17);
            this.radioButtonDeleteDev.TabIndex = 2;
            this.radioButtonDeleteDev.TabStop = true;
            this.radioButtonDeleteDev.Text = "Удалить разработчика";
            this.radioButtonDeleteDev.UseVisualStyleBackColor = true;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(101, 64);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(148, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(101, 138);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(148, 20);
            this.textBoxMiddleName.TabIndex = 5;
            // 
            // textBoxCoding
            // 
            this.textBoxCoding.Location = new System.Drawing.Point(101, 179);
            this.textBoxCoding.Name = "textBoxCoding";
            this.textBoxCoding.Size = new System.Drawing.Size(148, 20);
            this.textBoxCoding.TabIndex = 6;
            // 
            // textBoxSpeakEng
            // 
            this.textBoxSpeakEng.Location = new System.Drawing.Point(339, 64);
            this.textBoxSpeakEng.Name = "textBoxSpeakEng";
            this.textBoxSpeakEng.Size = new System.Drawing.Size(168, 20);
            this.textBoxSpeakEng.TabIndex = 7;
            // 
            // textBoxKnowScrum
            // 
            this.textBoxKnowScrum.Location = new System.Drawing.Point(339, 102);
            this.textBoxKnowScrum.Name = "textBoxKnowScrum";
            this.textBoxKnowScrum.Size = new System.Drawing.Size(168, 20);
            this.textBoxKnowScrum.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(339, 138);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(168, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(339, 179);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(168, 20);
            this.textBoxPhoneNum.TabIndex = 10;
            // 
            // textBoxCompany_id
            // 
            this.textBoxCompany_id.Location = new System.Drawing.Point(614, 64);
            this.textBoxCompany_id.Name = "textBoxCompany_id";
            this.textBoxCompany_id.Size = new System.Drawing.Size(166, 20);
            this.textBoxCompany_id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "умение кодинга";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "знание англ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "знание scrum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "почта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(513, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "id компании";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "id_разработчика";
            // 
            // textBoxIdDev
            // 
            this.textBoxIdDev.Location = new System.Drawing.Point(613, 102);
            this.textBoxIdDev.Name = "textBoxIdDev";
            this.textBoxIdDev.Size = new System.Drawing.Size(166, 20);
            this.textBoxIdDev.TabIndex = 22;
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(701, 185);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(78, 23);
            this.buttonGO.TabIndex = 23;
            this.buttonGO.Text = "выполнить";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            this.groupBoxCost_project.ResumeLayout(false);
            this.groupBoxCost_project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSELECT_FULL)).EndInit();
            this.tabPageSubQueries.ResumeLayout(false);
            this.groupBoxSubQueries.ResumeLayout(false);
            this.groupBoxSubQueries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubQueries)).EndInit();
            this.tabPageChangingData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangingdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonCost_with_taxes;
        private System.Windows.Forms.RadioButton radioButtonCustomers;
        private System.Windows.Forms.RadioButton radiobuttonTechReq;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxCost_project;
        private System.Windows.Forms.DataGridView dataGridViewSELECT_FULL;
        private System.Windows.Forms.RadioButton radioButtonCheck_project_cost;
        private System.Windows.Forms.TabPage tabPageSubQueries;
        private System.Windows.Forms.DataGridView dataGridViewSubQueries;
        private System.Windows.Forms.GroupBox groupBoxSubQueries;
        private System.Windows.Forms.Button Queries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_company_id_for_query;
        private System.Windows.Forms.RadioButton radioButtonNeKorZapros;
        private System.Windows.Forms.RadioButton radioButtonKorZapros;
        private System.Windows.Forms.TabPage tabPageChangingData;
        private System.Windows.Forms.DataGridView dataGridViewChangingdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDeleteDev;
        private System.Windows.Forms.RadioButton radioButtonUpdateDev;
        private System.Windows.Forms.RadioButton radioButtonInsertDev;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.TextBox textBoxIdDev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompany_id;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxKnowScrum;
        private System.Windows.Forms.TextBox textBoxSpeakEng;
        private System.Windows.Forms.TextBox textBoxCoding;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}