using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EmpleadoResponse
    {
        public int IdEmpleado { get; set; }

        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Dni { get; set; }

        public string? Direccion { get; set; }

        public string? Clave { get; set; }

        public string? Estado { get; set; }

        public string? Cargo { get; set; }

        public DateOnly? FechaContrato { get; set; }
    }
}
