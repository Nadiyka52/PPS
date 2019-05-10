using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TicketsSystem.Models
{
    public class Shedule
    {
        public string StartP { get; set; }
        public string FinishP { get; set; }
        public DateTime DateS {get; set; }
        public DateTime DateF { get; set; }
        public int FreePlaces { get; set; }
        public List<Book> Bookingdata { get; set; }
        public double Price { get; set; }
        public string Id { get; set; } 
    }
}
