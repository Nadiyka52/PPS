using System;
using System.Collections.Generic;
using System.Text;
using TicketsSystem.Data.Entities;

namespace TicketsSystem.Business.DTO
{
   public class BookDTO
    {
        public string Owner { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public double Price { get; set; }
        public DateTime DateS { get; set; }
        public DateTime DateF { get; set; }
    }
}
