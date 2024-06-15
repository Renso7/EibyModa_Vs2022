using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DocSalidaRequest
    {
        public int IdDocSalida { get; set; }

        public int? IdAlmacen { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        public int? IdTipoDoc { get; set; }

        [StringLength(255)]
        public string? NroDoc { get; set; }

        public DateOnly? Fecha { get; set; }

        [StringLength(255)]
        public string? Motivo { get; set; }
    }
}
