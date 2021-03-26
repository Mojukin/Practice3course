namespace RepairmanNearby
{
    partial class FormCreateOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateOrder));
            this.labelCreateOrder = new System.Windows.Forms.Label();
            this.labelTypeOfDeviceBeingRepaired = new System.Windows.Forms.Label();
            this.labelTypeOfRepair = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.comboBoxTypeOfDeviceBeingRepaired = new System.Windows.Forms.ComboBox();
            this.typeOfDeviceRepairedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workshopDataSet = new RepairmanNearby.WorkshopDataSet();
            this.comboBoxTypeOfRepair = new System.Windows.Forms.ComboBox();
            this.typeOfRepairBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.typeOfDeviceRepairedTableAdapter = new RepairmanNearby.WorkshopDataSetTableAdapters.TypeOfDeviceRepairedTableAdapter();
            this.typeOfRepairTableAdapter = new RepairmanNearby.WorkshopDataSetTableAdapters.TypeOfRepairTableAdapter();
            this.textBoxTecnick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescriptionTrouble = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDeviceRepairedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRepairBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCreateOrder
            // 
            this.labelCreateOrder.AutoSize = true;
            this.labelCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelCreateOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCreateOrder.Location = new System.Drawing.Point(259, 126);
            this.labelCreateOrder.Name = "labelCreateOrder";
            this.labelCreateOrder.Size = new System.Drawing.Size(199, 26);
            this.labelCreateOrder.TabIndex = 0;
            this.labelCreateOrder.Text = "Создание заказов";
            // 
            // labelTypeOfDeviceBeingRepaired
            // 
            this.labelTypeOfDeviceBeingRepaired.AutoSize = true;
            this.labelTypeOfDeviceBeingRepaired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelTypeOfDeviceBeingRepaired.Location = new System.Drawing.Point(9, 167);
            this.labelTypeOfDeviceBeingRepaired.Name = "labelTypeOfDeviceBeingRepaired";
            this.labelTypeOfDeviceBeingRepaired.Size = new System.Drawing.Size(226, 16);
            this.labelTypeOfDeviceBeingRepaired.TabIndex = 1;
            this.labelTypeOfDeviceBeingRepaired.Text = "Тип ремонтируемого устройства";
            // 
            // labelTypeOfRepair
            // 
            this.labelTypeOfRepair.AutoSize = true;
            this.labelTypeOfRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelTypeOfRepair.Location = new System.Drawing.Point(143, 196);
            this.labelTypeOfRepair.Name = "labelTypeOfRepair";
            this.labelTypeOfRepair.Size = new System.Drawing.Size(92, 16);
            this.labelTypeOfRepair.TabIndex = 2;
            this.labelTypeOfRepair.Text = "Тип ремонта";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.labelDescription.Location = new System.Drawing.Point(112, 274);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(123, 16);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание заказа";
            // 
            // comboBoxTypeOfDeviceBeingRepaired
            // 
            this.comboBoxTypeOfDeviceBeingRepaired.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeOfDeviceRepairedBindingSource, "TypeOfDeviceBeingRepaired", true));
            this.comboBoxTypeOfDeviceBeingRepaired.DataSource = this.typeOfDeviceRepairedBindingSource;
            this.comboBoxTypeOfDeviceBeingRepaired.DisplayMember = "TypeOfDeviceBeingRepaired";
            this.comboBoxTypeOfDeviceBeingRepaired.FormattingEnabled = true;
            this.comboBoxTypeOfDeviceBeingRepaired.Location = new System.Drawing.Point(241, 166);
            this.comboBoxTypeOfDeviceBeingRepaired.Name = "comboBoxTypeOfDeviceBeingRepaired";
            this.comboBoxTypeOfDeviceBeingRepaired.Size = new System.Drawing.Size(385, 21);
            this.comboBoxTypeOfDeviceBeingRepaired.TabIndex = 4;
            this.comboBoxTypeOfDeviceBeingRepaired.ValueMember = "TypeOfDeviceBeingRepairedID";
            // 
            // typeOfDeviceRepairedBindingSource
            // 
            this.typeOfDeviceRepairedBindingSource.DataMember = "TypeOfDeviceRepaired";
            this.typeOfDeviceRepairedBindingSource.DataSource = this.workshopDataSet;
            // 
            // workshopDataSet
            // 
            this.workshopDataSet.DataSetName = "WorkshopDataSet";
            this.workshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxTypeOfRepair
            // 
            this.comboBoxTypeOfRepair.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeOfRepairBindingSource, "TypeOfRepair", true));
            this.comboBoxTypeOfRepair.DataSource = this.typeOfRepairBindingSource;
            this.comboBoxTypeOfRepair.DisplayMember = "TypeOfRepair";
            this.comboBoxTypeOfRepair.FormattingEnabled = true;
            this.comboBoxTypeOfRepair.Location = new System.Drawing.Point(241, 195);
            this.comboBoxTypeOfRepair.Name = "comboBoxTypeOfRepair";
            this.comboBoxTypeOfRepair.Size = new System.Drawing.Size(385, 21);
            this.comboBoxTypeOfRepair.TabIndex = 5;
            this.comboBoxTypeOfRepair.ValueMember = "TypeOfRepairID";
            // 
            // typeOfRepairBindingSource
            // 
            this.typeOfRepairBindingSource.DataMember = "TypeOfRepair";
            this.typeOfRepairBindingSource.DataSource = this.workshopDataSet;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(241, 273);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(385, 20);
            this.textBoxDescription.TabIndex = 8;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateOrder.Location = new System.Drawing.Point(515, 396);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(111, 52);
            this.buttonCreateOrder.TabIndex = 9;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 52);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // typeOfDeviceRepairedTableAdapter
            // 
            this.typeOfDeviceRepairedTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfRepairTableAdapter
            // 
            this.typeOfRepairTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTecnick
            // 
            this.textBoxTecnick.Location = new System.Drawing.Point(241, 222);
            this.textBoxTecnick.Name = "textBoxTecnick";
            this.textBoxTecnick.Size = new System.Drawing.Size(385, 20);
            this.textBoxTecnick.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(88, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Техника для ремонта";
            // 
            // textBoxDescriptionTrouble
            // 
            this.textBoxDescriptionTrouble.Location = new System.Drawing.Point(241, 247);
            this.textBoxDescriptionTrouble.Name = "textBoxDescriptionTrouble";
            this.textBoxDescriptionTrouble.Size = new System.Drawing.Size(385, 20);
            this.textBoxDescriptionTrouble.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(93, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание проблемы";
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RepairmanNearby.Properties.Resources.Backfone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 460);
            this.Controls.Add(this.textBoxDescriptionTrouble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTecnick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxTypeOfRepair);
            this.Controls.Add(this.comboBoxTypeOfDeviceBeingRepaired);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTypeOfRepair);
            this.Controls.Add(this.labelTypeOfDeviceBeingRepaired);
            this.Controls.Add(this.labelCreateOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(654, 499);
            this.MinimumSize = new System.Drawing.Size(654, 499);
            this.Name = "FormCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairmanNearby";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDeviceRepairedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfRepairBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateOrder;
        private System.Windows.Forms.Label labelTypeOfDeviceBeingRepaired;
        private System.Windows.Forms.Label labelTypeOfRepair;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ComboBox comboBoxTypeOfDeviceBeingRepaired;
        private System.Windows.Forms.ComboBox comboBoxTypeOfRepair;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonCancel;
        private WorkshopDataSet workshopDataSet;
        private System.Windows.Forms.BindingSource typeOfDeviceRepairedBindingSource;
        private WorkshopDataSetTableAdapters.TypeOfDeviceRepairedTableAdapter typeOfDeviceRepairedTableAdapter;
        private System.Windows.Forms.BindingSource typeOfRepairBindingSource;
        private WorkshopDataSetTableAdapters.TypeOfRepairTableAdapter typeOfRepairTableAdapter;
        private System.Windows.Forms.TextBox textBoxTecnick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescriptionTrouble;
        private System.Windows.Forms.Label label2;
    }
}