using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetalleDocSalidaRequest
    {
        public int IdDetalleDocSalida { get; set; }

        public int? IdDocSalida { get; set; }

        public int? IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? IdAlmacen { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        [StringLength(255)]
        public string? Lote { get; set; }

        public int? Cantidad { get; set; }

        [Column("PCosto", TypeName = "decimal(10, 2)")]
        public decimal? Pcosto { get; set; }
    }
}
