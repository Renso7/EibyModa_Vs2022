using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DocSalidaResponse
    {
        public int IdDocSalida { get; set; }

        public int? IdAlmacen { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        public int? IdTipoDoc { get; set; }

        public string? NroDoc { get; set; }

        public DateOnly? Fecha { get; set; }

        public string? Motivo { get; set; }
    }
}
