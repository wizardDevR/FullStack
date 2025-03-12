//La linea de abajo importa un conjunto de herramietas que permiten agregar validaciones a las propiedades de la clase
/*El atributo [Required] se aplica a la propiedad Name para asegurarse de que esta propiedad no sea nula ni esté vacía. 
Es decir, cuando crees un objeto Student, debes proporcionar un valor para Name.*/
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}