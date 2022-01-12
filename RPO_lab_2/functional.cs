using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPO_lab_2
{
    class functional
    {
        const string connectionString = "Server=LAPTOP-EM03QCFN\\SQLEXPRESS;Database=air_tickets;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection(connectionString);

        public void connect()
        {
            connection.Open();
        }

        public void close_connection()
        {
            connection.Close();
        }

        public int login(string log, string password)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable("users");
            connect();
            var command = new SqlCommand("SELECT * FROM users WHERE login = @login AND password = @password;", connection);
            command.Parameters.AddWithValue("@login", log);
            command.Parameters.AddWithValue("@password", password);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int result = table.Rows.Count;
            close_connection();

            return result;
        }

        public int registration_func(string login, string password, string email, string fio, string birthday, string seria, string number)
        {
            connect();
            var command = new SqlCommand("INSERT INTO users (login, password, email, FIO, birthday, seriaPasport, numberPasport)" +
                "values (@login, @password, @email, @fio, @birthday, @seria, @number);", connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@fio", fio);
            command.Parameters.AddWithValue("@birthday", birthday);
            command.Parameters.AddWithValue("@seria", seria);
            command.Parameters.AddWithValue("@number", number);

            int result = command.ExecuteNonQuery();
            close_connection();

            return result;
        }

        public int search_func(string d_airport, string a_airport, string date)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable("airports");
            System.Data.DataTable table_1 = new System.Data.DataTable("flights");
            connect();
            var command = new SqlCommand("SELECT idAirport FROM airports WHERE name = @d_airport", connection);
            command.Parameters.AddWithValue("@d_airport", d_airport);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string d_airport_int = command.ExecuteScalar().ToString();
            var command_2 = new SqlCommand("SELECT idAirport FROM airports WHERE name = @a_airport", connection);
            command_2.Parameters.AddWithValue("@a_airport", a_airport);
            adapter.SelectCommand = command_2;
            adapter.Fill(table);
            string a_airport_int = command_2.ExecuteScalar().ToString();
            command.Parameters.AddWithValue("@a_airport", a_airport);
            var command_1 = new SqlCommand("SELECT * FROM flights JOIN airports ON flights.idDepartureAirport = airports.idAirport WHERE flights.idDepartureAirport = @d_airport_int AND flights.idArrivalAirport = @a_airport_int AND flights.departureTime >= @date;", connection);
            command_1.Parameters.AddWithValue("@date", date);
            command_1.Parameters.AddWithValue("@d_airport_int", d_airport_int);
            command_1.Parameters.AddWithValue("@a_airport_int", a_airport_int);
            adapter.SelectCommand = command_1;
            adapter.Fill(table_1);
            int result = table_1.Rows.Count;
            close_connection();

            return result;
        }

        public int select_id (string table_name, string id_name, string search_data, string column_name)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable(table_name);
            connect();
            var command = new SqlCommand("SELECT " + id_name + " FROM " + table_name + " WHERE " + column_name + " = @data;", connection);
            command.Parameters.AddWithValue("@data", search_data);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string find_id = command.ExecuteScalar().ToString();
            close_connection();

            int result = int.Parse(find_id);

            return result;
        }

        public int search_login (string login, string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable("users");
            connect();
            var command = new SqlCommand("SELECT idUser FROM users WHERE login = @login OR email = @email;", connection);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@email", email);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int result = table.Rows.Count;
            close_connection();

            return result;
        }

        public int free_seats(string idFlight)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable("tickets");
            connect();
            var command = new SqlCommand("SELECT seat FROM tickets WHERE idFlight = @idFlight;", connection);
            command.Parameters.AddWithValue("@idFlight", idFlight);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int result = table.Rows.Count;
            close_connection();

            return result;
        }

        public int free_seat_ticket(string seat, string idFlight)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            System.Data.DataTable table = new System.Data.DataTable("tickets");
            connect();
            var command = new SqlCommand("SELECT seat FROM tickets WHERE idFlight = @idFlight AND seat = @seat;", connection);
            command.Parameters.AddWithValue("@seat", seat);
            command.Parameters.AddWithValue("@idFlight", idFlight);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int result = table.Rows.Count;
            close_connection();

            return result;
        }
    }
}
