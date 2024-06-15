using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class KardexRequest
    {
        public int IdKardex { get; set; }

        public int? IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? CantidadIngreso { get; set; }

        public int? CantSalida { get; set; }

        public int? Stock { get; set; }

    }
}
