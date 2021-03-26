using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairmanNearby
{
    public partial class FormViewMasters : Form
    {
        public FormViewMasters()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[1];
            cancel.Show();
            this.Close();
        }

        private void buttonAddMaster_Click(object sender, EventArgs e)
        {
            FormAddMaster addMaster = new FormAddMaster();
            addMaster.Show();
            this.Close();
        }

        private void buttonDelMaster_Click(object sender, EventArgs e)
        {
            FormDelMaster delMaster = new FormDelMaster();
            delMaster.Show();
            this.Close();
        }

        private void FormViewMasters_Load(object sender, EventArgs e)
        {
            dataGridView1.Update();
            this.viewMastersTableAdapter.Fill(this.workshopDataSet1.ViewMasters);
            //Вычисление ID мастера для создания связи при создании нового мастера
            int lastRow = dataGridView1.Rows.Count +1;
            Data.ValueIDMaster = lastRow;

        }
    }
}
