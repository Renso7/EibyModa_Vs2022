using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class VentaRequest
    {
        public int IdVenta { get; set; }

        public int? IdCliente { get; set; }

        public int? IdDetalle { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? IdAlquiler { get; set; }

        public DateOnly? Fecha { get; set; }

        [StringLength(255)]
        public string? Comprobante { get; set; }

        public DateOnly? FechaVenta { get; set; }

        [StringLength(255)]
        public string? FormaPago { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? MontoTotal { get; set; }
    }
}
