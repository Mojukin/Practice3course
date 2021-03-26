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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[0];
            cancel.Show();
            this.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    //Добавление данных в таблицу Clients
                    cmd.CommandText = "insert into [Clients] values ('" + textBoxSurname.Text + "','" + textBoxName.Text + "','" + textBoxPatronymic.Text + "','" + dateTimePickerDateOfBirth.Value + "','"+textBoxEmail.Text+ "','" + textBoxTelephone.Text+ "','" + textBoxPassword.Text+ "','" + DateTime.Now + "')";
                    cmd.ExecuteNonQuery();
                    Form back = Application.OpenForms[0];
                    back.Show();
                    this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Данный Email уже зарегистрирован, пожалуйста введите другой");
                    textBoxEmail.Focus();
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
        //Проверка на корректность ввода EMail
        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
          
            if (!Regex.IsMatch(textBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Не верно введен Email! \n Формат x@x.x");
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
        //Выполнение проверки на совпадение паролей
        private void textBoxReturnPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxReturnPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            labelReg.BackColor = Color.Transparent;
            textBoxReturnPassword.ShortcutsEnabled = false;
            textBoxPassword.ShortcutsEnabled = false;
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
