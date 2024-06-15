using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetalleVentaResponse
    {
        public int IdDetalleVenta { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public DateOnly? Fecha { get; set; }

        public string? Descripcion { get; set; }
    }
}
