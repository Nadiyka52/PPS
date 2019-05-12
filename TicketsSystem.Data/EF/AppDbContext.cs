using System.Data.Entity;
using System.Threading.Tasks;
using TicketsSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsSystem.Data.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set;}
        public DbSet<Shedule> Shedules { get; set; }

        static AppDbContext()
        {
            Database.SetInitializer<AppDbContext>(new DbInitializer());
        }
        public AppDbContext(string connectionString) : base(connectionString){ }
    }
    public class DbInitializer: DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext db)
        {
            db.Shedules.Add(new Shedule {   StartP = "Kyiv",
                                            FinishP = "Lviv",
                                            DateS = new DateTime(2019, 05, 09, 22, 18, 0),
                                            DateF = new DateTime(2019, 05, 10, 6, 20, 0),
                                            Price = 250.15,
                                            FreePlaces = 250,
                                            Bookingdata = new List<Book>(),
                                            Id = "123"});
            db.Shedules.Add(new Shedule {   StartP = "Lviv",
                                            FinishP = "Kyiv",
                                            DateS = new DateTime(2019, 05, 11, 12, 35, 40),
                                            DateF = new DateTime(2019, 05, 11, 23, 20, 0),
                                            Price = 155,
                                            FreePlaces = 150,
                                            Bookingdata = new List<Book>(),
                                            Id = "231"});
            db.Shedules.Add(new Shedule {   StartP = "Odesa",
                                            FinishP = "Lviv",
                                            DateS = new DateTime(2019, 05, 14, 18, 0, 0),
                                            DateF = new DateTime(2019, 05, 15, 6, 20, 0),
                                            Price = 470.15,
                                            FreePlaces = 550,
                                            Bookingdata = new List<Book>(),
                                            Id = "280"});
            db.Shedules.Add(new Shedule {   StartP = "Lviv",
                                            FinishP = "Odesa",
                                            DateS = new DateTime(2019, 05, 14, 10, 18, 0),
                                            DateF = new DateTime(2019, 05, 16, 0, 20, 0),
                                            Price = 450.15,
                                            FreePlaces = 250,
                                            Bookingdata = new List<Book>(),
                                            Id = "291"});
            db.SaveChanges();
        }
    }
}