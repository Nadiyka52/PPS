using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsSystem.Models
{
    public class FakeSheduleRepository : ISheduleRepository
    {
        public IQueryable<Shedule> Shedules => new List<Shedule>
        {
            new Shedule{ StartP="Kyiv", FinishP="Lviv", DateS=new DateTime(2019,05,09,22,18,0),
                         DateF =new DateTime(2019,05,10,6,20,0), Price=250.15, FreePlaces = 250,
                         Bookingdata = new List<Book>(), Id="123"},
            new Shedule{ StartP="Lviv", FinishP="Kyiv", DateS=new DateTime(2019,05,11,12,35,40),
                         DateF =new DateTime(2019,05,11,23,20,0), Price=155, FreePlaces = 150,
                         Bookingdata = new List<Book>(), Id="231"},
            new Shedule{ StartP="Odesa", FinishP="Lviv", DateS=new DateTime(2019,05,14,18,0,0),
                         DateF =new DateTime(2019,05,15,6,20,0), Price=470.15, FreePlaces = 550,
                         Bookingdata = new List<Book>(), Id="280"},
            new Shedule{ StartP="Lviv", FinishP="Odesa", DateS=new DateTime(2019,05,14,10,18,0),
                         DateF =new DateTime(2019,05,16,0,20,0), Price=450.15, FreePlaces = 250,
                         Bookingdata = new List<Book>(), Id="291"},
        }.AsQueryable<Shedule>();
    }
}
