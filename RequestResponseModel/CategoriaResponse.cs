using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class CategoriaResponse
    {
        public int IdCategoria { get; set; }

        [StringLength(255)]
       
        public string? Descripcion { get; set; }

        public string? Estado { get; set; }

        public DateOnly? FechaRegistro { get; set; }
    }
}
