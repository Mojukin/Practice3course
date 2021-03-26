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
    public partial class FormRefactorOrderByMaster : Form
    {
        public FormRefactorOrderByMaster()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMenuMaster formMenu = new FormMenuMaster();
            formMenu.Show();
            this.Close();
        }

        private void FormRefactorOrderByMaster_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet1.TechnologyStatus". При необходимости она может быть перемещена или удалена.
            this.technologyStatusTableAdapter.Fill(this.workshopDataSet1.TechnologyStatus);
            labelCompletionDate.BackColor = Color.Transparent;
            labelCost.BackColor = Color.Transparent;
            labelOrderID.BackColor = Color.Transparent;
            labelRefactorOrder.BackColor = Color.Transparent;
            labelStatus.BackColor = Color.Transparent;
            labelDescriptionWork.BackColor = Color.Transparent;
            labelWorkDone.BackColor = Color.Transparent;
            labelWorkResult.BackColor = Color.Transparent;
            
        }

        private void buttonRefactorOrder_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "" || textBoxOrderID.Text == "" || textBoxWorkDone.Text == "" || comboBoxStatus.Text == "" || comboBoxWorkResult.Text == "")
            {
                MessageBox.Show("Введите все данные!");
            }
            else
            {

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmdTechnStatus = con.CreateCommand();
                        SqlCommand cmdWorkDone = con.CreateCommand();
                        SqlCommand cmdCost = con.CreateCommand();
                        SqlCommand cmdDateEnd = con.CreateCommand();
                        int OrderID = Convert.ToInt32(textBoxOrderID.Text);
                        cmdTechnStatus.CommandText = "update Orders Set TechnologyStatusID ='" + comboBoxStatus.SelectedValue + "'where OrderID = '" + OrderID + "'";
                        cmdWorkDone.CommandText = "insert into [ListOfWorkDone] values ('" + OrderID + "','" + textBoxWorkDone.Text + "','" + comboBoxWorkResult.Text + "','" + textBoxDescriptionWork.Text + "')";
                        cmdCost.CommandText = "update Orders Set Cost ='" + Convert.ToInt32(textBoxCost.Text) + "'where OrderID ='" + OrderID + "'";
                        cmdDateEnd.CommandText = "update Orders Set CompletionDate ='" + dateTimePickerCompletionDate.Value + "'where OrderID ='" + OrderID + "'";

                        // Подверждение изменения данных
                        DialogResult result = MessageBox.Show("Подтвердить изменение заказа?", "Изменение заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            cmdCost.ExecuteNonQuery();
                            cmdDateEnd.ExecuteNonQuery();
                            cmdTechnStatus.ExecuteNonQuery();
                            cmdWorkDone.ExecuteNonQuery();
                            FormMenuMaster menuMaster = new FormMenuMaster();
                            menuMaster.Show();
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

        private void textBoxOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
