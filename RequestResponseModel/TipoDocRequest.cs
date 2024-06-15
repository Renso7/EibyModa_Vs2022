using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class TipoDocRequest
    {
        public int IdTipoDoc { get; set; }

        [StringLength(255)]
        public string? Nombre { get; set; }

        [StringLength(255)]
        public string? Flujo { get; set; }
    }
}
