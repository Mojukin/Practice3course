using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace RepairmanNearby
{

    public partial class FormMenuAdmin : Form
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet2;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet3;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet4;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet5;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet6;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet7;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet8;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet9;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet10;
        Microsoft.Office.Interop.Excel.Range xlSheetRange;
        Microsoft.Office.Interop.Excel.Range xlSheetRange2;
        Microsoft.Office.Interop.Excel.Range xlSheetRange3;
        Microsoft.Office.Interop.Excel.Range xlSheetRange4;
        Microsoft.Office.Interop.Excel.Range xlSheetRange5;
        Microsoft.Office.Interop.Excel.Range xlSheetRange6;
        Microsoft.Office.Interop.Excel.Range xlSheetRange7;
        Microsoft.Office.Interop.Excel.Range xlSheetRange8;
        Microsoft.Office.Interop.Excel.Range xlSheetRange9;
        Microsoft.Office.Interop.Excel.Range xlSheetRange10;
        private DataTable GetDataClients()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dtClients = new DataTable();
            try
            {
                string queryClients = @"SELECT * From Clients";
                SqlCommand commClients = new SqlCommand(queryClients, con);
                con.Open();
                //
                SqlDataAdapter dataClients = new SqlDataAdapter(commClients);
                //
                DataSet dsClients = new DataSet();
                //
                dataClients.Fill(dsClients);
                //
                dtClients = dsClients.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dtClients;
        }
        private DataTable GetDataListOfTechniques()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dtListOfTechniques = new DataTable();
            try
            {
                string queryListOfTechniques = @"SELECT * From ListOfTechniques";
                SqlCommand commListOfTechniques = new SqlCommand(queryListOfTechniques, con);
                con.Open();
                //
                SqlDataAdapter dataListOfTechniques = new SqlDataAdapter(commListOfTechniques);
                //
                DataSet dsListOfTechniques = new DataSet();
                //
                dataListOfTechniques.Fill(dsListOfTechniques);
                //
                dtListOfTechniques = dsListOfTechniques.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dtListOfTechniques;
        }
        private DataTable GetDataListOfWorkDone()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From ListOfWorkDone";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }
        private DataTable GetDataMasters()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From Masters";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }
        private DataTable GetDataMastersEducation()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From MastersEducation";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }
        private DataTable GetDataMastersPassportData()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From MastersPassportData";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private DataTable GetDataOrders()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From Orders";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private DataTable GetDataTechnologyStatus()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From TechnologyStatus";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private DataTable GetDataTypeOfDeviceRepaired()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From TypeOfDeviceRepaired";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        private DataTable GetDataTypeOfRepair()
        {
            //строка соединения
            string connString = @"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT * From TypeOfRepair";
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                //
                SqlDataAdapter data = new SqlDataAdapter(comm);
                //
                DataSet ds = new DataSet();
                //
                data.Fill(ds);
                //
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            return dt;
        }

        public FormMenuAdmin()
        {
            InitializeComponent();
        }
        //Открытие формы просмотра пользователей
        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            FormViewUsers ViewUsers = new FormViewUsers();
            ViewUsers.Show();
            this.Hide();
        }
        //Открытие формы просмотра мастеров
        private void buttonShowMasters_Click(object sender, EventArgs e)
        {
            FormViewMasters viewMasters = new FormViewMasters();
            viewMasters.Show();
            this.Hide();
        }
        //Выход из аккаунта
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[0];
            cancel.Show();
            this.Close();
        }
        //Открытие формы Отчета
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.Show();
            this.Hide();
        }

        private void buttonDataToExcel_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);
                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                //Добавляем листы для всех таблиц из БД
                xlSheet2 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet3 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet4 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet5 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet6 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet7 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet8 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet9 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                xlSheet10 = (Excel.Worksheet)this.xlApp.Worksheets.Add();
                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Клиенты";
                //Выгрузка данных
                DataTable dt = GetDataClients();
                int collInd = 0;
                int rowInd = 0;
                string data = "";
                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 2)
                xlSheet2 = (Excel.Worksheet)xlApp.Sheets[2];
                //Название листа
                xlSheet2.Name = "Список техники";
                //Выгрузка данных
                DataTable dtList = GetDataListOfTechniques();
                //называем колонки
                for (int i = 0; i < dtList.Columns.Count; i++)
                {
                    data = dtList.Columns[i].ColumnName.ToString();
                    xlSheet2.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtList.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtList.Columns.Count; collInd++)
                    {
                        data = dtList.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet2.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange2 = xlSheet2.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange2.Columns.AutoFit();
                xlSheetRange2.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 3)
                xlSheet3 = (Excel.Worksheet)xlApp.Sheets[3];
                //Название листа
                xlSheet3.Name = "Список Проделанных работ";
                //Выгрузка данных
                DataTable dtListWorkDone = GetDataListOfWorkDone();
                //называем колонки
                for (int i = 0; i < dtListWorkDone.Columns.Count; i++)
                {
                    data = dtListWorkDone.Columns[i].ColumnName.ToString();
                    xlSheet3.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtListWorkDone.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtListWorkDone.Columns.Count; collInd++)
                    {
                        data = dtListWorkDone.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet3.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange3 = xlSheet3.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange3.Columns.AutoFit();
                xlSheetRange3.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 4)
                xlSheet4 = (Excel.Worksheet)xlApp.Sheets[4];
                //Название листа
                xlSheet4.Name = "Мастера";
                //Выгрузка данных
                DataTable dtMasters = GetDataMasters();
                //называем колонки
                for (int i = 0; i < dtMasters.Columns.Count; i++)
                {
                    data = dtMasters.Columns[i].ColumnName.ToString();
                    xlSheet4.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtMasters.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtMasters.Columns.Count; collInd++)
                    {
                        data = dtMasters.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet4.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange4 = xlSheet4.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange4.Columns.AutoFit();
                xlSheetRange4.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 5)
                xlSheet5 = (Excel.Worksheet)xlApp.Sheets[5];
                //Название листа
                xlSheet5.Name = "Образования мастеров";
                //Выгрузка данных
                DataTable dtMastersEducation = GetDataMastersEducation();
                //называем колонки
                for (int i = 0; i < dtMastersEducation.Columns.Count; i++)
                {
                    data = dtMastersEducation.Columns[i].ColumnName.ToString();
                    xlSheet5.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtMastersEducation.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtMastersEducation.Columns.Count; collInd++)
                    {
                        data = dtMastersEducation.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet5.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange5 = xlSheet5.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange5.Columns.AutoFit();
                xlSheetRange5.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 6)
                xlSheet6 = (Excel.Worksheet)xlApp.Sheets[6];
                //Название листа
                xlSheet6.Name = "Паспортные данные мастеров";
                //Выгрузка данных
                DataTable dtMastersPassportData = GetDataMastersPassportData();
                //называем колонки
                for (int i = 0; i < dtMastersPassportData.Columns.Count; i++)
                {
                    data = dtMastersPassportData.Columns[i].ColumnName.ToString();
                    xlSheet6.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtMastersPassportData.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtMastersPassportData.Columns.Count; collInd++)
                    {
                        data = dtMastersPassportData.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet6.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange6 = xlSheet6.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange6.Columns.AutoFit();
                xlSheetRange6.Rows.AutoFit();
                xlSheetRange6.WrapText = false;
                //выбираем лист на котором будем работать (Лист 7)
                xlSheet7 = (Excel.Worksheet)xlApp.Sheets[7];
                //Название листа
                xlSheet7.Name = "Заказы";
                //Выгрузка данных
                DataTable dtOrders = GetDataOrders();
                //называем колонки
                for (int i = 0; i < dtOrders.Columns.Count; i++)
                {
                    data = dtOrders.Columns[i].ColumnName.ToString();
                    xlSheet7.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtOrders.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtOrders.Columns.Count; collInd++)
                    {
                        data = dtOrders.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet7.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange7 = xlSheet7.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange7.Columns.AutoFit();
                xlSheetRange7.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 8)
                xlSheet8 = (Excel.Worksheet)xlApp.Sheets[8];
                //Название листа
                xlSheet8.Name = "Статус товара";
                //Выгрузка данных
                DataTable dtTechnStatus = GetDataTechnologyStatus();
                //называем колонки
                for (int i = 0; i < dtTechnStatus.Columns.Count; i++)
                {
                    data = dtTechnStatus.Columns[i].ColumnName.ToString();
                    xlSheet8.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtTechnStatus.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtTechnStatus.Columns.Count; collInd++)
                    {
                        data = dtTechnStatus.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet8.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange8 = xlSheet8.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange8.Columns.AutoFit();
                xlSheetRange8.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 9)
                xlSheet9 = (Excel.Worksheet)xlApp.Sheets[9];
                //Название листа
                xlSheet9.Name = "Тип ремонтируемого устройства";
                //Выгрузка данных
                DataTable dtTypeOfDeviceRepaired = GetDataTypeOfDeviceRepaired();
                //называем колонки
                for (int i = 0; i < dtTypeOfDeviceRepaired.Columns.Count; i++)
                {
                    data = dtTypeOfDeviceRepaired.Columns[i].ColumnName.ToString();
                    xlSheet9.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtTypeOfDeviceRepaired.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtTypeOfDeviceRepaired.Columns.Count; collInd++)
                    {
                        data = dtTypeOfDeviceRepaired.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet9.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange9 = xlSheet9.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange9.Columns.AutoFit();
                xlSheetRange9.Rows.AutoFit();
                //выбираем лист на котором будем работать (Лист 10)
                xlSheet10 = (Excel.Worksheet)xlApp.Sheets[10];
                //Название листа
                xlSheet10.Name = "Тип ремонта";
                //Выгрузка данных
                DataTable dtTypeOfRepair = GetDataTypeOfRepair();
                //называем колонки
                for (int i = 0; i < dtTypeOfRepair.Columns.Count; i++)
                {
                    data = dtTypeOfRepair.Columns[i].ColumnName.ToString();
                    xlSheet10.Cells[1, i + 1] = data;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dtTypeOfRepair.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtTypeOfRepair.Columns.Count; collInd++)
                    {
                        data = dtTypeOfRepair.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet10.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                xlSheetRange10 = xlSheet10.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange10.Columns.AutoFit();
                xlSheetRange10.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheetRange2);
                releaseObject(xlSheetRange3);
                releaseObject(xlSheetRange4);
                releaseObject(xlSheetRange5);
                releaseObject(xlSheetRange6);
                releaseObject(xlSheetRange7);
                releaseObject(xlSheetRange8);
                releaseObject(xlSheetRange9);
                releaseObject(xlSheetRange10);
                releaseObject(xlSheet);
                releaseObject(xlSheet2);
                releaseObject(xlSheet3);
                releaseObject(xlSheet4);
                releaseObject(xlSheet5);
                releaseObject(xlSheet6);
                releaseObject(xlSheet7);
                releaseObject(xlSheet8);
                releaseObject(xlSheet9);
                releaseObject(xlSheet10);
                releaseObject(xlApp);
            }
        }
        //Освобождаем ресуры (закрываем Excel)
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
