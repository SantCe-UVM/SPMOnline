using Sport.Web.Data.IEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sport.Web.Data.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Logo")]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Foundation Date")]
        public DateTime FoundationDate { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Home Country")]
        public string HomeCountry { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Location")]
        public string Location { get; set; }

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
        [Display(Name = "Players")]
        public string Players { get; set; }*/

        /*[Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Tournaments")]
        public string Tournaments { get; set; }*/
    }
}