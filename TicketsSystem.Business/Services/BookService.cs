using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TicketsSystem.Data.Entities;
using TicketsSystem.Data.Interfaces;
using TicketsSystem.Business.DTO;
using TicketsSystem.Business.BusinessModels;
using TicketsSystem.Business.Infrastructure;
using TicketsSystem.Business.Interfaces;

namespace TicketsSystem.Business.Services
{
    public class BookService : IBookService
    {
        IUnitOfWork Database { get; set; }

        public BookService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void MakeBook(BookDTO bookDto)
        {
            Shedule shedule = Database.Shedules.Get(bookDto.Id);

            // валидация
            if (bookDto.Owner == null)
                throw new ValidationException("User no found", "");
            // применяем скидку
            decimal sum = new Discount(0.3m, bookDto).GetDiscountedPrice((decimal)bookDto.Price);
            Book book = new Book
            {
                Owner = bookDto.Owner,
                Description = bookDto.Description,
                Id = bookDto.Id,
                Price = (double)sum,
            };


            Database.Books.Create(book);
            Database.Save();
        }

        public IEnumerable<SheduleDTO> GetShedules()
        {
            // применяем автомаппер для проекции одной коллекции на другую
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Shedule, SheduleDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Shedule>, List<SheduleDTO>>(Database.Shedules.GetAll());
        }

        public SheduleDTO GetShedules(string id)
        {
            if (id == null)
                throw new ValidationException("Id рейсу не виявлено", "");
            var shedule = Database.Shedules.Get(id);
            if (shedule == null)
                throw new ValidationException("Не знайдено рейс", "");

            return new SheduleDTO {
                                    Id = shedule.Id,
                                    StartP = shedule.StartP,
                                    FinishP = shedule.FinishP,
                                    FreePlaces= shedule.FreePlaces,
                                    DateS = shedule.DateS,
                                    DateF = shedule.DateF,
                                    Price = shedule.Price,
                                    Bookingdata = shedule.Bookingdata
                                  };
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
