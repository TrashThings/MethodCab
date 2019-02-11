using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodCab
{
    public partial class FAuth : Form
    {
        public FAuth()
        {
            InitializeComponent();

            userSelector.Text = userSelector.Items[0].ToString();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Если выбран пользователь "Методист"
            if (userSelector.SelectedIndex == 0)
            {
                // Если пароль равен "123"
                if (passwordText.Text == "123")
                {
                    // Открыть главную форму (форму ввода) 
                    FMain frm = new FMain();
                    frm.ShowDialog();
                }
                // Если пароль неверный, то вывести сообщение об ошибке
                else
                {
                    MessageBox.Show("Для пользователя " + userSelector.Text + " пароль неверный!");
                }
            }

            // Если выбран пользователь "Зам. директора по УМР"
            if (userSelector.SelectedIndex == 1)
            {
                // Если пароль равен "321"
                if (passwordText.Text == "321")
                {
                    // Открыть форму отчётов
                    FReport frm = new FReport();
                    frm.ShowDialog();
                }
                // Если пароль неверный, то вывести сообщение об ошибке
                else
                {
                    MessageBox.Show("Для пользователя " + userSelector.Text + " пароль неверный!");
                }
            }
        }
    }
}
