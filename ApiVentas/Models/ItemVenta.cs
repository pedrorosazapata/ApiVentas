using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models
{
    public class ItemVenta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VentaId { get; set; }
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public decimal Precio { get; set; }
         
        public List<Venta> Ventas { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
