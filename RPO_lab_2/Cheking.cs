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

namespace RPO_lab_2
{
    public partial class Cheking : Form
    {
        public Cheking()
        {
            InitializeComponent();
            filling();
        }
        public static string login = Login.log.logUser;
        functional func = new functional();
        SqlConnection connect = new SqlConnection("Server=LAPTOP-EM03QCFN\\SQLEXPRESS;Database=air_tickets;Trusted_Connection=True;");
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search back = new Search();
            back.Show();
        }

        private void filling ()
        {
            System.Data.DataTable table = new System.Data.DataTable("tickets");
            connect.Open();

            int idUser = func.select_id("users", "idUser", login, "login");
            string query = "SELECT tickets.number, flights.number, tickets.seat, tickets.price FROM tickets JOIN flights ON tickets.idFlight = flights.idFlight WHERE tickets.idUser = @user;";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@user", idUser);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int result = table.Rows.Count;
            if (result > 0)
            {
                SqlCommand command_1 = new SqlCommand(query, connect);
                command_1.Parameters.AddWithValue("@user", idUser);
                SqlDataReader reader = command_1.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);
                    for (int j = 0; j < 4; j++)
                    {
                        data[data.Count - 1][j] = reader[j].ToString();
                    }
                }

                reader.Close();
                connect.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string price = "";
            string query = "SELECT sum(price) FROM tickets JOIN users on users.idUser = tickets.idUser WHERE login = @login";
            connect.Open();
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("@login", Login.log.logUser);
            adapter.SelectCommand = command;
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                price = dr.GetValue(0).ToString();
            }
            connect.Close();

            full_price_textbox.Text = price;
        }
    }
}
