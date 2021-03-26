namespace RepairmanNearby
{
    partial class FormDelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelMaster));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelSelectIDMaster = new System.Windows.Forms.Label();
            this.dataGridViewDelMaster = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данныеСНИЛСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специализацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияОбученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыдачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортВыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewMastersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet = new RepairmanNearby.WorkshopDataSet();
            this.viewMastersTableAdapter = new RepairmanNearby.WorkshopDataSetTableAdapters.ViewMastersTableAdapter();
            this.textBoxEnterID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMastersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 376);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 48);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDel.Location = new System.Drawing.Point(684, 376);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(104, 48);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelSelectIDMaster
            // 
            this.labelSelectIDMaster.AutoSize = true;
            this.labelSelectIDMaster.Location = new System.Drawing.Point(9, 22);
            this.labelSelectIDMaster.Name = "labelSelectIDMaster";
            this.labelSelectIDMaster.Size = new System.Drawing.Size(130, 13);
            this.labelSelectIDMaster.TabIndex = 25;
            this.labelSelectIDMaster.Text = "Введите номер мастера";
            // 
            // dataGridViewDelMaster
            // 
            this.dataGridViewDelMaster.AllowUserToAddRows = false;
            this.dataGridViewDelMaster.AllowUserToDeleteRows = false;
            this.dataGridViewDelMaster.AutoGenerateColumns = false;
            this.dataGridViewDelMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.данныеСНИЛСDataGridViewTextBoxColumn,
            this.специализацияDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.видОбученияDataGridViewTextBoxColumn,
            this.формаОбученияDataGridViewTextBoxColumn,
            this.датаНачалаОбученияDataGridViewTextBoxColumn,
            this.датаОкончанияОбученияDataGridViewTextBoxColumn,
            this.серияПаспортаDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.датаВыдачиDataGridViewTextBoxColumn,
            this.паспортВыданDataGridViewTextBoxColumn,
            this.местоРегистрацииDataGridViewTextBoxColumn,
            this.парольDataGridViewTextBoxColumn});
            this.dataGridViewDelMaster.DataSource = this.viewMastersBindingSource;
            this.dataGridViewDelMaster.Location = new System.Drawing.Point(205, 22);
            this.dataGridViewDelMaster.Name = "dataGridViewDelMaster";
            this.dataGridViewDelMaster.ReadOnly = true;
            this.dataGridViewDelMaster.Size = new System.Drawing.Size(583, 348);
            this.dataGridViewDelMaster.TabIndex = 26;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Номер мастера";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // данныеСНИЛСDataGridViewTextBoxColumn
            // 
            this.данныеСНИЛСDataGridViewTextBoxColumn.DataPropertyName = "Данные СНИЛС";
            this.данныеСНИЛСDataGridViewTextBoxColumn.HeaderText = "Данные СНИЛС";
            this.данныеСНИЛСDataGridViewTextBoxColumn.Name = "данныеСНИЛСDataGridViewTextBoxColumn";
            this.данныеСНИЛСDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // специализацияDataGridViewTextBoxColumn
            // 
            this.специализацияDataGridViewTextBoxColumn.DataPropertyName = "Специализация";
            this.специализацияDataGridViewTextBoxColumn.HeaderText = "Специализация";
            this.специализацияDataGridViewTextBoxColumn.Name = "специализацияDataGridViewTextBoxColumn";
            this.специализацияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // почтаDataGridViewTextBoxColumn
            // 
            this.почтаDataGridViewTextBoxColumn.DataPropertyName = "Почта";
            this.почтаDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.почтаDataGridViewTextBoxColumn.Name = "почтаDataGridViewTextBoxColumn";
            this.почтаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видОбученияDataGridViewTextBoxColumn
            // 
            this.видОбученияDataGridViewTextBoxColumn.DataPropertyName = "Вид обучения";
            this.видОбученияDataGridViewTextBoxColumn.HeaderText = "Вид обучения";
            this.видОбученияDataGridViewTextBoxColumn.Name = "видОбученияDataGridViewTextBoxColumn";
            this.видОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // формаОбученияDataGridViewTextBoxColumn
            // 
            this.формаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.HeaderText = "Форма обучения";
            this.формаОбученияDataGridViewTextBoxColumn.Name = "формаОбученияDataGridViewTextBoxColumn";
            this.формаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаНачалаОбученияDataGridViewTextBoxColumn
            // 
            this.датаНачалаОбученияDataGridViewTextBoxColumn.DataPropertyName = "Дата начала обучения";
            this.датаНачалаОбученияDataGridViewTextBoxColumn.HeaderText = "Дата начала обучения";
            this.датаНачалаОбученияDataGridViewTextBoxColumn.Name = "датаНачалаОбученияDataGridViewTextBoxColumn";
            this.датаНачалаОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияОбученияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияОбученияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания обучения";
            this.датаОкончанияОбученияDataGridViewTextBoxColumn.HeaderText = "Дата окончания обучения";
            this.датаОкончанияОбученияDataGridViewTextBoxColumn.Name = "датаОкончанияОбученияDataGridViewTextBoxColumn";
            this.датаОкончанияОбученияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // серияПаспортаDataGridViewTextBoxColumn
            // 
            this.серияПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.Name = "серияПаспортаDataGridViewTextBoxColumn";
            this.серияПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            this.номерПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВыдачиDataGridViewTextBoxColumn
            // 
            this.датаВыдачиDataGridViewTextBoxColumn.DataPropertyName = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.HeaderText = "Дата выдачи";
            this.датаВыдачиDataGridViewTextBoxColumn.Name = "датаВыдачиDataGridViewTextBoxColumn";
            this.датаВыдачиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортВыданDataGridViewTextBoxColumn
            // 
            this.паспортВыданDataGridViewTextBoxColumn.DataPropertyName = "Паспорт выдан";
            this.паспортВыданDataGridViewTextBoxColumn.HeaderText = "Паспорт выдан";
            this.паспортВыданDataGridViewTextBoxColumn.Name = "паспортВыданDataGridViewTextBoxColumn";
            this.паспортВыданDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // местоРегистрацииDataGridViewTextBoxColumn
            // 
            this.местоРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Место регистрации";
            this.местоРегистрацииDataGridViewTextBoxColumn.HeaderText = "Место регистрации";
            this.местоРегистрацииDataGridViewTextBoxColumn.Name = "местоРегистрацииDataGridViewTextBoxColumn";
            this.местоРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // парольDataGridViewTextBoxColumn
            // 
            this.парольDataGridViewTextBoxColumn.DataPropertyName = "Пароль";
            this.парольDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.парольDataGridViewTextBoxColumn.Name = "парольDataGridViewTextBoxColumn";
            this.парольDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewMastersBindingSource
            // 
            this.viewMastersBindingSource.DataMember = "ViewMasters";
            this.viewMastersBindingSource.DataSource = this.workshopDataSet;
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "WorkshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewMastersTableAdapter
            // 
            this.viewMastersTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxEnterID
            // 
            this.textBoxEnterID.Location = new System.Drawing.Point(9, 38);
            this.textBoxEnterID.Name = "textBoxEnterID";
            this.textBoxEnterID.Size = new System.Drawing.Size(187, 20);
            this.textBoxEnterID.TabIndex = 27;
            this.textBoxEnterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEnterID_KeyPress);
            // 
            // FormDelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEnterID);
            this.Controls.Add(this.dataGridViewDelMaster);
            this.Controls.Add(this.labelSelectIDMaster);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormDelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormDelMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMastersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelSelectIDMaster;
        private System.Windows.Forms.DataGridView dataGridViewDelMaster;
        private WorkshopDataSet workshopDataSet;
        private System.Windows.Forms.BindingSource viewMastersBindingSource;
        private WorkshopDataSetTableAdapters.ViewMastersTableAdapter viewMastersTableAdapter;
        private System.Windows.Forms.TextBox textBoxEnterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn данныеСНИЛСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специализацияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияОбученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыдачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортВыданDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРегистрацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
    }
}