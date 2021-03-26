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
    public partial class FormRefactorDataUser : Form
    {
        public FormRefactorDataUser()
        {
            InitializeComponent();
        }

        private void FormRefactorDataUser_Load(object sender, EventArgs e)
        {
            labelRefactorData.BackColor = Color.Transparent;
            textBoxOldPassword.ShortcutsEnabled = false;
            textBoxReturnPassword.ShortcutsEnabled = false;
            textBoxPassword.ShortcutsEnabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[1];
            cancel.Show();
            this.Close();
        }

        private void buttonRefactorData_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
            {
                if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxEmail.Text == "" || textBoxTelephone.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Заполните все данные");
                }
                else
                {


                    try
                    {
                        con.Open();
                        SqlCommand cmdSurname = con.CreateCommand();
                        SqlCommand cmdName = con.CreateCommand();
                        SqlCommand cmdPatronymic = con.CreateCommand();
                        SqlCommand cmdDateOfBirth = con.CreateCommand();
                        SqlCommand cmdMail = con.CreateCommand();
                        SqlCommand cmdTelephone = con.CreateCommand();
                        SqlCommand cmdPassword = con.CreateCommand();
                        cmdSurname.CommandText = "update Clients Set Surname ='" + textBoxSurname.Text + "'where Mail = '" + Data.ValueEmail + "'";
                        cmdName.CommandText = "update Clients Set Name ='" + textBoxName.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdPatronymic.CommandText = "update Clients Set Patronymic ='" + textBoxPatronymic.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdDateOfBirth.CommandText = "update Clients Set DateOfBirth ='" + dateTimePickerDateOfBirth.Value + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdMail.CommandText = "update Clients Set Mail ='" + textBoxEmail.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdTelephone.CommandText = "update Clients Set ContactPhone ='" + textBoxTelephone.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdPassword.CommandText = "update Clients Set AccountPassword ='" + textBoxPassword.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        // Подверждение изменения данных
                        DialogResult result = MessageBox.Show("Изменить данные?", "Изменение данных", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        if (result == DialogResult.Yes)
                        {
                            cmdSurname.ExecuteNonQuery();
                            cmdName.ExecuteNonQuery();
                            cmdPatronymic.ExecuteNonQuery();
                            cmdDateOfBirth.ExecuteNonQuery();
                            cmdMail.ExecuteNonQuery();
                            cmdTelephone.ExecuteNonQuery();
                            cmdPassword.ExecuteNonQuery();
                            Form back = Application.OpenForms[0];
                            back.Show();
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
        //Проверка на корректность нового Email
        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Не верно введен Email.\nФормат x@x.x");
            }
        }
        //Проверка на корректность нового пароля
        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxPassword.Text, @"(?=^.{6,}$)((?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$)"))
            {
                MessageBox.Show("Не верно введен пароль!\nПароль должен содежать более: 6 символов, минимум 1 строчную, минимум 1 прописную, минимум 1 цифру");
            }
        }
        //Проверка на корректность ввода старого пароля
        private void textBoxOldPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text != Data.ValuePassword)
            {
                MessageBox.Show("Не верно введен старый пароль!");
            }
        }
        //Проверка на совпадение паролей
        private void textBoxReturnPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxReturnPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                textBoxReturnPassword.Focus();
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
