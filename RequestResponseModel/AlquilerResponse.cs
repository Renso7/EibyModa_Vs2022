using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AlquilerResponse
    {
        public int IdAlquiler { get; set; }

        public int? IdCliente { get; set; }

        public DateOnly? FechaAlquiler { get; set; }

        public DateOnly? FechaDevolucion { get; set; }

        public decimal? Monto { get; set; }

        public string? Estado { get; set; }
 
        public decimal? Garantia { get; set; }

        public string? GeneracionDeuda { get; set; }

        public int? DiasTranscurridos { get; set; }

        public string? Descripcion { get; set; }
    }
}
