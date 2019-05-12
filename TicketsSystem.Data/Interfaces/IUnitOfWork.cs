using System;
using System.Collections.Generic;
using System.Text;
using TicketsSystem.Data.Entities;

namespace TicketsSystem.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shedule> Shedules { get; }
        IRepository<Book> Books { get; }
        void Save();
    }
}
