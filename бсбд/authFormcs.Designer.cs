namespace бсбд
{
    partial class authFormcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_txt_box = new System.Windows.Forms.TextBox();
            this.pass_txt_box = new System.Windows.Forms.TextBox();
            this.to_reg_label = new System.Windows.Forms.Label();
            this.Auth_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // login_txt_box
            // 
            this.login_txt_box.Location = new System.Drawing.Point(128, 37);
            this.login_txt_box.Name = "login_txt_box";
            this.login_txt_box.Size = new System.Drawing.Size(252, 22);
            this.login_txt_box.TabIndex = 2;
            // 
            // pass_txt_box
            // 
            this.pass_txt_box.Location = new System.Drawing.Point(128, 85);
            this.pass_txt_box.Name = "pass_txt_box";
            this.pass_txt_box.PasswordChar = '*';
            this.pass_txt_box.Size = new System.Drawing.Size(252, 22);
            this.pass_txt_box.TabIndex = 3;
            this.pass_txt_box.UseSystemPasswordChar = true;
            // 
            // to_reg_label
            // 
            this.to_reg_label.AutoSize = true;
            this.to_reg_label.Location = new System.Drawing.Point(12, 155);
            this.to_reg_label.Name = "to_reg_label";
            this.to_reg_label.Size = new System.Drawing.Size(236, 16);
            this.to_reg_label.TabIndex = 4;
            this.to_reg_label.Text = "Нет аккаунта? Зарегистрируйтесь";
            this.to_reg_label.Click += new System.EventHandler(this.to_reg_label_Click);
            // 
            // Auth_button
            // 
            this.Auth_button.Location = new System.Drawing.Point(293, 147);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(107, 33);
            this.Auth_button.TabIndex = 5;
            this.Auth_button.Text = "Вход";
            this.Auth_button.UseVisualStyleBackColor = true;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // authFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 195);
            this.Controls.Add(this.Auth_button);
            this.Controls.Add(this.to_reg_label);
            this.Controls.Add(this.pass_txt_box);
            this.Controls.Add(this.login_txt_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "authFormcs";
            this.Text = "authFormcs";
            this.Load += new System.EventHandler(this.authFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_txt_box;
        private System.Windows.Forms.TextBox pass_txt_box;
        private System.Windows.Forms.Label to_reg_label;
        private System.Windows.Forms.Button Auth_button;
    }
}