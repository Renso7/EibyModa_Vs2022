using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EmpleadoRequest
    {
        public int IdEmpleado { get; set; }

        [StringLength(255)]
        public string? Nombre { get; set; }

        [StringLength(255)]
        public string? Apellido { get; set; }

        [Column("DNI")]
        [StringLength(15)]
        public string? Dni { get; set; }

        [StringLength(255)]
        public string? Direccion { get; set; }

        [StringLength(255)]
        public string? Clave { get; set; }

        [StringLength(255)]

        public string? Estado { get; set; }

        [StringLength(255)]
        public string? Cargo { get; set; }

        public DateOnly? FechaContrato { get; set; }
    }
}
