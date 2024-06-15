﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DetalleVentaRequest
    {
        public int IdDetalleVenta { get; set; }

        public int? Cantidad { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Precio { get; set; }

        public DateOnly? Fecha { get; set; }

        [StringLength(255)]
        public string? Descripcion { get; set; }
    }
}
