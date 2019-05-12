using System;
using System.Collections.Generic;
using System.Text;
using TicketsSystem.Business.DTO;

namespace TicketsSystem.Business.Interfaces
{
    public interface IBookService
    {
        void MakeBook(BookDTO bookDto);
        SheduleDTO GetShedules(string id);
        IEnumerable<SheduleDTO> GetShedules();
        void Dispose();
    }
}
