using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AreaResponse
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Codigo { get; set; } = null!;
        [StringLength(100)]
        public string? Nombre { get; set; }
        public bool? IdEstado { get; set; }
    }
}
