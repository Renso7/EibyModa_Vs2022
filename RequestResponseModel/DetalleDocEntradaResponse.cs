using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetalleDocEntradaResponse
    {
        public int IdDetalleDocEntrada { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProducto { get; set; }

        public int? IdMarca { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalle { get; set; }

        public int? IdProveedor { get; set; }

        public string? Lote { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Pcosto { get; set; }

        public decimal? Pventa { get; set; }

        public decimal? PrecioUnidad { get; set; }

        public int? StockMinimo { get; set; }
    }
}
