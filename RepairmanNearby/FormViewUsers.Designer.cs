namespace RepairmanNearby
{
    partial class FormViewUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewUsers));
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.номерКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.почтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.парольОтАккаунтаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet1 = new RepairmanNearby.WorkshopDataSet();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.workshopDataSet = new RepairmanNearby.WorkshopDataSet();
            this.view_usersTableAdapter = new RepairmanNearby.WorkshopDataSetTableAdapters.View_usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКлиентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.почтаDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.парольОтАккаунтаDataGridViewTextBoxColumn,
            this.датаРегистрацииDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.viewUsersBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(775, 339);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // номерКлиентаDataGridViewTextBoxColumn
            // 
            this.номерКлиентаDataGridViewTextBoxColumn.DataPropertyName = "Номер клиента";
            this.номерКлиентаDataGridViewTextBoxColumn.HeaderText = "Номер клиента";
            this.номерКлиентаDataGridViewTextBoxColumn.Name = "номерКлиентаDataGridViewTextBoxColumn";
            this.номерКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
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
            // парольОтАккаунтаDataGridViewTextBoxColumn
            // 
            this.парольОтАккаунтаDataGridViewTextBoxColumn.DataPropertyName = "Пароль от аккаунта";
            this.парольОтАккаунтаDataGridViewTextBoxColumn.HeaderText = "Пароль от аккаунта";
            this.парольОтАккаунтаDataGridViewTextBoxColumn.Name = "парольОтАккаунтаDataGridViewTextBoxColumn";
            this.парольОтАккаунтаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРегистрацииDataGridViewTextBoxColumn
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn.Name = "датаРегистрацииDataGridViewTextBoxColumn";
            this.датаРегистрацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewUsersBindingSource
            // 
            this.viewUsersBindingSource.DataMember = "View users";
            this.viewUsersBindingSource.DataSource = this.workshopDataSet1;
            // 
            // workshopDataSet1
            // 
            this.workshopDataSet1.DataSetName = "WorkshopDataSet";
            this.workshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 46);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Вернуться в меню";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "WorkshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_usersTableAdapter
            // 
            this.view_usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridViewUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormViewUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonCancel;
        private WorkshopDataSet workshopDataSet;
        private WorkshopDataSet workshopDataSet1;
        private System.Windows.Forms.BindingSource viewUsersBindingSource;
        private WorkshopDataSetTableAdapters.View_usersTableAdapter view_usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn почтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольОтАккаунтаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn;
    }
}