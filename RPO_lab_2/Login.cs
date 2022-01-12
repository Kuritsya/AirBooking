using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPO_lab_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        public static class log
        {
            public static string logUser;
        }

        private void autorization_button_Click(object sender, EventArgs e)
        {
            functional func = new functional();
            string login;
            Search s = new Search();

            int result = func.login(login_textbox.Text, password_textbox.Text);

            if (result > 0)
            {
                login = login_textbox.Text.ToString();
                log.logUser = login;
                MessageBox.Show("Вы вошли.");
                this.Hide();
                Search booking = new Search();
                booking.Show();
            }
            else
                MessageBox.Show("Неправильно введены логин и//или пароль.");
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
