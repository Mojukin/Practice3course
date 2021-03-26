using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairmanNearby
{
    public partial class FormDelMaster : Form
    {
        public FormDelMaster()
        {
            InitializeComponent();
        }
        //Выход с формы удаления мастеров
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormViewMasters viewMasters = new FormViewMasters();
            viewMasters.Show();
            this.Close();
        }

        private void FormDelMaster_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.ViewMasters". При необходимости она может быть перемещена или удалена.
            this.viewMastersTableAdapter.Fill(this.workshopDataSet.ViewMasters);
            labelSelectIDMaster.BackColor = Color.Transparent;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Проверка на ввод ID мастера
            if (textBoxEnterID.Text == "")
            {
              DialogResult result = MessageBox.Show("Введите ID мастера которого хотите удалить", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                    textBoxEnterID.Focus();
            }
            //Выполнение удаления мастера, если он введен
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
                {
                    try
                    {
                        int IDMaster = Convert.ToInt32(textBoxEnterID.Text);
                        con.Open();
                        SqlCommand cmdMasters = con.CreateCommand();
                        SqlCommand cmdPassportMasters = con.CreateCommand();
                        SqlCommand cmdEducationMasters = con.CreateCommand();
                        //Удаление данных мастера
                        cmdMasters.CommandText = "DELETE FROM [Masters] WHERE MasterID = '" + IDMaster + "'";
                        cmdPassportMasters.CommandText = "DELETE FROM [MastersPassportData] WHERE MasterID = '" + IDMaster + "'";
                        cmdEducationMasters.CommandText = "DELETE FROM [MastersEducation] WHERE MasterID = '" + IDMaster + "'";
                        //Подверждение удаления мастера
                        DialogResult result =  MessageBox.Show("Удалить мастера?", "Удаление мастера", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1 ,MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            cmdPassportMasters.ExecuteNonQuery();
                            cmdEducationMasters.ExecuteNonQuery();
                            cmdMasters.ExecuteNonQuery();
                            FormViewMasters viewMasters = new FormViewMasters();
                            viewMasters.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void textBoxEnterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
