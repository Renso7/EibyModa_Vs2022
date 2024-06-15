using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DocEntradaRequest
    {
        public int IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        public int? IdTipoDocumento { get; set; }

        [StringLength(255)]

        public string? NroDocumento { get; set; }

        public DateOnly? Fecha { get; set; }

        [StringLength(255)]

        public string? Descripcion { get; set; }
    }
}
