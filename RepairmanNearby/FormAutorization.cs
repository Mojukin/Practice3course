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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
 
        private void Autorization_Click(object sender, EventArgs e)
        {
            // Авторизация в аккаунте за администратора
            if (textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {
                if (textBoxEmail.Text == "admin" && textBoxPassword.Text == "admin")
                {
                    FormMenuAdmin MenuAdmin = new FormMenuAdmin();
                    MenuAdmin.Show();
                    this.Hide();
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            SqlCommand cmdIDUser = con.CreateCommand();
                            SqlCommand cmdIDMaster = con.CreateCommand();
                            cmd.CommandText = "select AccountPassword from [Clients] where Mail ='" + textBoxEmail.Text + "'"; //Выбор пароля из таблицы клиентов по введеному Email
                            cmdIDUser.CommandText = "select ClientID from [Clients] where Mail ='" + textBoxEmail.Text + "'"; //Выбор ID из таблицы клиентов по введеному Email
                            string password = Convert.ToString(cmd.ExecuteScalar());
                            string IDUser = Convert.ToString(cmdIDUser.ExecuteScalar());
                            Data.ValueEmail = textBoxEmail.Text;//Сохранение Email пользователя для дальнейшего использования
                            Data.ValuePassword = textBoxPassword.Text;//Сохранение пароля пользователя для дальнейшего использования
                            if (password != "")
                            {
                                //Вход в аккаунт клиента
                                if (textBoxPassword.Text == password)
                                {
                                    Data.ValueIDUser = Convert.ToInt32(IDUser);//Сохранение ID пользователя для дальнейшего использования
                                    FormMenuUsers menuUsers = new FormMenuUsers();
                                    menuUsers.Show();
                                    this.Hide();
                                }
                                else { MessageBox.Show("Неверный пароль!"); }
                            }
                            else
                            {
                                cmd.CommandText = "select AccountPassword from [Masters] where Mail ='" + textBoxEmail.Text + "'";//Выбор пароля из таблицы мастера по введеному Email
                                cmdIDMaster.CommandText = "select MasterID from [Masters] where Mail ='" + textBoxEmail.Text + "'"; //Выбор ID из таблицы мастеров по введеному Email
                                string password2 = Convert.ToString(cmd.ExecuteScalar());
                                string IDMaster = Convert.ToString(cmdIDMaster.ExecuteScalar());
                                Data.ValueIDMasterOnAurization = Convert.ToInt32(IDMaster);//Сохранение ID мастера для дальнейшего использования
                                Data.ValueEmail = textBoxEmail.Text;//Сохранение Email мастера для дальнейшего использования
                                Data.ValuePassword = textBoxPassword.Text;//Сохранение пароля мастера для дальнейшего использования
                                if (password2 != "")
                                {
                                    //Вход в аккаунт Мастера
                                    if (textBoxPassword.Text == password2)
                                    {
                                        FormMenuMaster menuMaster = new FormMenuMaster();
                                        menuMaster.Show();
                                        this.Hide();
                                    }
                                    else { MessageBox.Show("Неверный пароль!"); }
                                }
                                else { MessageBox.Show("Неверный Email!"); }
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

        private void labelRegister_Click(object sender, EventArgs e)
        {
            FormRegistration reg = new FormRegistration();
            reg.Show();
            this.Hide();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
            //Установление прозрачного цвета у label
            labelEmail.BackColor = Color.Transparent;
            labelPassword.BackColor = Color.Transparent;
            labelOpenAcc.BackColor = Color.Transparent;
            labelNoAcc.BackColor = Color.Transparent;
            labelRegister.BackColor = Color.Transparent;
            pictureBoxEmail.BackColor = Color.Transparent;
            pictureBoxPassword.BackColor = Color.Transparent;
        }
    }
}
    

