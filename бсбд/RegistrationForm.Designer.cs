namespace бсбд
{
    partial class RegistrationForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reg_log_txt_box = new System.Windows.Forms.TextBox();
            this.Reg_pass_txt_box = new System.Windows.Forms.TextBox();
            this.To_auth_Form = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Reg_log_txt_box
            // 
            this.Reg_log_txt_box.Location = new System.Drawing.Point(109, 25);
            this.Reg_log_txt_box.Name = "Reg_log_txt_box";
            this.Reg_log_txt_box.Size = new System.Drawing.Size(291, 22);
            this.Reg_log_txt_box.TabIndex = 3;
            // 
            // Reg_pass_txt_box
            // 
            this.Reg_pass_txt_box.Location = new System.Drawing.Point(109, 84);
            this.Reg_pass_txt_box.Name = "Reg_pass_txt_box";
            this.Reg_pass_txt_box.PasswordChar = '*';
            this.Reg_pass_txt_box.Size = new System.Drawing.Size(291, 22);
            this.Reg_pass_txt_box.TabIndex = 4;
            this.Reg_pass_txt_box.UseSystemPasswordChar = true;
            // 
            // To_auth_Form
            // 
            this.To_auth_Form.AutoSize = true;
            this.To_auth_Form.Location = new System.Drawing.Point(27, 151);
            this.To_auth_Form.Name = "To_auth_Form";
            this.To_auth_Form.Size = new System.Drawing.Size(171, 16);
            this.To_auth_Form.TabIndex = 5;
            this.To_auth_Form.Text = "Уже есть аккаунт? Войти";
            this.To_auth_Form.Click += new System.EventHandler(this.To_auth_Form_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 201);
            this.Controls.Add(this.To_auth_Form);
            this.Controls.Add(this.Reg_pass_txt_box);
            this.Controls.Add(this.Reg_log_txt_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Reg_log_txt_box;
        private System.Windows.Forms.TextBox Reg_pass_txt_box;
        private System.Windows.Forms.Label To_auth_Form;
    }
}