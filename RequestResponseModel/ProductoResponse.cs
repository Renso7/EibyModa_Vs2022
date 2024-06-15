using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProductoResponse
    {
        public int IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        public string? Nombre { get; set; }

        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        public string? Color { get; set; }

        public string? Talla { get; set; }

        public string? CodBarra { get; set; }

        public string? Descripcion { get; set; }

        public decimal? Precio { get; set; }

        public int? Stock { get; set; }

        public string? Imagen { get; set; }

        public string? Estado { get; set; }

        public DateOnly? FechaRegistro { get; set; }
    }
}
