using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RepairmanNearby
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            labelCountAddMaster.BackColor = Color.Transparent;
            labelCountUserReg.BackColor = Color.Transparent;
            labelProfitForTheP.BackColor = Color.Transparent;
        }
       // Метод для добавления строк
        public void AddRow(PdfPTable table, string CellName1, string CellName2,  string CellName3 , iTextSharp.text.Font font)
        {
            var cells = new PdfPCell[3];
            cells[0] = new PdfPCell(new Phrase(CellName1+ " человек", font));
            cells[1] = new PdfPCell(new Phrase(CellName2 + " человек", font));
            cells[2] = new PdfPCell(new Phrase(CellName3 + " Руб.", font));
            foreach (var el in cells)
            {
                el.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                el.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                el.Border = 0;
                el.PaddingTop = 20;
                el.PaddingBottom = 20;
            }
            var row = new PdfPRow(cells);
            table.Rows.Add(row);
        }
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
          string FirstCell, SecondCell, ThirdCell;
          iTextSharp.text.Document doc = new iTextSharp.text.Document();//Создание нового документа
          if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
          return;
          // получаем выбранный файл
          string filename = saveFileDialog1.FileName+".pdf";//имя файла
           if (filename != "")
           {
             PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
             doc.Open();
             BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Calibri.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);//Установление базового шрифта
             iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);
             PdfPTable table = new PdfPTable(3);
             PdfPCell[] cells = new PdfPCell[3];
             cells[0] = new PdfPCell(new Phrase($"Количество зарегистрированных пользователей за период", font));
             cells[1] = new PdfPCell(new Phrase($"Количество добавленных мастеров за период", font));
             cells[2] = new PdfPCell(new Phrase($"Полученные средства за период", font));
             foreach (var el in cells)
             {
               el.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
               el.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
               el.Border = 0;
             }
             var row = new PdfPRow(cells);
             table.Rows.Add(row);
             font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

             FirstCell = textBoxCountUserReg.Text;//Добавление в первую ячейку количества пользователей
             SecondCell = textBoxCountAddMaster.Text;//Добавление во вторую ячейку количества добавленных мастеров
             ThirdCell = textBoxProfitForTheP.Text;//Добавление в третью ячейку прибыли
             AddRow(table, FirstCell, SecondCell, ThirdCell, font);
             doc.Add(table);
             doc.Close();
             MessageBox.Show("Pdf-документ сохранен");
           }
        }

        private void buttonFormReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KU11OGM\SQLEXPRESS;Initial Catalog=Workshop;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmdCountUsers = con.CreateCommand();
                    SqlCommand cmdCountMasters = con.CreateCommand();
                    SqlCommand cmdCash = con.CreateCommand();
                    //Выбор количества записей из таблицы в БД
                    cmdCountUsers.CommandText = "SELECT COUNT(*) FROM Clients WHERE DateRegister  >= '" + dateTimePickerDateStart.Value + "' and DateRegister <= '" + dateTimePickerDateEnd.Value+"'"; 
                    cmdCountMasters.CommandText = "SELECT COUNT(*) FROM Masters WHERE DateAdd  >= '" + dateTimePickerDateStart.Value + "' and DateAdd <= '" + dateTimePickerDateEnd.Value + "'"; 
                    cmdCash.CommandText = "SELECT SUM (Cost) FROM Orders WHERE DateOfArrival >= '" + dateTimePickerDateStart.Value + "'and CompletionDate <= '" + dateTimePickerDateEnd.Value + "'";
                    int countUsers = Convert.ToInt32(cmdCountUsers.ExecuteScalar());
                    int countMasters = Convert.ToInt32(cmdCountMasters.ExecuteScalar());
                    string CountUsers = Convert.ToString(countUsers);
                    string CountMasters = Convert.ToString(countMasters);
                    string SumCash = Convert.ToString(cmdCash.ExecuteScalar());
                    textBoxCountUserReg.Text = CountUsers;
                    textBoxCountAddMaster.Text = CountMasters;
                    textBoxProfitForTheP.Text = SumCash;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form cancel = Application.OpenForms[1];
            cancel.Show();
            this.Close();
        }
    }
}
