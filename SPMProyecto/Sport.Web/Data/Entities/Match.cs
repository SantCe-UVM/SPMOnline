using Sport.Web.Data.IEntities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sport.Web.Data.Entities
{
    public class Match : IEntity
    {
        public int Id { get; set; }

        /*[Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Match ID")]
        public string MatchID { get; set; }*/

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Tournament Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Sport")]
        public string Sport { get; set; }

        /*[Required]
        [MaxLength(2, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Teams on Match")]
        public string TeamsMatch { get; set; }*/

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Match Date")]
        public DateTime MatchDate { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Match Location")]
        public string MatchLocation { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Match Hour")]
        public int MatchHours { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Match Minutes")]
        public int MatchMinutes { get; set; }
    }
}
