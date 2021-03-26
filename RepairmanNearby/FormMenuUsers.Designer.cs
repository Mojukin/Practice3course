namespace RepairmanNearby
{
    partial class FormMenuUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuUsers));
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.dataGridViewMyOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMyOrders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefactData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxNamePeople = new System.Windows.Forms.TextBox();
            this.buttonCloseAcc = new System.Windows.Forms.Button();
            this.workshopDataSet = new RepairmanNearby.WorkshopDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateOrder.Location = new System.Drawing.Point(828, 335);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(119, 45);
            this.buttonCreateOrder.TabIndex = 0;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // dataGridViewMyOrders
            // 
            this.dataGridViewMyOrders.AllowUserToAddRows = false;
            this.dataGridViewMyOrders.AllowUserToDeleteRows = false;
            this.dataGridViewMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridViewMyOrders.Location = new System.Drawing.Point(471, 51);
            this.dataGridViewMyOrders.Name = "dataGridViewMyOrders";
            this.dataGridViewMyOrders.ReadOnly = true;
            this.dataGridViewMyOrders.Size = new System.Drawing.Size(476, 278);
            this.dataGridViewMyOrders.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия мастера";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя мастера";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество мастера";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Специализация мастера";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Почта мастера";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Телефон мастера";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Тип работы";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Результат работы";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Отданная техника";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Тип ремонтируемого устройства";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Статус заказа";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Цена";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Дата начала ремонта";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Дата окончания ремонта";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // labelMyOrders
            // 
            this.labelMyOrders.AutoSize = true;
            this.labelMyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelMyOrders.Location = new System.Drawing.Point(466, 19);
            this.labelMyOrders.Name = "labelMyOrders";
            this.labelMyOrders.Size = new System.Drawing.Size(159, 29);
            this.labelMyOrders.TabIndex = 2;
            this.labelMyOrders.Text = "Мои заказы";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonRefactData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxDateOfBirth);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxTelephone);
            this.panel1.Controls.Add(this.textBoxNamePeople);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 278);
            this.panel1.TabIndex = 4;
            // 
            // buttonRefactData
            // 
            this.buttonRefactData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRefactData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefactData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefactData.Location = new System.Drawing.Point(318, 230);
            this.buttonRefactData.Name = "buttonRefactData";
            this.buttonRefactData.Size = new System.Drawing.Size(119, 45);
            this.buttonRefactData.TabIndex = 35;
            this.buttonRefactData.Text = "Изменить данные";
            this.buttonRefactData.UseVisualStyleBackColor = false;
            this.buttonRefactData.Click += new System.EventHandler(this.buttonRefactData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(53, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Эл.почта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Телефон:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(131, 148);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.ReadOnly = true;
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(306, 20);
            this.textBoxDateOfBirth.TabIndex = 28;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(131, 109);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(306, 20);
            this.textBoxEmail.TabIndex = 27;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(131, 70);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.ReadOnly = true;
            this.textBoxTelephone.Size = new System.Drawing.Size(306, 20);
            this.textBoxTelephone.TabIndex = 26;
            // 
            // textBoxNamePeople
            // 
            this.textBoxNamePeople.BackColor = System.Drawing.Color.Coral;
            this.textBoxNamePeople.Location = new System.Drawing.Point(6, 15);
            this.textBoxNamePeople.Name = "textBoxNamePeople";
            this.textBoxNamePeople.ReadOnly = true;
            this.textBoxNamePeople.Size = new System.Drawing.Size(431, 20);
            this.textBoxNamePeople.TabIndex = 24;
            // 
            // buttonCloseAcc
            // 
            this.buttonCloseAcc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCloseAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCloseAcc.Location = new System.Drawing.Point(12, 454);
            this.buttonCloseAcc.Name = "buttonCloseAcc";
            this.buttonCloseAcc.Size = new System.Drawing.Size(119, 45);
            this.buttonCloseAcc.TabIndex = 5;
            this.buttonCloseAcc.Text = "Выйти из аккаунта";
            this.buttonCloseAcc.UseVisualStyleBackColor = false;
            this.buttonCloseAcc.Click += new System.EventHandler(this.buttonCloseAcc_Click);
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "WorkshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormMenuUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 511);
            this.Controls.Add(this.buttonCloseAcc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMyOrders);
            this.Controls.Add(this.dataGridViewMyOrders);
            this.Controls.Add(this.buttonCreateOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(975, 550);
            this.MinimumSize = new System.Drawing.Size(975, 550);
            this.Name = "FormMenuUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormMenuUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.DataGridView dataGridViewMyOrders;
        private System.Windows.Forms.Label labelMyOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxNamePeople;
        private System.Windows.Forms.Button buttonRefactData;
        private System.Windows.Forms.Button buttonCloseAcc;
        private WorkshopDataSet workshopDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}