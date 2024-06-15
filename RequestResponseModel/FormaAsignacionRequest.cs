using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class FormaAsignacionRequest
    {
        public short Id { get; set; }

        [StringLength(50)]
        public string? Descripcion { get; set; }
        public bool? IdEstado { get; set; }

        // [InverseProperty("IdDocumentoFormaAsignacionNavigation")]
        // public virtual ICollection<DocumentoDerivacione> DocumentoDerivaciones { get; set; } = new List<DocumentoDerivacione>();
    }
}
