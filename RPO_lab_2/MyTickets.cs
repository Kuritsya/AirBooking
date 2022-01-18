using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPO_lab_2
{
    public class MyTickets
    {
        public MyTickets() { }
        public MyTickets(int id_ticket, int number, int seat)
        {
            id_ticket = idTicket;
            number = numberTicket;
            seat = seatTicket;
        }

        [Key]
        public int idTicket { get; set; }
        public int numberTicket { get; set; }
        public int seatTicket { get; set; }
    }
}
