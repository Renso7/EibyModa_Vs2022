using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class DocumentoResponse
    {
        public int Id { get; set; }
        public short IdTipoDocumento { get; set; }
        public short IdPrioridad { get; set; }
        public short IdFormaRecepcion { get; set; }
        public int? NroDocumento { get; set; }
        public int? NroExpediente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }
        public DateTime FechaDocumento { get; set; }

        [StringLength(100)]
        public string? SiglasDocumento { get; set; }

        [StringLength(50)]
        public string? Snip { get; set; }


        [StringLength(200)]
        public string? Asunto { get; set; }
        public short Origen { get; set; }
        public int? IdPersonaOrigen { get; set; }
        public int? IdAreaOrigen { get; set; }
        public int? IdAreaAsigando { get; set; }
        public int? IdPersonaAsignada { get; set; }
        public string? Detalle { get; set; }

        [StringLength(100)]
        public string? Firma { get; set; }

        [StringLength(150)]
        public string? Cargo { get; set; }

        [StringLength(300)]
        public string? Archivo { get; set; }
        public int? NroFolios { get; set; }
        public short? DiasAtencion { get; set; }
        public short Estado { get; set; }
        public int? IdUsuarioRegistro { get; set; }
        public int? IdUsuarioActualiza { get; set; }
        public DateTime FechaHoraActualizacion { get; set; }

        //[InverseProperty("IdDocumentoNavigation")]
        //public virtual ICollection<DocumentoDerivacione> DocumentoDerivaciones { get; set; } = new List<DocumentoDerivacione>();

        //[ForeignKey("Estado")]
        //[InverseProperty("Documentos")]
        //public virtual EstadoDocumento EstadoNavigation { get; set; } = null!;

        //[ForeignKey("IdAreaAsigando")]
        //[InverseProperty("DocumentoIdAreaAsigandoNavigations")]
        //public virtual Area? IdAreaAsigandoNavigation { get; set; }

        //[ForeignKey("IdAreaOrigen")]
        //[InverseProperty("DocumentoIdAreaOrigenNavigations")]
        //public virtual Area? IdAreaOrigenNavigation { get; set; }

        //[ForeignKey("IdFormaRecepcion")]
        //[InverseProperty("Documentos")]
        //public virtual FormaRecepcion IdFormaRecepcionNavigation { get; set; } = null!;

        //[ForeignKey("IdPersonaAsignada")]
        //[InverseProperty("DocumentoIdPersonaAsignadaNavigations")]
        //public virtual Persona? IdPersonaAsignadaNavigation { get; set; }

        //[ForeignKey("IdPersonaOrigen")]
        //[InverseProperty("DocumentoIdPersonaOrigenNavigations")]
        //public virtual Persona? IdPersonaOrigenNavigation { get; set; }

        //[ForeignKey("IdPrioridad")]
        //[InverseProperty("Documentos")]
        //public virtual Prioridad IdPrioridadNavigation { get; set; } = null!;

        //[ForeignKey("IdTipoDocumento")]
        //[InverseProperty("Documentos")]
        //public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

        //[ForeignKey("IdUsuarioActualiza")]
        //[InverseProperty("DocumentoIdUsuarioActualizaNavigations")]
        //public virtual Usuario? IdUsuarioActualizaNavigation { get; set; }

        //[ForeignKey("IdUsuarioRegistro")]
        //[InverseProperty("DocumentoIdUsuarioRegistroNavigations")]
        //public virtual Usuario? IdUsuarioRegistroNavigation { get; set; }

        //[ForeignKey("Origen")]
        //[InverseProperty("Documentos")]
        //public virtual Origen OrigenNavigation { get; set; } = null!;
    }
}
