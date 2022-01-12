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
    public partial class Search : Form
    {
        functional func = new functional();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection("Server=LAPTOP-EM03QCFN\\SQLEXPRESS;Database=air_tickets;Trusted_Connection=True;");
        string loginUser = Login.log.logUser;
        bool btn = false;

        public static class pr
        {
            public static string price_ticket;
        }

        public Search()
        {
            InitializeComponent();         
            if (btn)
            {
                seats_listbox.Items.Clear();
                listbox_write();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login back = new Login();
            back.Show();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int result = func.search_func(departure_airport_textbox.Text, arrival_airport_textbox.Text, departure_date_textbox.Text);
            if (result > 0)
            {
                MessageBox.Show("Рейсы найдены.");
                connect.Open();
                int d_airport_int = func.select_id("airports", "idAirport", departure_airport_textbox.Text, "name");
                int a_airport_int = func.select_id("airports", "idAirport", arrival_airport_textbox.Text, "name");
                string query = "SELECT flights.idFlight, flights.number, flights.departureTime, flights.arrivalTime, airports.name, planes.name FROM flights JOIN airports ON flights.idDepartureAirport = airports.idAirport JOIN planes ON planes.idPlane = flights.idPlane WHERE flights.idDepartureAirport = '" + d_airport_int + "' AND flights.idArrivalAirport = '" + a_airport_int + "' AND flights.departureTime >= ' " + departure_date_textbox.Text + "';";
                SqlCommand command_1 = new SqlCommand(query, connect);
                SqlDataReader reader = command_1.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    for (int j = 0; j < 6; j++)
                    {
                        data[data.Count - 1][j] = reader[j].ToString();
                    }
                }

                reader.Close();
                connect.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                btn = true;

                seats_listbox.Items.Clear();
                listbox_write();
            }
            else
                MessageBox.Show("Такие рейсы не найдены.");
        }

        private void listbox_write()
        {
            System.Data.DataTable table = new System.Data.DataTable("planes");
            System.Data.DataTable table_1 = new System.Data.DataTable("tickets");
            int result = func.search_func(departure_airport_textbox.Text, arrival_airport_textbox.Text, departure_date_textbox.Text);
            string id = "0";
            for (int i = 0; i < result; i++)
            {
                id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[i].Value.ToString();
            }
            int res = func.free_seats(id);
            if (res > 0)
            {
                connect.Open();
                string query = "SELECT numberOfSeats FROM planes JOIN flights ON flights.idplane = planes.idPlane WHERE flights.idFlight = @flight;";
                string query_1 = "SELECT seat FROM tickets JOIN flights ON flights.idFlight = tickets.idFlight JOIN planes ON planes.idPlane = flights.idPlane WHERE flights.idFlight = @flight;";
                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@flight", id);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                string seat = command.ExecuteScalar().ToString();
                SqlCommand command_1 = new SqlCommand(query_1, connect);
                command_1.Parameters.AddWithValue("@flight", id);
                adapter.SelectCommand = command_1;
                adapter.Fill(table_1);
                int rows_count = table_1.Rows.Count;
                pr.price_ticket = seat; 
                SqlDataReader dr = command_1.ExecuteReader();

                string[] seats_result = new string[int.Parse(seat)];
                string[] seats = new string[int.Parse(seat)];


                for (int x = 0; x < int.Parse(seat); x++)
                {
                    seats[x] = 0.ToString(); 
                }
                
                for (int j = 0; j < int.Parse(seat); j++)
                {
                    if (dr.Read())
                    {
                        seats[int.Parse(dr.GetValue(0).ToString())] = dr.GetValue(0).ToString();
                        if (seats[j] != 0.ToString())
                        {
                            j++;
                        }
                        else
                        {
                            seats[j] = 0.ToString();
                        }
                    }                                                    
                }       

                for (int k = 0; k < int.Parse(seat); k++)
                {
                    seats_result[k] = (k + 1).ToString();
                    if (seats[k] != 0.ToString() && seats[k] == k.ToString())
                    {
                        seats_result[k - 1] = null;
                    }
                }

                seats_listbox.Items.AddRange(seats_result.Where(x => x != null).ToArray());
                connect.Close();
            }
        }
                

        private void booking_Click(object sender, EventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable("users");
            int result = func.search_func(departure_airport_textbox.Text, arrival_airport_textbox.Text, departure_date_textbox.Text);
            connect.Open();
            string query = "INSERT INTO tickets (number, seat, idFlight, idUser, price) VALUES ((SELECT MAX(number) FROM tickets WHERE idFlight = @id) + 1, @seat, @id, @idUser, @price);";
            string query1 = "SELECT idUser FROM users WHERE login = @login;";
            int res;
            int price;
            string seat;
            string index;
            
            if(btn)
            {
                for (int i = 0; i < result; i++)
                {
                    seat = seats_listbox.Text;
                    index = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["idFlight"].Value.ToString();
                    if (int.Parse(seat) < (int.Parse(pr.price_ticket) / 2))
                    {
                        price = 5000;
                    }
                    else
                    {
                        price = 3000;
                    }
                    SqlCommand command_1 = new SqlCommand(query1, connect);
                    command_1.Parameters.AddWithValue("@login", loginUser.ToString());
                    adapter.SelectCommand = command_1;
                    adapter.Fill(table);
                    string id_user = command_1.ExecuteScalar().ToString();
                    int free = func.free_seat_ticket(seat, index);
                    if (free > 0)
                    {
                        MessageBox.Show("Это место уже занято. Выберите другое.");
                        break;
                    }
                    SqlCommand command_2 = new SqlCommand(query, connect);
                    command_2.Parameters.AddWithValue("@id", index);
                    command_2.Parameters.AddWithValue("@idUser", id_user);
                    command_2.Parameters.AddWithValue("@seat", seat);
                    command_2.Parameters.AddWithValue("@price", price);
                    res = command_2.ExecuteNonQuery();
                    if (res > 0)
                        MessageBox.Show("Вы забронировали билет на этот рейс.");
                    else
                        MessageBox.Show("Что-то пошло не так. Попробуйте снова.");
                }
            }
            connect.Close();
        }

        private void check_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cheking check = new Cheking();
            check.Show();
        }
    }
}
