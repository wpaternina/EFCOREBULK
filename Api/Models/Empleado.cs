using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Ciudad { get; set; }
    }
}
