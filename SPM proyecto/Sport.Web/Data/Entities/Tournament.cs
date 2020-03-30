using System.ComponentModel.DataAnnotations;

namespace Sport.Web.Data.Entities
{
    public class Tournament : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} must have maximum {1} characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

    }
}