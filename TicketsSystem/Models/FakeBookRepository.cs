using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketsSystem.Models
{
    public class FakeBookRepository : IBookRepository 
    {
        public IQueryable<Book> Books => new List<Book>
        {
            new Book{ Owner="Nadiia Antoshchuk",  DateS=new DateTime(2019,05,09,22,18,0),
                DateF =new DateTime(2019,05,10,6,20,0), Description="discount", Price=250.15, Id="123"},
            new Book{ Owner="Yura Khilchenko", DateS=new DateTime(2019,05,11,12,35,40),
                DateF =new DateTime(2019,05,11,23,20,0), Price=155, Description="full",Id="231" },
            new Book{ Owner="Taras Antoshchuk", DateS=new DateTime(2019,05,14,18,0,0),
                DateF =new DateTime(2019,05,15,6,20,0), Price=470.15, Description="discount", Id="280"},
            new Book{ Owner="Yaroslav Iatskiv", DateS=new DateTime(2019,05,14,10,18,0),
                DateF =new DateTime(2019,05,16,0,20,0), Price=450.15, Description="discount", Id="291"}
        }.AsQueryable<Book>();
    }
}
