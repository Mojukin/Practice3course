namespace RepairmanNearby
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelDateofbirth = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelReturnPassword = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxReturnPassword = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panelRegisteration = new System.Windows.Forms.Panel();
            this.labelReg = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelRegisteration.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(51, 11);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(78, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(53, 71);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelDateofbirth
            // 
            this.labelDateofbirth.AutoSize = true;
            this.labelDateofbirth.Location = new System.Drawing.Point(21, 101);
            this.labelDateofbirth.Name = "labelDateofbirth";
            this.labelDateofbirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateofbirth.TabIndex = 3;
            this.labelDateofbirth.Text = "Дата рождения";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(75, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(55, 161);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(52, 13);
            this.labelTelephone.TabIndex = 5;
            this.labelTelephone.Text = "Телефон";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(62, 191);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // labelReturnPassword
            // 
            this.labelReturnPassword.AutoSize = true;
            this.labelReturnPassword.Location = new System.Drawing.Point(7, 221);
            this.labelReturnPassword.Name = "labelReturnPassword";
            this.labelReturnPassword.Size = new System.Drawing.Size(100, 13);
            this.labelReturnPassword.TabIndex = 7;
            this.labelReturnPassword.Text = "Повторите пароль";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(113, 8);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(308, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 38);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(308, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(113, 68);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(308, 20);
            this.textBoxPatronymic.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(113, 131);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 20);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(113, 158);
            this.textBoxTelephone.MaxLength = 11;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(308, 20);
            this.textBoxTelephone.TabIndex = 13;
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(113, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(308, 20);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // textBoxReturnPassword
            // 
            this.textBoxReturnPassword.Location = new System.Drawing.Point(113, 218);
            this.textBoxReturnPassword.Name = "textBoxReturnPassword";
            this.textBoxReturnPassword.Size = new System.Drawing.Size(308, 20);
            this.textBoxReturnPassword.TabIndex = 15;
            this.textBoxReturnPassword.Validated += new System.EventHandler(this.textBoxReturnPassword_Validated);
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(113, 101);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 11;
            // 
            // panelRegisteration
            // 
            this.panelRegisteration.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelRegisteration.Controls.Add(this.textBoxReturnPassword);
            this.panelRegisteration.Controls.Add(this.dateTimePickerDateOfBirth);
            this.panelRegisteration.Controls.Add(this.labelSurname);
            this.panelRegisteration.Controls.Add(this.labelName);
            this.panelRegisteration.Controls.Add(this.textBoxPassword);
            this.panelRegisteration.Controls.Add(this.labelPatronymic);
            this.panelRegisteration.Controls.Add(this.textBoxTelephone);
            this.panelRegisteration.Controls.Add(this.labelDateofbirth);
            this.panelRegisteration.Controls.Add(this.textBoxEmail);
            this.panelRegisteration.Controls.Add(this.labelEmail);
            this.panelRegisteration.Controls.Add(this.textBoxPatronymic);
            this.panelRegisteration.Controls.Add(this.labelTelephone);
            this.panelRegisteration.Controls.Add(this.textBoxName);
            this.panelRegisteration.Controls.Add(this.labelPassword);
            this.panelRegisteration.Controls.Add(this.textBoxSurname);
            this.panelRegisteration.Controls.Add(this.labelReturnPassword);
            this.panelRegisteration.Location = new System.Drawing.Point(197, 99);
            this.panelRegisteration.Name = "panelRegisteration";
            this.panelRegisteration.Size = new System.Drawing.Size(434, 250);
            this.panelRegisteration.TabIndex = 17;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReg.Location = new System.Drawing.Point(333, 67);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(175, 29);
            this.labelReg.TabIndex = 18;
            this.labelReg.Text = "Регистрация";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReg.Location = new System.Drawing.Point(511, 355);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(120, 42);
            this.buttonReg.TabIndex = 16;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(197, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 42);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.panelRegisteration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.panelRegisteration.ResumeLayout(false);
            this.panelRegisteration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelDateofbirth;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelReturnPassword;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxReturnPassword;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Panel panelRegisteration;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
    }
}