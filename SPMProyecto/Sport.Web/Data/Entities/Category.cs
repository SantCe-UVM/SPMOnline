namespace Sport.Web.Data.Entities
{
    using Sport.Web.Data.IEntities;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Category : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Categoria")]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
