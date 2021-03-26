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
    public partial class FormMenuUsers : Form
    {
        public FormMenuUsers()
        {
            InitializeComponent();
        }

        private void buttonCloseAcc_Click(object sender, EventArgs e)
        {
            Form closeAcc = Application.OpenForms[0];
            closeAcc.Show();
            this.Close();
        }

        private void buttonRefactData_Click(object sender, EventArgs e)
        {
            FormRefactorDataUser refactor = new FormRefactorDataUser();
            refactor.Show();
            this.Hide();
        }

        private void FormMenuUsers_Load(object sender, EventArgs e)
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
                SqlCommand cmdOrder = con.CreateCommand();
                //Выбор данных из таблицы Clients по введеному Email 
                cmdTelephone.CommandText = "select ContactPhone from [Clients] where Mail ='" + Data.ValueEmail + "'";
                cmdDateOfBirth.CommandText = "select DateOfBirth from [Clients] where Mail ='" + Data.ValueEmail + "'";
                cmdName.CommandText = "select Name from [Clients] where Mail ='" + Data.ValueEmail + "'";
                cmdSurname.CommandText = "select Surname from [Clients] where Mail ='" + Data.ValueEmail + "'";
                cmdPatronymic.CommandText = "select Patronymic from [Clients] where Mail ='" + Data.ValueEmail + "'";
                string Telephone = Convert.ToString(cmdTelephone.ExecuteScalar());
                string DateOfBirth = Convert.ToString(cmdDateOfBirth.ExecuteScalar());
                string Name = Convert.ToString(cmdName.ExecuteScalar());
                string Surname = Convert.ToString(cmdSurname.ExecuteScalar());
                string Patronymic = Convert.ToString(cmdPatronymic.ExecuteScalar());
                //Создание листа для хранения полученных данных
                List<string[]> data = new List<string[]>();
                //Создание объекта, выполняющего запрос к БД
                SqlCommand command = new SqlCommand("select * from [ViewOrderByUser] where ClientID ='" + Data.ValueIDUser + "'", con);
                //Получение объекта для чтения данных из БД, содержащих несколько строк и столбцов
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new string[14]);
                    for (int i = 0; i < 14; i++)
                    {
                        data[data.Count - 1][i] = reader[i].ToString();
                    }
                }
                reader.Close();
                con.Close();
                //В цикле foreach добавляем новые строки в DataGridView с помощью метода Add.
                foreach (string[] s in data)
                    dataGridViewMyOrders.Rows.Add(s);
                //Присваивание textBox выбранных значений
                textBoxTelephone.Text = Telephone;
                textBoxDateOfBirth.Text = DateOfBirth;
                textBoxEmail.Text = Data.ValueEmail;
                textBoxNamePeople.Text = Surname + " "+ Name + " " + Patronymic;
            }
            labelMyOrders.BackColor = Color.Transparent;
        }

        //Переход на форму создание заказа
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            FormCreateOrder createOrder =new FormCreateOrder();
            createOrder.Show();
            this.Close();
        }
    }
}
