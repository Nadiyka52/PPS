using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.Entity;
using TicketsSystem.Data.Entities;
using TicketsSystem.Data.Interfaces;
using TicketsSystem.Data.EF;

namespace TicketsSystem.Data.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private AppDbContext db;

        public BookRepository(AppDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books.Include(o => o.Shedule);
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }
        public IEnumerable<Book> Find(Func<Book, Boolean> predicate)
        {
            return db.Books.Include(o => o.Shedule).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
                db.Books.Remove(book);
        }
    }
}
