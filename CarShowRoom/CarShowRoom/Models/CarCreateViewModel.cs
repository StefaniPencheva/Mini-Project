﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShowRoom.Models
{
    public class CarCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(8)]
       
        public string RegNumber { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Car Picture")]
        public string Picture { get; set; }

        public DateTime Year { get; set; }

        [Required]
        [Range(1000, 300000, ErrorMessage = "Age must be a possitive number and lower than 300000")]
        [Display(Name = "Price")]
        public double Price { get; set; }
    }
}

