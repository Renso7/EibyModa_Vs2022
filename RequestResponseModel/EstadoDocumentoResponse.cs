using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class EstadoDocumentoResponse
    {
        public short Id { get; set; }
        public string? Descripcion { get; set; }
        public bool? IdEstado { get; set; }

        //[InverseProperty("EstadoNavigation")]
        //public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();
    }
}
