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
using System.Configuration;

namespace MethodCab
{
    public partial class FReport : Form
    {
        public FReport()
        {
            InitializeComponent();

            // Создание конфиг. менеджера для работы с настройками подключения
            SqlConnectionStringBuilder csBuilder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString);
            // Имя сервера
            string ServerName = csBuilder.DataSource;
            // Имя базы данных
            string DBName = csBuilder.InitialCatalog;
            // Строка подключения
            ConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DBName + ";Integrated Security=True";
        }

        // Глобальное объявление переменных
        string ConnectionString = "";

        // Подключение к базе данных
        public void conn(string CS, string cmdT, DataGridView dgv)
        {
            // Создание экземпляра адаптера
            SqlDataAdapter Adapter = new SqlDataAdapter(cmdT, CS);
            // Создание объекта DataSet (набор данных)
            DataSet ds = new DataSet();
            // Заполнение таблицы набора данных DataSet
            Adapter.Fill(ds, "Table");
            // Связываем источник данных компонента DataGridView на форме, с таблицей
            dgv.DataSource = ds.Tables["Table"].DefaultView;
        }

        private void FReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.pck". При необходимости она может быть перемещена или удалена.
            this.pckTableAdapter.Fill(this.methodCabDataSet.pck);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.prepod". При необходимости она может быть перемещена или удалена.
            this.prepodTableAdapter.Fill(this.methodCabDataSet.prepod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.select_qualification". При необходимости она может быть перемещена или удалена.
            this.select_qualificationTableAdapter.Fill(this.methodCabDataSet.select_qualification);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.qualification". При необходимости она может быть перемещена или удалена.
            this.qualificationTableAdapter.Fill(this.methodCabDataSet.qualification);

        }

        private void pk_prepodCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[prepod_pk]";
            cmd.Parameters.Add("@selectedPrepod", SqlDbType.Int);
            cmd.Parameters["@selectedPrepod"].Value = pk_prepodCombo.SelectedValue;

