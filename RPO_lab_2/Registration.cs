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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login reg_back = new Login();
            reg_back.Show();
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            functional func = new functional();

            int search = func.search_login(login_textbox.Text, email_textbox.Text);
            int result = func.registration_func(login_textbox.Text, password_textbox.Text, email_textbox.Text, fio_textbox.Text, birthday_textbox.Text, serial_textbox.Text, number_textbox.Text);            

            if (search > 0)
                MessageBox.Show("Пользователь с таким логином или почтой уже существует. Введите данные заново или авторизуйтесь.");
            else
            {
                if (result > 0)
                    MessageBox.Show("Вы зарегистрировались.");
                else
                    MessageBox.Show("Что-то пошло не так. Попробуйте снова.");
            }            
        }
    }
}