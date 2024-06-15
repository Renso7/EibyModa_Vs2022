using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AlquilerRequest
    {
        public int IdAlquiler { get; set; }

        public int? IdCliente { get; set; }

        public DateOnly? FechaAlquiler { get; set; }

        public DateOnly? FechaDevolucion { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Monto { get; set; }

        [StringLength(255)]
      
        public string? Estado { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Garantia { get; set; }

        [StringLength(255)]
     
        public string? GeneracionDeuda { get; set; }

        public int? DiasTranscurridos { get; set; }

        [StringLength(255)]
     
        public string? Descripcion { get; set; }
    }
}
