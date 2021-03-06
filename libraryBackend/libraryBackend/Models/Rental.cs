﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace libraryBackend.Models
{
    public class Rental
    {
        [Required]
        public Guid RentalId { get; set; }
        [Required]
        public Guid BookId { get; set; }
        [Required]
        public string UserEmail { get; set; }        
    }
}
