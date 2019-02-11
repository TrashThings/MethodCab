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
    public partial class FMain : Form
    {
        public FMain()
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

            // Значения по умолчанию для компонентов ComboBox на форме
            categoryCombo.Text = categoryCombo.Items[0].ToString();
            eduCombo.Text = eduCombo.Items[0].ToString();
            postComboText.Text = postComboText.Items[0].ToString();
            internCombo.Text = internCombo.Items[0].ToString();
            typeCombo.Text = typeCombo.Items[0].ToString();
            type_docCombo.Text = type_docCombo.Items[0].ToString();
        }

        // Глобальное объявление переменных
        string ConnectionString = "";

        // Константы запросов к базе (выборка по запросу SELECT)
        const string select_pck = "EXEC select_pck";
        const string select_prepod = "EXEC select_prepod";
        const string select_qualification = "EXEC select_qualification";


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

        private void FMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.prepod". При необходимости она может быть перемещена или удалена.
            this.prepodTableAdapter.Fill(this.methodCabDataSet.prepod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "methodCabDataSet.pck". При необходимости она может быть перемещена или удалена.
            this.pckTableAdapter.Fill(this.methodCabDataSet.pck);
            // Вывод таблицы ПЦК
            conn(ConnectionString, select_pck, dataGridView3);
            // Вывод таблицы Преподаватели
            conn(ConnectionString, select_prepod, dataGridView2);
            // Вывод таблицы Квалификация
            conn(ConnectionString, select_qualification, dataGridView1);
        }

        private void add_pckBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            // Определение имени вызываемой процедуры
            cmd.CommandText = "[add_pck]";
            // Создание параметра
            cmd.Parameters.Add("@name_spec", SqlDbType.VarChar, 100);
            // Задание значение параметра
            cmd.Parameters["@name_spec"].Value = spec_pckText.Text;
            cmd.Parameters.Add("@code_spec", SqlDbType.Int);
            cmd.Parameters["@code_spec"].Value = code_pckText.Text;
            // Отправка процедуры на сервер
            cmd.ExecuteScalar();
            // Вывод сообщения об успешном добавлении записи
            MessageBox.Show("ПЦК " + spec_pckText.Text + " добавлена!");
            // Обновление таблицы ПЦК 
            conn(ConnectionString, select_pck, dataGridView3);
        }

        private void add_prepodBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            // Определение имени вызываемой процедуры
            cmd.CommandText = "[add_prepod]";
            // Создание параметра
            cmd.Parameters.Add("@name_prepod", SqlDbType.VarChar, 60);
            // Задание значение параметра
            cmd.Parameters["@name_prepod"].Value = name_prepodText.Text;
            cmd.Parameters.Add("@id_pck", SqlDbType.Int);
            cmd.Parameters["@id_pck"].Value = pckCombo.SelectedValue;
            cmd.Parameters.Add("@spec", SqlDbType.VarChar, 30);
            cmd.Parameters["@spec"].Value = soec_prepodText.Text;
            cmd.Parameters.Add("@category", SqlDbType.VarChar, 10);
            cmd.Parameters["@category"].Value = categoryCombo.Text;
            cmd.Parameters.Add("@edu", SqlDbType.VarChar, 20);
            cmd.Parameters["@edu"].Value = eduCombo.Text;
            cmd.Parameters.Add("@post", SqlDbType.VarChar, 30);
            cmd.Parameters["@post"].Value = postComboText.Text;
            cmd.Parameters.Add("@date_course", SqlDbType.Date);
            cmd.Parameters["@date_course"].Value = courseDTP.Value;

            if (internCombo.SelectedIndex == 0)
            {
                cmd.Parameters.Add("@intern", SqlDbType.Bit);
                cmd.Parameters["@intern"].Value = 0;
               // cmd.Parameters.Add("@date_intern", SqlDbType.Date);
               // cmd.Parameters["@date_intern"].Value = null;
            }
            else
            {
                cmd.Parameters.Add("@intern", SqlDbType.Bit);
                cmd.Parameters["@intern"].Value = 1;
               // cmd.Parameters.Add("@date_intern", SqlDbType.Date);
               // cmd.Parameters["@date_intern"].Value = internDTP.Value;
            }
            cmd.Parameters.Add("@date_intern", SqlDbType.Date);
            cmd.Parameters["@date_intern"].Value = internDTP.Value;
            // Отправка процедуры на сервер
            cmd.ExecuteScalar();
            // Вывод сообщения об успешном добавлении записи
            MessageBox.Show("Преподаватель " + name_prepodText.Text + " добавлен!");
            // Обновление таблицы Преподаватель
            conn(ConnectionString, select_prepod, dataGridView2);
        }

        private void add_qualificationBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection();
            conn2.ConnectionString = ConnectionString;
            // Установка соединения
            conn2.Open();
            // Создание нового экземпляра SQLCommand
            SqlCommand cmd = conn2.CreateCommand();
            // Определение типа SQLCommand=StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            // Определение имени вызываемой процедуры
            cmd.CommandText = "[add_qualification]";
            // Создание параметра
            cmd.Parameters.Add("@id_prepod", SqlDbType.Int);
            // Задание значение параметра
            cmd.Parameters["@id_prepod"].Value = prepodCombo.SelectedValue;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50);
            cmd.Parameters["@type"].Value = typeCombo.Text;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
            cmd.Parameters["@name"].Value = name_qualificationText.Text;
            cmd.Parameters.Add("@type_doc", SqlDbType.VarChar, 50);
            cmd.Parameters["@type_doc"].Value = type_docCombo.Text;
            cmd.Parameters.Add("@num_doc", SqlDbType.Int);
            cmd.Parameters["@num_doc"].Value = num_docText.Text;
            cmd.Parameters.Add("@date", SqlDbType.Date);
            cmd.Parameters["@date"].Value = date_qualificationDTP.Value;
            cmd.Parameters.Add("@hours", SqlDbType.Int);
            cmd.Parameters["@hours"].Value = hoursText.Text;
            // Отправка процедуры на сервер
            cmd.ExecuteScalar();
            // Вывод сообщения об успешном добавлении записи
            MessageBox.Show("Новые сведения о квалификации преподавателя " + prepodCombo.Text + " добавлены!");
            // Обновление таблицы Квалификация
            conn(ConnectionString, select_qualification, dataGridView1);
        }

        private void code_pckText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешить ввод только цифр
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}