﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class Customer
    {
        [MaxLength(5)]
        public string Id { get; set; }

        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(30)]
        public string ContectName { get; set; }
        [MaxLength(30)]
        public string ContactTitle { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
        [MaxLength(24)]
        public string Fax { get; set; }

        public Order Order { get; set; }
    }
}
