namespace School.Web.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Subject : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Materia")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        //TODO: Como configurar el número de digitos decimales en un doble
        [Display(Name = "Créditos")]
        public double Credits { get; set; }
    }
}
