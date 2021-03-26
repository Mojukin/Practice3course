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
    public partial class FormViewUsers : Form
    {
        public FormViewUsers()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[1];
            cancel.Show();
            this.Close();
        }

        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet1.View_users". При необходимости она может быть перемещена или удалена.
            this.view_usersTableAdapter.Fill(this.workshopDataSet1.View_users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.View_users". При необходимости она может быть перемещена или удалена.
            this.view_usersTableAdapter.Fill(this.workshopDataSet.View_users);

        }
    }
}
