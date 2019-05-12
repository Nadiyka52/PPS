using System;
using System.Collections.Generic;
using System.Text;
using TicketsSystem.Data.Entities;
using TicketsSystem.Data.Interfaces;
using TicketsSystem.Data.EF;

namespace TicketsSystem.Data.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private AppDbContext db;
        private BookRepository bookRepository;
        private SheduleRepository sheduleRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new AppDbContext (connectionString);
        }
        public IRepository<Shedule> Shedules
        {
            get
            {
                if (sheduleRepository == null)
                    sheduleRepository = new SheduleRepository(db);
                return sheduleRepository;
            }
        }

        public IRepository<Book> Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                return bookRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
