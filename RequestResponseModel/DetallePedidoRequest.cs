﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetallePedidoRequest
    {
        public int IdDetallePedido { get; set; }

        public int? IdProducto { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdDetalleVenta { get; set; }

        public int? IdPedido { get; set; }

        public int? Cantidad { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Precio { get; set; }

        public DateOnly? Fecha { get; set; }
    }
}
