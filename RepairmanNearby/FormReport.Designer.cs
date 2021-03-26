namespace RepairmanNearby
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.labelCountUserReg = new System.Windows.Forms.Label();
            this.textBoxCountUserReg = new System.Windows.Forms.TextBox();
            this.labelProfitForTheP = new System.Windows.Forms.Label();
            this.textBoxProfitForTheP = new System.Windows.Forms.TextBox();
            this.textBoxCountAddMaster = new System.Windows.Forms.TextBox();
            this.labelCountAddMaster = new System.Windows.Forms.Label();
            this.dateTimePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.buttonFormReport = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateReport.Location = new System.Drawing.Point(677, 390);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(111, 48);
            this.buttonCreateReport.TabIndex = 0;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // labelCountUserReg
            // 
            this.labelCountUserReg.AutoSize = true;
            this.labelCountUserReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCountUserReg.Location = new System.Drawing.Point(3, 88);
            this.labelCountUserReg.Name = "labelCountUserReg";
            this.labelCountUserReg.Size = new System.Drawing.Size(465, 20);
            this.labelCountUserReg.TabIndex = 1;
            this.labelCountUserReg.Text = "Количество зарегистрированных пользователей за период";
            // 
            // textBoxCountUserReg
            // 
            this.textBoxCountUserReg.Location = new System.Drawing.Point(6, 111);
            this.textBoxCountUserReg.Name = "textBoxCountUserReg";
            this.textBoxCountUserReg.Size = new System.Drawing.Size(488, 20);
            this.textBoxCountUserReg.TabIndex = 2;
            // 
            // labelProfitForTheP
            // 
            this.labelProfitForTheP.AutoSize = true;
            this.labelProfitForTheP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelProfitForTheP.Location = new System.Drawing.Point(2, 209);
            this.labelProfitForTheP.Name = "labelProfitForTheP";
            this.labelProfitForTheP.Size = new System.Drawing.Size(159, 20);
            this.labelProfitForTheP.TabIndex = 3;
            this.labelProfitForTheP.Text = "Прибыль за период";
            // 
            // textBoxProfitForTheP
            // 
            this.textBoxProfitForTheP.Location = new System.Drawing.Point(6, 232);
            this.textBoxProfitForTheP.Name = "textBoxProfitForTheP";
            this.textBoxProfitForTheP.Size = new System.Drawing.Size(488, 20);
            this.textBoxProfitForTheP.TabIndex = 4;
            // 
            // textBoxCountAddMaster
            // 
            this.textBoxCountAddMaster.Location = new System.Drawing.Point(5, 172);
            this.textBoxCountAddMaster.Name = "textBoxCountAddMaster";
            this.textBoxCountAddMaster.Size = new System.Drawing.Size(489, 20);
            this.textBoxCountAddMaster.TabIndex = 6;
            // 
            // labelCountAddMaster
            // 
            this.labelCountAddMaster.AutoSize = true;
            this.labelCountAddMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCountAddMaster.Location = new System.Drawing.Point(2, 149);
            this.labelCountAddMaster.Name = "labelCountAddMaster";
            this.labelCountAddMaster.Size = new System.Drawing.Size(364, 20);
            this.labelCountAddMaster.TabIndex = 5;
            this.labelCountAddMaster.Text = "Количество добавленных мастеров за период";
            // 
            // dateTimePickerDateStart
            // 
            this.dateTimePickerDateStart.Location = new System.Drawing.Point(7, 41);
            this.dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            this.dateTimePickerDateStart.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerDateStart.TabIndex = 7;
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(275, 41);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(219, 20);
            this.dateTimePickerDateEnd.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.labelDateEnd);
            this.groupBox1.Controls.Add(this.labelDateStart);
            this.groupBox1.Controls.Add(this.buttonFormReport);
            this.groupBox1.Controls.Add(this.textBoxCountUserReg);
            this.groupBox1.Controls.Add(this.dateTimePickerDateEnd);
            this.groupBox1.Controls.Add(this.labelCountUserReg);
            this.groupBox1.Controls.Add(this.dateTimePickerDateStart);
            this.groupBox1.Controls.Add(this.labelProfitForTheP);
            this.groupBox1.Controls.Add(this.textBoxCountAddMaster);
            this.groupBox1.Controls.Add(this.textBoxProfitForTheP);
            this.groupBox1.Controls.Add(this.labelCountAddMaster);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 328);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(272, 22);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 12;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Location = new System.Drawing.Point(7, 22);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(71, 13);
            this.labelDateStart.TabIndex = 11;
            this.labelDateStart.Text = "Дата начала";
            // 
            // buttonFormReport
            // 
            this.buttonFormReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFormReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFormReport.Location = new System.Drawing.Point(383, 274);
            this.buttonFormReport.Name = "buttonFormReport";
            this.buttonFormReport.Size = new System.Drawing.Size(111, 48);
            this.buttonFormReport.TabIndex = 10;
            this.buttonFormReport.Text = "Сформировать";
            this.buttonFormReport.UseVisualStyleBackColor = false;
            this.buttonFormReport.Click += new System.EventHandler(this.buttonFormReport_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 390);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 48);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormReport";
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Label labelCountUserReg;
        private System.Windows.Forms.TextBox textBoxCountUserReg;
        private System.Windows.Forms.Label labelProfitForTheP;
        private System.Windows.Forms.TextBox textBoxProfitForTheP;
        private System.Windows.Forms.TextBox textBoxCountAddMaster;
        private System.Windows.Forms.Label labelCountAddMaster;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Button buttonFormReport;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}