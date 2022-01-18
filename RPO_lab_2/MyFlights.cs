using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPO_lab_2
{
    public class MyFlights
    {
        public MyFlights() { }
        public MyFlights(int id_flight, string number_flight, DateTime departure_time, DateTime arrival_time,
                     string departure_airport, string arrival_airport)
        {
            id_flight = idFlight;
            number_flight = numberFlight;
            departure_time = departureTime;
            arrival_time = arrivalTime;
            departure_airport = departureAirport;
            arrival_airport = arrivalAirport;
        }

        [Key]
        public int idFlight { get; set; }
        public string numberFlight { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
    }
}
