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
    public partial class FormMenuMaster : Form
    {
        public FormMenuMaster()
        {
            InitializeComponent();
        }

        //Закрытие формы и возвращение в форму авторизации
        private void buttonCloseAcc_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[0];
            cancel.Show();
            this.Close();
        }

        //Открытие формы изменения данных мастера
        private void buttonRefactData_Click(object sender, EventArgs e)
        {
            FormRefactorDataMaster refactorDataMaster = new FormRefactorDataMaster();
            refactorDataMaster.Show();
            this.Close();
        }

        private void FormMenuMaster_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmdTelephone = con.CreateCommand();
                SqlCommand cmdMail = con.CreateCommand();
                SqlCommand cmdDateOfBirth = con.CreateCommand();
                SqlCommand cmdName = con.CreateCommand();
                SqlCommand cmdSurname = con.CreateCommand();
                SqlCommand cmdPatronymic = con.CreateCommand();
                SqlCommand cmdDataSNILS = con.CreateCommand();
                SqlCommand cmdSpecialization = con.CreateCommand();
                //Выбор данных из таблицы Masters по Email
                cmdTelephone.CommandText = "select ContactPhone from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdDateOfBirth.CommandText = "select DateOfBirth from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdName.CommandText = "select Name from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdSurname.CommandText = "select Surname from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdPatronymic.CommandText = "select Patronymic from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdDataSNILS.CommandText = "select DataSNILS from [Masters] where Mail ='" + Data.ValueEmail + "'";
                cmdSpecialization.CommandText = "select Specialization from [Masters] where Mail ='" + Data.ValueEmail + "'";
                string Telephone = Convert.ToString(cmdTelephone.ExecuteScalar());
                string DateOfBirth = Convert.ToString(cmdDateOfBirth.ExecuteScalar());
                string Name = Convert.ToString(cmdName.ExecuteScalar());
                string Surname = Convert.ToString(cmdSurname.ExecuteScalar());
                string Patronymic = Convert.ToString(cmdPatronymic.ExecuteScalar());
                string DataSNILS = Convert.ToString(cmdDataSNILS.ExecuteScalar());
                string Specialization = Convert.ToString(cmdSpecialization.ExecuteScalar());
                
                //Создание листа для хранения полученных данных
                List<string[]> data = new List<string[]>();
                //Создание объекта, выполняющего запрос к БД
                SqlCommand command = new SqlCommand("select * from [ViewOrderByMaster] where MasterID ='" + Data.ValueIDMasterOnAurization + "'", con);
                //Получение объекта для чтения данных из БД, содержащих несколько строк и столбцов
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[15]);
                    for (int i =0; i<15; i++)
                    {
                        data[data.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                con.Close();
                foreach (string[] s in data)
                    dataGridViewMyOrders.Rows.Add(s);
                //Присваивание textBox выбранных значений
                textBoxTelephone.Text = Telephone;
                textBoxDateOfBirth.Text = DateOfBirth;
                textBoxEmail.Text = Data.ValueEmail;
                textBoxNamePeople.Text = Surname + " " + Name + " " + Patronymic;
                textBoxDataSNILS.Text = DataSNILS;
                textBoxSpecialization.Text = Specialization;
            }
            labelMyOrders.BackColor = Color.Transparent;
        }

        //Открытие формы редактирования заказа
        private void buttonRefactorOrder_Click(object sender, EventArgs e)
        {
            FormRefactorOrderByMaster refactorOrderByMaster = new FormRefactorOrderByMaster();
            refactorOrderByMaster.Show();
            this.Close();
        }
    }
}
