using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProveedorResponse
    {
        public int IdProveedor { get; set; }

        public string? Rsocial { get; set; }

        public string? Ruc { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public string? Direccion { get; set; }
    }
}
