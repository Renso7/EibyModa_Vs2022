using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class OrigenResponse
    {
        public short Id { get; set; }

        [StringLength(20)]
        public string? Descripcion { get; set; }
        public bool? IdEstado { get; set; }

        // [InverseProperty("OrigenNavigation")]
        // public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();
    }
}
