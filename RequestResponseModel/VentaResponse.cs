using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class VentaResponse
    {
        public int IdVenta { get; set; }

        public int? IdCliente { get; set; }

        public int? IdDetalle { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? IdAlquiler { get; set; }

        public DateOnly? Fecha { get; set; }

        public string? Comprobante { get; set; }

        public DateOnly? FechaVenta { get; set; }

        public string? FormaPago { get; set; }

        public decimal? MontoTotal { get; set; }
    }
}
