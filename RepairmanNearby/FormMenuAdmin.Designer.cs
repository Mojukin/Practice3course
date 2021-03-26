namespace RepairmanNearby
{
    partial class FormMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAdmin));
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonShowMasters = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDataToExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowUsers.Location = new System.Drawing.Point(676, 370);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(112, 52);
            this.buttonShowUsers.TabIndex = 0;
            this.buttonShowUsers.Text = "Просмотр пользователей";
            this.buttonShowUsers.UseVisualStyleBackColor = false;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateReport.Location = new System.Drawing.Point(344, 370);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(112, 52);
            this.buttonCreateReport.TabIndex = 1;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // buttonShowMasters
            // 
            this.buttonShowMasters.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowMasters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowMasters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowMasters.Location = new System.Drawing.Point(519, 370);
            this.buttonShowMasters.Name = "buttonShowMasters";
            this.buttonShowMasters.Size = new System.Drawing.Size(112, 52);
            this.buttonShowMasters.TabIndex = 2;
            this.buttonShowMasters.Text = "Просмотр мастеров";
            this.buttonShowMasters.UseVisualStyleBackColor = false;
            this.buttonShowMasters.Click += new System.EventHandler(this.buttonShowMasters_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(32, 370);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 52);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDataToExcel
            // 
            this.buttonDataToExcel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDataToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDataToExcel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDataToExcel.Location = new System.Drawing.Point(185, 370);
            this.buttonDataToExcel.Name = "buttonDataToExcel";
            this.buttonDataToExcel.Size = new System.Drawing.Size(112, 52);
            this.buttonDataToExcel.TabIndex = 4;
            this.buttonDataToExcel.Text = "Выгрузить все данные в Excel";
            this.buttonDataToExcel.UseVisualStyleBackColor = false;
            this.buttonDataToExcel.Click += new System.EventHandler(this.buttonDataToExcel_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDataToExcel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonShowMasters);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.buttonShowUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonShowMasters;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDataToExcel;
    }
}