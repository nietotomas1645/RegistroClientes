using System.ComponentModel.DataAnnotations;

namespace backend.Models

{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; } = string.Empty;
        [Required]
        public string apellido { get; set; } = string.Empty;
        [Required]
        public string direccion { get; set; } = string.Empty;
    }
}
