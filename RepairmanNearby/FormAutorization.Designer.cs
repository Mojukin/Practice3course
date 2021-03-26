namespace RepairmanNearby
{
    partial class FormAutorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutorization));
            this.buttonAutorization = new System.Windows.Forms.Button();
            this.labelOpenAcc = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.labelNoAcc = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAutorization
            // 
            this.buttonAutorization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAutorization.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAutorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonAutorization.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAutorization.Location = new System.Drawing.Point(332, 301);
            this.buttonAutorization.MaximumSize = new System.Drawing.Size(200, 60);
            this.buttonAutorization.MinimumSize = new System.Drawing.Size(164, 33);
            this.buttonAutorization.Name = "buttonAutorization";
            this.buttonAutorization.Size = new System.Drawing.Size(164, 33);
            this.buttonAutorization.TabIndex = 0;
            this.buttonAutorization.Text = "Войти в аккаунт";
            this.buttonAutorization.UseVisualStyleBackColor = false;
            this.buttonAutorization.Click += new System.EventHandler(this.Autorization_Click);
            // 
            // labelOpenAcc
            // 
            this.labelOpenAcc.AutoSize = true;
            this.labelOpenAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelOpenAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOpenAcc.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelOpenAcc.Location = new System.Drawing.Point(327, 149);
            this.labelOpenAcc.Name = "labelOpenAcc";
            this.labelOpenAcc.Size = new System.Drawing.Size(166, 26);
            this.labelOpenAcc.TabIndex = 1;
            this.labelOpenAcc.Text = "Вход в аккаунт";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(231, 195);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(234, 211);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(358, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(234, 262);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(358, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "admin";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(231, 246);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Пароль";
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmail.Image")));
            this.pictureBoxEmail.Location = new System.Drawing.Point(189, 201);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(39, 36);
            this.pictureBoxEmail.TabIndex = 6;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(189, 252);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(40, 36);
            this.pictureBoxPassword.TabIndex = 7;
            this.pictureBoxPassword.TabStop = false;
            // 
            // labelNoAcc
            // 
            this.labelNoAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNoAcc.AutoSize = true;
            this.labelNoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNoAcc.Location = new System.Drawing.Point(278, 387);
            this.labelNoAcc.Name = "labelNoAcc";
            this.labelNoAcc.Size = new System.Drawing.Size(137, 24);
            this.labelNoAcc.TabIndex = 8;
            this.labelNoAcc.Text = "Нет аккаунта?";
            // 
            // labelRegister
            // 
            this.labelRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRegister.AutoSize = true;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline);
            this.labelRegister.Location = new System.Drawing.Point(421, 387);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(126, 24);
            this.labelRegister.TabIndex = 9;
            this.labelRegister.Text = "Регистрация";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelNoAcc);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.pictureBoxEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelOpenAcc);
            this.Controls.Add(this.buttonAutorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormAutorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormAutorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAutorization;
        private System.Windows.Forms.Label labelOpenAcc;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label labelNoAcc;
        private System.Windows.Forms.Label labelRegister;
    }
}

