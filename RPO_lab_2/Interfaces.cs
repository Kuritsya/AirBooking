using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPO_lab_2
{
    class Interfaces
    {
        public interface FlightsSource
        {
            List<MyFlights> GetFlights();
        }

        public interface UsersSource
        {
            List<MyUsers> GetUsers();
        }

        public interface TicketsSource
        {
            List<MyTickets> GetTickets(string str = "");
        }
    }
}
