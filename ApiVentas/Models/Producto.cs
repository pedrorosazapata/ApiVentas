using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Nombre { get; set; }
        

    }
}
