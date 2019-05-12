using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsSystem.Data.Entities
{
    public class Book
    {
        public string Owner { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public double Price  { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateF { get; set; }

        public Shedule Shedule { get; set; }

    }
}
