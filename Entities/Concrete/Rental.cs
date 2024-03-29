﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DateTime = System.DateTime;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public Rental()
        {
            RentDate=DateTime.Now;
            ReturnDate=DateTime.Now.AddDays(14);
        }
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; } // soru işareti koymazsak null/boş değer OLAMAZ! , otomatik olarak 0001 olarak tarih oluşturur.
        public DateTime? ReturnDate { get; set; } // soru işareti koyunca null olabilir anlamına gelecektir...

    }
}
