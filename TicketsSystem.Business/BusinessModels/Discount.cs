using System;
using System.Collections.Generic;
using System.Text;
using TicketsSystem.Business.DTO;
using TicketsSystem.Data.Entities;


namespace TicketsSystem.Business.BusinessModels
{
    class Discount
    {
        public string description;
        public Discount(decimal val, BookDTO book)
        {
            description = book.Description;
            _value = val;
        }

        private decimal _value = 0;
        public decimal Value { get { return _value; } }
        public decimal GetDiscountedPrice(decimal sum)
        { 
            if (description== "beneficiary" || description == "student" || description == "child")
                return sum - sum * _value;
            return sum;
        }
    }
}
