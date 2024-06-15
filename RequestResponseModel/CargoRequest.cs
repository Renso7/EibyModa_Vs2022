using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class CargoRequest
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string? Codigo { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Required]
        public bool? IdEstado { get; set; }
        //public virtual ICollection<Colaborador> Colaboradors { get; set; } = new List<Colaborador>();
    }
}
