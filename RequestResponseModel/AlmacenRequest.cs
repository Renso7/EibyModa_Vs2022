using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AlmacenRequest
    {
        public int IdAlmacen { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        [StringLength(255)]
        
        public string? Producto { get; set; }

        [StringLength(255)]
       
        public string? Modelo { get; set; }

        [StringLength(255)]
       
        public string? Talla { get; set; }

        [StringLength(255)]
       
        public string? Color { get; set; }

        public int? Stock { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? PrecioCompra { get; set; }

        public DateOnly? FechaCompra { get; set; }
    }
}
