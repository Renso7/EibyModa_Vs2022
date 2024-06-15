using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DocumentoDerivacionesResponse
    {
        public int Id { get; set; }

        public int? IdDocumento { get; set; }

        public short? IdDocumentoFormaAsignacion { get; set; }

        public DateTime? FechaDerivacion { get; set; }

        public TimeSpan? HoraDerivacion { get; set; }

        public int? IdArea { get; set; }

        [StringLength(250)]
        public string? Detalle { get; set; }

        [StringLength(150)]
        public string? Usuario { get; set; }

        [StringLength(100)]
        public string? ProveidoAtencion { get; set; }

        public bool? IdEstado { get; set; }

        //[ForeignKey("IdArea")]
        //[InverseProperty("DocumentoDerivaciones")]
        //public virtual Area? IdAreaNavigation { get; set; }

        //[ForeignKey("IdDocumentoFormaAsignacion")]
        //[InverseProperty("DocumentoDerivaciones")]
        //public virtual FormaAsignacion? IdDocumentoFormaAsignacionNavigation { get; set; }

        //[ForeignKey("IdDocumento")]
        //[InverseProperty("DocumentoDerivaciones")]
        //public virtual Documento? IdDocumentoNavigation { get; set; }
    }
}
