using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPO_lab_2.MyUsers;
using static RPO_lab_2.MyTickets;
using static RPO_lab_2.MyFlights;
using static RPO_lab_2.Interfaces;

namespace RPO_lab_2
{
    public class TicketsUsers : TicketsSource, UsersSource
    {
        public List<MyTickets> GetTickets(string m = "")
        {
            List<MyTickets> tickets = new List<MyTickets>();

            tickets.Add(new MyTickets()
            {
                idTicket = 1,
                numberTicket = 123123,
                seatTicket = 21
            });
            tickets.Add(new MyTickets()
            {
                idTicket = 2,
                numberTicket = 123123,
                seatTicket = 22
            });
            tickets.Add(new MyTickets()
            {
                idTicket = 3,
                numberTicket = 123125,
                seatTicket = 23
            });

            return tickets;
        }

        public List<MyUsers> GetUsers()
        {
            List<MyUsers> users = new List<MyUsers>();

            users.Add(new MyUsers()
            {
                idUser = 1,
                FIOUser = "Иванов Иван Иванович",
                birthdayUser = DateTime.Parse("10-10-1999"),
                seriaPasport = 1234,
                numberPasport = 123123,
                emailUser = "vanchez@mail.ru",
                loginUser = "vanovan",
                passwordUser = "123123"
            });
            users.Add(new MyUsers()
            {
                idUser = 2,
                FIOUser = "Александров Александр Александрович",
                birthdayUser = DateTime.Parse("12-01-1983"),
                seriaPasport = 7381,
                numberPasport = 157173,
                emailUser = "alex83@mail.ru",
                loginUser = "alexik",
                passwordUser = "111111"
            });
            users.Add(new MyUsers()
            {
                idUser = 3,
                FIOUser = "Сергеев Сергей Сергеевич",
                birthdayUser = DateTime.Parse("01-01-1990"),
                seriaPasport = 4141,
                numberPasport = 12343,
                emailUser = "sergius@mail.ru",
                loginUser = "SerGiOus",
                passwordUser = "4133g1"
            });

            return users;
        }
    }
}
