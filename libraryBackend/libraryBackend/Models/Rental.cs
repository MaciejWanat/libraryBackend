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
        public Book Book { get; set; }
        [Required]
        public LibraryUser User { get; set; }        
    }
}