            // Создание экземпляра адаптера
            SqlDataAdapter ReportAdapter = new SqlDataAdapter();
            ReportAdapter.SelectCommand = cmd;
            // Создание объекта DataSet (набор данных)
            DataSet dsReport = new DataSet();
            // Заполнение таблицы из набора данных DataSet данными из БД
            ReportAdapter.Fill(dsReport, "prepod_pk");
            // Связываем источник данных компонента dataGridView на форме, с таблицей Report объекта dsInstance:
            dataGridView1.DataSource = dsReport.Tables["prepod_pk"].DefaultView;
        }

        private void pk_prepod_pckBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[pk_prepod_pck]";
            cmd.Parameters.Add("@selectedPck", SqlDbType.Int);
            cmd.Parameters["@selectedPck"].Value = pk_prepod_pckCombo.SelectedValue;
            cmd.Parameters.Add("@startDate", SqlDbType.Date);
            cmd.Parameters["@startDate"].Value = pk_prepod_pckStartDTP.Value;
            cmd.Parameters.Add("@endDate", SqlDbType.Date);
            cmd.Parameters["@endDate"].Value = pk_prepod_pckEndDTP.Value;

            // Создание экземпляра адаптера
            SqlDataAdapter ReportAdapter = new SqlDataAdapter();
            ReportAdapter.SelectCommand = cmd;
            // Создание объекта DataSet (набор данных)
            DataSet dsReport = new DataSet();
            // Заполнение таблицы из набора данных DataSet данными из БД
            ReportAdapter.Fill(dsReport, "pk_prepod_pck");
            // Связываем источник данных компонента dataGridView на форме, с таблицей Report объекта dsInstance:
            dataGridView2.DataSource = dsReport.Tables["pk_prepod_pck"].DefaultView;
        }

        private void pk_yearText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешить ввод только цифр
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void plan_pkBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[plan_pk]";
            cmd.Parameters.Add("@year", SqlDbType.Int);
            cmd.Parameters["@year"].Value = pk_yearText.Text;

            // Создание экземпляра адаптера
            SqlDataAdapter ReportAdapter = new SqlDataAdapter();
            ReportAdapter.SelectCommand = cmd;
            // Создание объекта DataSet (набор данных)
            DataSet dsReport = new DataSet();
            // Заполнение таблицы из набора данных DataSet данными из БД
            ReportAdapter.Fill(dsReport, "plan_pk");
            // Связываем источник данных компонента dataGridView на форме, с таблицей Report объекта dsInstance:
            dataGridView3.DataSource = dsReport.Tables["plan_pk"].DefaultView;
        }

        private void plan_internBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[plan_intern]";
            cmd.Parameters.Add("@year", SqlDbType.Int);
            cmd.Parameters["@year"].Value = intern_yearText.Text;

            // Создание экземпляра адаптера
            SqlDataAdapter ReportAdapter = new SqlDataAdapter();
            ReportAdapter.SelectCommand = cmd;
            // Создание объекта DataSet (набор данных)
            DataSet dsReport = new DataSet();
            // Заполнение таблицы из набора данных DataSet данными из БД
            ReportAdapter.Fill(dsReport, "plan_intern");
            // Связываем источник данных компонента dataGridView на форме, с таблицей Report объекта dsInstance:
            dataGridView4.DataSource = dsReport.Tables["plan_intern"].DefaultView;
        }

        private void pk_pckBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[pck_pk]";
            cmd.Parameters.Add("@startDate", SqlDbType.Date);
            cmd.Parameters["@startDate"].Value = pk_pckStartDTP.Value;
            cmd.Parameters.Add("@endDate", SqlDbType.Date);
            cmd.Parameters["@endDate"].Value = pk_pckEndDTP.Value;

            // Создание экземпляра адаптера
            SqlDataAdapter ReportAdapter = new SqlDataAdapter();
            ReportAdapter.SelectCommand = cmd;
            // Создание объекта DataSet (набор данных)
            DataSet dsReport = new DataSet();
            // Заполнение таблицы из набора данных DataSet данными из БД
            ReportAdapter.Fill(dsReport, "pck_pk");
            // Связываем источник данных компонента dataGridView на форме, с таблицей Report объекта dsInstance:
            dataGridView5.DataSource = dsReport.Tables["pck_pk"].DefaultView;
        }

        private void ExcelExport1Btn_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelCells;
            // Создание новой рабочей книги
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Создание листа
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            // Вывод заголовка отчета
            ExcelApp.Cells[1, 1] = "Отчёт о повышение квалификации преподавателя: " + pk_prepodCombo.Text;
            // Вывод заголовков полей таблицы
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                ExcelApp.Cells[2, i + 1] = dataGridView1.Columns[i].HeaderCell.Value;
            }
            // Вывод содержимого dataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            int istr = dataGridView1.Rows.Count + 1;
            // Форматирование ячеек Excel
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[2], ExcelWorkSheet.Columns[6]];
            // Автоподбор ширины столбцов
            ExcelCells.EntireColumn.AutoFit();
            // Горизонтальное выравнивание
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[6]];
            ExcelCells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            // Обрамление линиями
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Cells[2, 1], ExcelWorkSheet.Cells[istr, 6]];
            ExcelCells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            // Открываем Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExcelExport2Btn_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelCells;
            // Создание новой рабочей книги
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Создание листа
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            // Формирование даты
            string dateStart = pk_prepod_pckStartDTP.Value.Day.ToString() + "." + pk_prepod_pckStartDTP.Value.Month.ToString() + "." + pk_prepod_pckStartDTP.Value.Year.ToString();
            string dateEnd = pk_prepod_pckEndDTP.Value.Day.ToString() + "." + pk_prepod_pckEndDTP.Value.Month.ToString() + "." + pk_prepod_pckEndDTP.Value.Year.ToString();
            // Вывод заголовка отчета
            ExcelApp.Cells[1, 1] = "Отчёт о повышении квалификации преподавателей ПЦК: " + pk_prepod_pckCombo.Text + " за период c " + dateStart + " по " + dateEnd;
            // Вывод заголовков полей таблицы
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                ExcelApp.Cells[2, i + 1] = dataGridView2.Columns[i].HeaderCell.Value;
            }
            // Вывод содержимого dataGridView
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }

            int istr = dataGridView2.Rows.Count + 1;
            // Форматирование ячеек Excel
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[6]];
            // Автоподбор ширины столбцов
            ExcelCells.EntireColumn.AutoFit();
            // Горизонтальное выравнивание
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[6]];
            ExcelCells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            // Обрамление линиями
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Cells[2, 1], ExcelWorkSheet.Cells[istr, 6]];
            ExcelCells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            // Открываем Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExcelExport3Btn_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelCells;
            // Создание новой рабочей книги
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Создание листа
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            // Формирование даты
            string dateStart = pk_pckStartDTP.Value.Day.ToString() + "." + pk_pckStartDTP.Value.Month.ToString() + "." + pk_pckStartDTP.Value.Year.ToString();
            string dateEnd = pk_pckEndDTP.Value.Day.ToString() + "." + pk_pckEndDTP.Value.Month.ToString() + "." + pk_pckEndDTP.Value.Year.ToString();
            // Вывод заголовка отчета
            ExcelApp.Cells[1, 1] = "Отчёт о повышении квалификации по ПЦК за период c " + dateStart + " по " + dateEnd;
            // Вывод заголовков полей таблицы
            for (int i = 0; i < dataGridView5.ColumnCount; i++)
            {
                ExcelApp.Cells[2, i + 1] = dataGridView5.Columns[i].HeaderCell.Value;
            }
            // Вывод содержимого dataGridView
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView5.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridView5.Rows[i].Cells[j].Value;
                }
            }

            int istr = dataGridView5.Rows.Count + 1;
            // Форматирование ячеек Excel
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[6]];
            // Автоподбор ширины столбцов
            ExcelCells.EntireColumn.AutoFit();
            // Горизонтальное выравнивание
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[6]];
            ExcelCells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            // Обрамление линиями
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Cells[2, 1], ExcelWorkSheet.Cells[istr, 6]];
            ExcelCells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            // Открываем Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExcelExport4Btn_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelCells;
            // Создание новой рабочей книги
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Создание листа
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            // Вывод заголовка отчета
            ExcelApp.Cells[1, 1] = "План повышения квалификации на " + pk_yearText.Text + " год";
            // Вывод заголовков полей таблицы
            for (int i = 0; i < dataGridView3.ColumnCount; i++)
            {
                ExcelApp.Cells[2, i + 1] = dataGridView3.Columns[i].HeaderCell.Value;
            }
            // Вывод содержимого dataGridView
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridView3.Rows[i].Cells[j].Value;
                }
            }

            int istr = dataGridView3.Rows.Count + 1;
            // Форматирование ячеек Excel
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[4]];
            // Автоподбор ширины столбцов
            ExcelCells.EntireColumn.AutoFit();
            // Горизонтальное выравнивание
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[4]];
            ExcelCells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            // Обрамление линиями
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Cells[2, 1], ExcelWorkSheet.Cells[istr, 4]];
            ExcelCells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            // Открываем Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void ExcelExport5Btn_Click(object sender, EventArgs e)
        {
            // Объявление переменных
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelCells;
            // Создание новой рабочей книги
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            // Создание листа
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            // Вывод заголовка отчета
            ExcelApp.Cells[1, 1] = "План стажировок на " + intern_yearText.Text + " год";
            // Вывод заголовков полей таблицы
            for (int i = 0; i < dataGridView4.ColumnCount; i++)
            {
                ExcelApp.Cells[2, i + 1] = dataGridView4.Columns[i].HeaderCell.Value;
            }
            // Вывод содержимого dataGridView
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = dataGridView4.Rows[i].Cells[j].Value;
                }
            }

            int istr = dataGridView4.Rows.Count + 1;
            // Форматирование ячеек Excel
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[4]];
            // Автоподбор ширины столбцов
            ExcelCells.EntireColumn.AutoFit();
            // Горизонтальное выравнивание
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Columns[1], ExcelWorkSheet.Columns[4]];
            ExcelCells.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            // Обрамление линиями
            ExcelCells = ExcelApp.Range[ExcelWorkSheet.Cells[2, 1], ExcelWorkSheet.Cells[istr, 4]];
            ExcelCells.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            ExcelCells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            // Открываем Excel 
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
