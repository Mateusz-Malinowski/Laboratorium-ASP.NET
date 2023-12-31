﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Address
    {
        public string City { get; set; }

        public string Street { get; set; }

        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
    }
}
