using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ClienteResponse
    {
        public int IdCliente { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }


        public string? Dni { get; set; }

        public string? Direccion { get; set; }

        public string? Telefono { get; set; }


        public string? Email { get; set; }

        public DateOnly? FechaRegistro { get; set; }
    }
}
