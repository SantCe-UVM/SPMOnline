using Sport.Web.Data.IEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sport.Web.Data.Entities
{
    public class User :IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Foto")]
        public string ImageUrl { get; set; }

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
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Height")]
        public float Height { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Weight")]
        public float Weight { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Health")]
        public string Health { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Sport")]
        public string Sport { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Coach")]
        public bool Coach { get; set; }

        /*[Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Teams")]
        public string Team { get; set; }*/
    }
}
