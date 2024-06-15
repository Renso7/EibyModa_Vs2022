using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProductoRequest
    {
        public int IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        [StringLength(255)]
        public string? Nombre { get; set; }

        [StringLength(255)]
        public string? Marca { get; set; }

        [StringLength(255)]
        public string? Modelo { get; set; }

        [StringLength(255)]
        public string? Color { get; set; }

        [StringLength(255)]
        public string? Talla { get; set; }

        [StringLength(255)]
        public string? CodBarra { get; set; }

        [StringLength(255)]
        public string? Descripcion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Precio { get; set; }

        public int? Stock { get; set; }

        [StringLength(255)]
        public string? Imagen { get; set; }

        [StringLength(255)]
        public string? Estado { get; set; }

        public DateOnly? FechaRegistro { get; set; }
    }
}
