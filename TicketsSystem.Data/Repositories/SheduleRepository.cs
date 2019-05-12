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
    class SheduleRepository: IRepository<Shedule>
    {
        private AppDbContext db;

        public SheduleRepository(AppDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<Shedule> GetAll()
        {
            return db.Shedules;
        }

        public Shedule Get(int id)
        {
            return db.Shedules.Find(id);
        }

        public void Create(Shedule shlist)
        {
            db.Shedules.Add(shlist);
        }

        public void Update(Shedule shlist)
        {
            db.Entry(shlist).State = EntityState.Modified;
        }

        public IEnumerable<Shedule> Find(Func<Shedule, Boolean> predicate)
        {
            return db.Shedules.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Shedule shlist = db.Shedules.Find(id);
            if (shlist != null)
                db.Shedules.Remove(shlist);
        }
    }
}
