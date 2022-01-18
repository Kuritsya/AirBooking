using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static RPO_lab_2.MyTickets;
using static RPO_lab_2.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace RPO_lab_2
{
    public class FromFile : TicketsSource
    {
        public List<MyTickets> GetTickets(string sqlExpression = "")
        {
            List<MyTickets> list = new List<MyTickets>();

            StreamReader dr = new StreamReader("Tickets.csv");
            String all = dr.ReadToEnd();
            String[] mass = all.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in mass)
            {
                String[] arr1 = s.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                int id_ticket = Int32.Parse(arr1[0]);
                int number= Int32.Parse(arr1[1]);
                int seat = Int32.Parse(arr1[2]);
                list.Add(new TicketsSource(id_ticket, number, seat));
            }
            return list;
        }
    }

    public class Form_db : TicketsSource
    {
        static string connectionString = "Server=LAPTOP-EM03QCFN\\SQLEXPRESS;Database=air_tickets;Trusted_Connection=True;";
        public List<MyTickets> GetTickets(string sqlExpression)
        {
            List<MyTickets> list = new List<MyTickets>();
            SqlCommand cmd = new SqlCommand(sqlExpression);
            SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable data = ds.Tables[0];
            for (int i = 0; i < data.Rows.Count; i++)
            {
                list.Add(new TicketsSource(
                int.Parse(data.Rows[i].ItemArray[0].ToString()),
                int.Parse(data.Rows[i].ItemArray[1].ToString()),
                int.Parse(data.Rows[i].ItemArray[2].ToString())));
            }
            return list;
        }
        public void SetCompany(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
