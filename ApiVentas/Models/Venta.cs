using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public double MontoTotal { get; set; } = 0;


    }
}
