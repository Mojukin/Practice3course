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
    public partial class FormRefactorDataMaster : Form
    {
        public FormRefactorDataMaster()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMenuMaster formMenu = new FormMenuMaster();
            formMenu.Show();
            this.Close();
        }

        private void buttonRefactor_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "" || textBoxName.Text == "" || textBoxNewPassword.Text == "" || textBoxOldPassword.Text == "" || textBoxSurname.Text == "" || textBoxTelephone.Text == "" || textBoxSurname.Text == "")
            {
                MessageBox.Show("Заполните все данные");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
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
                        cmdSurname.CommandText = "update Masters Set Surname ='" + textBoxSurname.Text + "'where Mail = '" + Data.ValueEmail + "'";
                        cmdName.CommandText = "update Masters Set Name ='" + textBoxName.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdPatronymic.CommandText = "update Masters Set Patronymic ='" + textBoxPatronymic.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdDateOfBirth.CommandText = "update Masters Set DateOfBirth ='" + dateTimePickerDateOfBirth.Value + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdMail.CommandText = "update Masters Set Mail ='" + textBoxMail.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdTelephone.CommandText = "update Masters Set ContactPhone ='" + textBoxTelephone.Text + "'where Mail ='" + Data.ValueEmail + "'";
                        cmdPassword.CommandText = "update Masters Set AccountPassword ='" + textBoxNewPassword.Text + "'where Mail ='" + Data.ValueEmail + "'";
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
                            FormAutorization formAutoriz = new FormAutorization();
                            formAutoriz.Show();
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

        private void textBoxMail_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxMail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Не верно введен Email.\nФормат x@x.x");
            }
        }

        private void textBoxNewPassword_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxNewPassword.Text, @"(?=^.{6,}$)((?=.*[a-z])(?=.*[A-Z])(?!.*\s).*$)"))
            {
                MessageBox.Show("Не верно введен пароль!\nПароль должен содежать более: 6 символов, минимум 1 строчную, минимум 1 прописную, минимум 1 цифру");
            }
        }

        private void textBoxOldPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text != Data.ValuePassword)
            {
                MessageBox.Show("Не верно введен старый пароль!");
            }
        }

        private void textBoxReturnNewPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != textBoxReturnNewPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        private void FormRefactorDataMaster_Load(object sender, EventArgs e)
        {
            textBoxNewPassword.ShortcutsEnabled = false;
            textBoxReturnNewPassword.ShortcutsEnabled = false;
            textBoxOldPassword.ShortcutsEnabled = false;
        }
    }
}
