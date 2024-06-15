using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AlmacenResponse
    {
        public int IdAlmacen { get; set; }

        public int? IdDocEntrada { get; set; }

        public int? IdProveedor { get; set; }

        public string? Producto { get; set; }      

        public string? Modelo { get; set; }
     
        public string? Talla { get; set; }

        public string? Color { get; set; }

        public int? Stock { get; set; }    
        
        public decimal? PrecioCompra { get; set; }

        public DateOnly? FechaCompra { get; set; }
    }
}
