using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class TipoDocResponse
    {
        public int IdTipoDoc { get; set; }

        public string? Nombre { get; set; }

        public string? Flujo { get; set; }
    }
}
