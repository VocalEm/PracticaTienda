using System.ComponentModel.DataAnnotations;

namespace PracticaTienda.Models
{
    public class Rol
    {
        [Key]
        public int RolId {get; set;}
        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        [StringLength(50)]        
        public string nombre {get; set;} = null!; //para no permitir nulos
    }
}