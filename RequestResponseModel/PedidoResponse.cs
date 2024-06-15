using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class PedidoResponse
    {
        public int IdPedido { get; set; }

        public int? IdCliente { get; set; }

        public DateOnly? Fecha { get; set; }
    }
}
