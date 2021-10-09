using System.ComponentModel.DataAnnotations;

namespace webPeople.Models
{
     public enum Sextype
    {
        Female=0,
         Male=1,
    };
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage ="El nombre es el requerido")]
        [StringLength(60,MinimumLength =5,ErrorMessage ="El nombre debe contener entre 5 a 60 caracteres")]
       
        [Display(Name="nombre completo")]
       
        public string Name { get; set; }
        [Required]
        [Display(Name="Sexo")]
        public Sextype Sex { get; set; }

        [Display(Name = "Pasa tiempos")]
        public string Hobbie { get; set; }
    }
}
