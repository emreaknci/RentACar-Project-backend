﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public List<CreditCard> CreditCards { get; set; }
    }
}
