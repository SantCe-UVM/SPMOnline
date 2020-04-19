﻿using Sport.Web.Data.IEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sport.Web.Data.Entities
{

    public class Player : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthdate")]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Age")]
        public float Age { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Home Country")]
        public string HomeCountry { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Health")]
        public string Health { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Position")]
        public string Position { get; set; }
    }
}
