using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairmanNearby
{
    public partial class FormAddMaster : Form
    {
        public FormAddMaster()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormViewMasters viewMasters = new FormViewMasters();
            viewMasters.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           // Проверка на заполнение всех данных
            if (textBoxSurname.Text == "" || textBoxDataSNILS.Text == "" || textBoxName.Text == "" || textBoxSpecialization.Text == "" || textBoxPasportNomber.Text == "" || textBoxPassportIssued.Text == "" || textBoxRegistredAt.Text == "" || textBoxPassportSeries.Text == ""||textBoxTelephone.Text==""||comboBoxFormEducation.Text==""||comboBoxKindOfEducation.Text==""||textBoxPassword.Text==""||textBoxMail.Text=="")
            {
                buttonAdd.Enabled = false;
                MessageBox.Show("Заполните все данные");
            }
            if (dateTimePickerDateStartEducation.Value==dateTimePickerDateEndEducation.Value)
            {
                MessageBox.Show("Начало обучения не может совпадать с его окончанием");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmdMasters = con.CreateCommand();
                        SqlCommand cmdPassportMasters = con.CreateCommand();
                        SqlCommand cmdEducationMasters = con.CreateCommand();
                        //Добавление данных в таблицу Masters
                        cmdMasters.CommandText = "insert into [Masters] values ('" + Data.ValueIDMaster + "','" + textBoxSurname.Text + "','" + textBoxName.Text + "','" + textBoxPatronymic.Text + "','" + dateTimePickerDateOfBirth.Value + "','" + textBoxDataSNILS.Text + "','" + textBoxSpecialization.Text + "','" + textBoxMail.Text + "','" + textBoxTelephone.Text + "','" + textBoxPassword.Text + "','" + DateTime.Now + "')";
                        //Добавление данных в таблицу MastersPasportData
                        cmdPassportMasters.CommandText = "insert into [MastersPassportData] values ('" + Data.ValueIDMaster + "', '" + textBoxPassportSeries.Text + "','" + textBoxPasportNomber.Text + "','" + dateTimePickerExtraditionDate.Value + "','" + textBoxPassportIssued.Text + "','" + textBoxRegistredAt.Text + "')";
                        //Добавление данных в таблицу MastersEduccation
                        cmdEducationMasters.CommandText = "insert into [MastersEducation] values ('" + Data.ValueIDMaster + "','" + comboBoxKindOfEducation.Text + "','" + comboBoxFormEducation.Text + "','" + dateTimePickerDateStartEducation.Value+ "','" + dateTimePickerDateEndEducation.Value + "')";
                        cmdMasters.ExecuteNonQuery();
                        cmdPassportMasters.ExecuteNonQuery();
                        cmdEducationMasters.ExecuteNonQuery();
                        FormViewMasters viewMasters = new FormViewMasters();
                        viewMasters.Show();
                        this.Close();
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

        //Проверка на корректность ввода пароля
        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxPassword.Text, @"(?=^.{6,}$)((?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$)"))
            {
                MessageBox.Show("Не верно введен пароль!\nПароль должен содежать более: 6 символов, минимум 1 строчную, минимум 1 прописную, минимум 1 цифру");
            }
        }

        //Проверка на корректность ввода Email
        private void textBoxMail_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxMail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Не верно введен Email!\nФормат x@x.x");
            }
        }

        //Запрет на нажатие всех клавишь кроме цифр и BackSpace
        private void textBoxDataSNILS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //Запрет на нажатие всех клавишь кроме цифр и BackSpace
        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //Запрет на нажатие всех клавишь кроме цифр и BackSpace
        private void textBoxPassportSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        //Запрет на нажатие всех клавишь кроме цифр и BackSpace
        private void textBoxPasportNomber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void FormAddMaster_Load(object sender, EventArgs e)
        {
            labelAddMaster.BackColor = Color.Transparent; //Установление прозрачного цвета у label
        }
    }
}
