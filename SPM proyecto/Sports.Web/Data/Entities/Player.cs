using System;
using System.ComponentModel.DataAnnotations;
namespace Sports.Web.Data.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Home Country")]
        public string HomeCountry { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Health")]
        public string Health { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthdate")]
        public DateTime BirthDate { get; set; }

    }
}
