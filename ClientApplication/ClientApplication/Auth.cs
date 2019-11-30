using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Auth : Form
    {
        LogIn login = null;
        UserSend user = null;

        public Auth()
        {
            InitializeComponent();
            login = new LogIn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                login.Login = textBox1.Text;
                login.Password = textBox2.Text;

                user = login.LoginTo();

                if (user == null)
                {
                    MessageBox.Show("Такого пользоваеля не существует.");
                }
                else
                {
                    MessageBox.Show("Добро пожаловать " + user.FirstName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex);
            }
        }
    }
}
