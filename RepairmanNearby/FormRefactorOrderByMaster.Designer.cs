namespace RepairmanNearby
{
    partial class FormRefactorOrderByMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRefactorOrderByMaster));
            this.labelRefactorOrder = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRefactorOrder = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.dateTimePickerCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.labelCompletionDate = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.technologyStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet1 = new RepairmanNearby.WorkshopDataSet();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.workshopDataSet = new RepairmanNearby.WorkshopDataSet();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.textBoxWorkDone = new System.Windows.Forms.TextBox();
            this.labelWorkDone = new System.Windows.Forms.Label();
            this.labelWorkResult = new System.Windows.Forms.Label();
            this.technologyStatusTableAdapter = new RepairmanNearby.WorkshopDataSetTableAdapters.TechnologyStatusTableAdapter();
            this.comboBoxWorkResult = new System.Windows.Forms.ComboBox();
            this.textBoxDescriptionWork = new System.Windows.Forms.TextBox();
            this.labelDescriptionWork = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technologyStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRefactorOrder
            // 
            this.labelRefactorOrder.AutoSize = true;
            this.labelRefactorOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelRefactorOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRefactorOrder.Location = new System.Drawing.Point(374, 149);
            this.labelRefactorOrder.Name = "labelRefactorOrder";
            this.labelRefactorOrder.Size = new System.Drawing.Size(256, 26);
            this.labelRefactorOrder.TabIndex = 0;
            this.labelRefactorOrder.Text = "Редактирование заказа";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 429);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 52);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRefactorOrder
            // 
            this.buttonRefactorOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRefactorOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRefactorOrder.Location = new System.Drawing.Point(723, 429);
            this.buttonRefactorOrder.Name = "buttonRefactorOrder";
            this.buttonRefactorOrder.Size = new System.Drawing.Size(141, 52);
            this.buttonRefactorOrder.TabIndex = 2;
            this.buttonRefactorOrder.Text = "Редактировать";
            this.buttonRefactorOrder.UseVisualStyleBackColor = false;
            this.buttonRefactorOrder.Click += new System.EventHandler(this.buttonRefactorOrder_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(197, 219);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус заказа";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(244, 324);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(33, 13);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Цена";
            // 
            // dateTimePickerCompletionDate
            // 
            this.dateTimePickerCompletionDate.Location = new System.Drawing.Point(283, 347);
            this.dateTimePickerCompletionDate.Name = "dateTimePickerCompletionDate";
            this.dateTimePickerCompletionDate.Size = new System.Drawing.Size(428, 20);
            this.dateTimePickerCompletionDate.TabIndex = 6;
            // 
            // labelCompletionDate
            // 
            this.labelCompletionDate.AutoSize = true;
            this.labelCompletionDate.Location = new System.Drawing.Point(188, 349);
            this.labelCompletionDate.Name = "labelCompletionDate";
            this.labelCompletionDate.Size = new System.Drawing.Size(89, 13);
            this.labelCompletionDate.TabIndex = 8;
            this.labelCompletionDate.Text = "Дата окончания";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataSource = this.technologyStatusBindingSource;
            this.comboBoxStatus.DisplayMember = "TechnologyStatus";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(283, 216);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(428, 21);
            this.comboBoxStatus.TabIndex = 9;
            this.comboBoxStatus.ValueMember = "TechnologyStatusID";
            // 
            // technologyStatusBindingSource
            // 
            this.technologyStatusBindingSource.DataMember = "TechnologyStatus";
            this.technologyStatusBindingSource.DataSource = this.workshopDataSet1;
            // 
            // workshopDataSet1
            // 
            this.workshopDataSet1.DataSetName = "WorkshopDataSet";
            this.workshopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(283, 321);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(428, 20);
            this.textBoxCost.TabIndex = 10;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(197, 193);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(80, 13);
            this.labelOrderID.TabIndex = 11;
            this.labelOrderID.Text = "Номер заказа";
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "WorkshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(283, 190);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(428, 20);
            this.textBoxOrderID.TabIndex = 12;
            this.textBoxOrderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOrderID_KeyPress);
            // 
            // textBoxWorkDone
            // 
            this.textBoxWorkDone.Location = new System.Drawing.Point(283, 243);
            this.textBoxWorkDone.Name = "textBoxWorkDone";
            this.textBoxWorkDone.Size = new System.Drawing.Size(428, 20);
            this.textBoxWorkDone.TabIndex = 14;
            // 
            // labelWorkDone
            // 
            this.labelWorkDone.AutoSize = true;
            this.labelWorkDone.Location = new System.Drawing.Point(164, 246);
            this.labelWorkDone.Name = "labelWorkDone";
            this.labelWorkDone.Size = new System.Drawing.Size(113, 13);
            this.labelWorkDone.TabIndex = 13;
            this.labelWorkDone.Text = "Проделанная работа";
            // 
            // labelWorkResult
            // 
            this.labelWorkResult.AutoSize = true;
            this.labelWorkResult.Location = new System.Drawing.Point(178, 272);
            this.labelWorkResult.Name = "labelWorkResult";
            this.labelWorkResult.Size = new System.Drawing.Size(99, 13);
            this.labelWorkResult.TabIndex = 15;
            this.labelWorkResult.Text = "Результат работы";
            // 
            // technologyStatusTableAdapter
            // 
            this.technologyStatusTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxWorkResult
            // 
            this.comboBoxWorkResult.FormattingEnabled = true;
            this.comboBoxWorkResult.Items.AddRange(new object[] {
            "Успешно",
            "Неуспешно"});
            this.comboBoxWorkResult.Location = new System.Drawing.Point(283, 268);
            this.comboBoxWorkResult.Name = "comboBoxWorkResult";
            this.comboBoxWorkResult.Size = new System.Drawing.Size(428, 21);
            this.comboBoxWorkResult.TabIndex = 16;
            // 
            // textBoxDescriptionWork
            // 
            this.textBoxDescriptionWork.Location = new System.Drawing.Point(283, 295);
            this.textBoxDescriptionWork.Name = "textBoxDescriptionWork";
            this.textBoxDescriptionWork.Size = new System.Drawing.Size(428, 20);
            this.textBoxDescriptionWork.TabIndex = 18;
            // 
            // labelDescriptionWork
            // 
            this.labelDescriptionWork.AutoSize = true;
            this.labelDescriptionWork.Location = new System.Drawing.Point(104, 298);
            this.labelDescriptionWork.Name = "labelDescriptionWork";
            this.labelDescriptionWork.Size = new System.Drawing.Size(173, 13);
            this.labelDescriptionWork.TabIndex = 17;
            this.labelDescriptionWork.Text = "Описание к проделанной работе";
            // 
            // FormRefactorOrderByMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 493);
            this.Controls.Add(this.textBoxDescriptionWork);
            this.Controls.Add(this.labelDescriptionWork);
            this.Controls.Add(this.comboBoxWorkResult);
            this.Controls.Add(this.labelWorkResult);
            this.Controls.Add(this.textBoxWorkDone);
            this.Controls.Add(this.labelWorkDone);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelCompletionDate);
            this.Controls.Add(this.dateTimePickerCompletionDate);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonRefactorOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelRefactorOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(892, 532);
            this.MinimumSize = new System.Drawing.Size(892, 532);
            this.Name = "FormRefactorOrderByMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormRefactorOrderByMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technologyStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRefactorOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRefactorOrder;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.DateTimePicker dateTimePickerCompletionDate;
        private System.Windows.Forms.Label labelCompletionDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelOrderID;
        private WorkshopDataSet workshopDataSet;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.TextBox textBoxWorkDone;
        private System.Windows.Forms.Label labelWorkDone;
        private System.Windows.Forms.Label labelWorkResult;
        private WorkshopDataSet workshopDataSet1;
        private System.Windows.Forms.BindingSource technologyStatusBindingSource;
        private WorkshopDataSetTableAdapters.TechnologyStatusTableAdapter technologyStatusTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxWorkResult;
        private System.Windows.Forms.TextBox textBoxDescriptionWork;
        private System.Windows.Forms.Label labelDescriptionWork;
    }
}