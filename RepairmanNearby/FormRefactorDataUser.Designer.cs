namespace RepairmanNearby
{
    partial class FormRefactorDataUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRefactorDataUser));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRefactorData = new System.Windows.Forms.Button();
            this.panelRegisteration = new System.Windows.Forms.Panel();
            this.textBoxReturnPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelDateofbirth = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelRefactorData = new System.Windows.Forms.Label();
            this.panelRegisteration.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(175, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 42);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRefactorData
            // 
            this.buttonRefactorData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRefactorData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefactorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRefactorData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefactorData.Location = new System.Drawing.Point(495, 375);
            this.buttonRefactorData.Name = "buttonRefactorData";
            this.buttonRefactorData.Size = new System.Drawing.Size(120, 42);
            this.buttonRefactorData.TabIndex = 17;
            this.buttonRefactorData.Text = "Изменить данные";
            this.buttonRefactorData.UseVisualStyleBackColor = false;
            this.buttonRefactorData.Click += new System.EventHandler(this.buttonRefactorData_Click);
            // 
            // panelRegisteration
            // 
            this.panelRegisteration.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelRegisteration.Controls.Add(this.textBoxReturnPassword);
            this.panelRegisteration.Controls.Add(this.label3);
            this.panelRegisteration.Controls.Add(this.textBoxOldPassword);
            this.panelRegisteration.Controls.Add(this.label2);
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
            this.panelRegisteration.Location = new System.Drawing.Point(175, 73);
            this.panelRegisteration.Name = "panelRegisteration";
            this.panelRegisteration.Size = new System.Drawing.Size(440, 296);
            this.panelRegisteration.TabIndex = 21;
            // 
            // textBoxReturnPassword
            // 
            this.textBoxReturnPassword.Location = new System.Drawing.Point(117, 265);
            this.textBoxReturnPassword.Name = "textBoxReturnPassword";
            this.textBoxReturnPassword.Size = new System.Drawing.Size(308, 20);
            this.textBoxReturnPassword.TabIndex = 16;
            this.textBoxReturnPassword.Validated += new System.EventHandler(this.textBoxReturnPassword_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Повторите пароль";
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(117, 203);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(308, 20);
            this.textBoxOldPassword.TabIndex = 14;
            this.textBoxOldPassword.Validated += new System.EventHandler(this.textBoxOldPassword_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Старый пароль";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(117, 116);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(308, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 11;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(55, 26);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(82, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(117, 232);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(308, 20);
            this.textBoxPassword.TabIndex = 15;
            this.textBoxPassword.Validated += new System.EventHandler(this.textBoxPassword_Validated);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(57, 86);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(117, 173);
            this.textBoxTelephone.MaxLength = 11;
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(308, 20);
            this.textBoxTelephone.TabIndex = 13;
            this.textBoxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelephone_KeyPress);
            // 
            // labelDateofbirth
            // 
            this.labelDateofbirth.AutoSize = true;
            this.labelDateofbirth.Location = new System.Drawing.Point(25, 116);
            this.labelDateofbirth.Name = "labelDateofbirth";
            this.labelDateofbirth.Size = new System.Drawing.Size(86, 13);
            this.labelDateofbirth.TabIndex = 3;
            this.labelDateofbirth.Text = "Дата рождения";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 146);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 20);
            this.textBoxEmail.TabIndex = 12;
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxEmail_Validated);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(79, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(117, 83);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(308, 20);
            this.textBoxPatronymic.TabIndex = 10;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(59, 176);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(52, 13);
            this.labelTelephone.TabIndex = 5;
            this.labelTelephone.Text = "Телефон";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(117, 53);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(308, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(31, 235);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(80, 13);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Новый пароль";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(117, 23);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(308, 20);
            this.textBoxSurname.TabIndex = 8;
            // 
            // labelRefactorData
            // 
            this.labelRefactorData.AutoSize = true;
            this.labelRefactorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelRefactorData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRefactorData.Location = new System.Drawing.Point(299, 34);
            this.labelRefactorData.Name = "labelRefactorData";
            this.labelRefactorData.Size = new System.Drawing.Size(225, 26);
            this.labelRefactorData.TabIndex = 24;
            this.labelRefactorData.Text = "Изменение данных";
            // 
            // FormRefactorDataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRefactorData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRefactorData);
            this.Controls.Add(this.panelRegisteration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormRefactorDataUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormRefactorDataUser_Load);
            this.panelRegisteration.ResumeLayout(false);
            this.panelRegisteration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRefactorData;
        private System.Windows.Forms.Panel panelRegisteration;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelDateofbirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelRefactorData;
        private System.Windows.Forms.TextBox textBoxReturnPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label2;
    }
}