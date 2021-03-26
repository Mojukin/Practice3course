using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairmanNearby
{
    public partial class FormCreateOrder : Form
    {
        public FormCreateOrder()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMenuUsers menuUsers = new FormMenuUsers();
            menuUsers.Show();
            this.Close();
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.TypeOfRepair". При необходимости она может быть перемещена или удалена.
            this.typeOfRepairTableAdapter.Fill(this.workshopDataSet.TypeOfRepair);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workshopDataSet.TypeOfDeviceRepaired". При необходимости она может быть перемещена или удалена.
            this.typeOfDeviceRepairedTableAdapter.Fill(this.workshopDataSet.TypeOfDeviceRepaired);
            //Установление прозрачного цвета у label
            labelCreateOrder.BackColor = Color.Transparent;
            labelDescription.BackColor = Color.Transparent;
            labelTypeOfDeviceBeingRepaired.BackColor = Color.Transparent;
            labelTypeOfRepair.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение первых трех полей
            if (textBoxTecnick.Text == "" || comboBoxTypeOfDeviceBeingRepaired.Text == "" || comboBoxTypeOfRepair.Text == "")
            {
                MessageBox.Show("Заполните первые три поля");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        //Создание рандома 
                        Random rnd = new Random();
                        SqlCommand cmdMinID = con.CreateCommand();
                        SqlCommand cmdMaxID = con.CreateCommand();
                        //Выбор из базы данных минимального и максимального значения ID мастера 
                        cmdMinID.CommandText = "SELECT MIN(MasterID) as min FROM Masters";
                        cmdMaxID.CommandText = "SELECT MAX(MasterID) as max FROM Masters";
                        int MinID = Convert.ToInt32(cmdMinID.ExecuteScalar());
                        int MaxID = Convert.ToInt32(cmdMaxID.ExecuteScalar());
                        //Генерация случайного ID мастера из промежутка
                        int id = rnd.Next(MinID, MaxID);
                        SqlCommand cmdOrder = con.CreateCommand();
                        SqlCommand cmdTechn = con.CreateCommand();
                        SqlCommand cmdMail = con.CreateCommand();
                        //Добавление данных в таблицу Orders
                        cmdOrder.CommandText = "insert into [Orders] values ('" + id + "','" + Data.ValueIDUser + "','" + comboBoxTypeOfDeviceBeingRepaired.SelectedValue + "','" + comboBoxTypeOfRepair.SelectedValue + "','" + 1 + "','" + textBoxDescription.Text + "','" + 0 + "','" + DateTime.Now + "','" + DateTime.Now + "')";
                        //Добавление данных в таблицу ListOfTechniques
                        cmdTechn.CommandText = "insert into [ListOfTechniques] values ('" + Data.ValueIDUser + "','" + textBoxTecnick.Text + "','" + textBoxDescriptionTrouble.Text + "')";
                        //Выбор почты мастера по его случайно сгенерированному ID для отправки письма на нее 
                        cmdMail.CommandText = "Select Mail from Masters where MasterID = '" + id + "'";
                        // Подтверждение создания заказа
                        DialogResult result = MessageBox.Show("Создать заказ?", "Подтверждение заказа", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            cmdOrder.ExecuteNonQuery();
                            cmdTechn.ExecuteNonQuery();
                            string Mail = Convert.ToString(cmdMail.ExecuteScalar());
                            // отправитель - устанавливаем адрес и отображаемое в письме имя
                            MailAddress from = new MailAddress("salov2002@internet.ru", "RepairmanNearby");
                            // кому отправляем
                            MailAddress to = new MailAddress(Mail);
                            // создаем объект сообщения
                            MailMessage m = new MailMessage(from, to);
                            // тема письма
                            m.Subject = "Новый заказ";
                            // текст письма
                            m.Body = "<h2>Получен новый заказ</h2>";
                            // письмо представляет код html
                            m.IsBodyHtml = true;
                            // адрес smtp-сервера
                            SmtpClient smtp = new SmtpClient("smtp.mail.ru");
                            // логин и пароль
                            smtp.Credentials = new NetworkCredential("salov2002@internet.ru", "Pasha080402");
                            smtp.EnableSsl = true;
                            smtp.Send(m);
                            Console.Read();
                            FormMenuUsers menuUsers = new FormMenuUsers();
                            menuUsers.Show();
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
    }
}
