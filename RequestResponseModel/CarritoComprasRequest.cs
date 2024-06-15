using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class CarritoComprasRequest
    {
        public int IdCarritoCompras { get; set; }

        public int? IdCliente { get; set; }

        public int? IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? Cantidad { get; set; }
    }
}
