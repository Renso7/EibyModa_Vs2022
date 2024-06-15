using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEibyModaModel
{
    public partial class VDocumento
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_tipo_documento")]
        public short IdTipoDocumento { get; set; }

        [Column("id_prioridad")]
        public short IdPrioridad { get; set; }

        [Column("id_forma_recepcion")]
        public short IdFormaRecepcion { get; set; }

        [Column("nro_documento")]
        public int? NroDocumento { get; set; }

        [Column("nro_expediente")]
        public int? NroExpediente { get; set; }

        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }

        [Column("fecha_documento", TypeName = "date")]
        public DateTime FechaDocumento { get; set; }

        [Column("siglas_documento")]
        [StringLength(100)]
        [Unicode(false)]
        public string? SiglasDocumento { get; set; }

        [Column("snip")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Snip { get; set; }

        [Column("asunto")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Asunto { get; set; }

        [Column("origen")]
        public short Origen { get; set; }

        [Column("id_persona_origen")]
        public int? IdPersonaOrigen { get; set; }

        [Column("id_area_origen")]
        public int? IdAreaOrigen { get; set; }

        [Column("id_area_asigando")]
        public int? IdAreaAsigando { get; set; }

        [Column("id_persona_asignada")]
        public int? IdPersonaAsignada { get; set; }

        [Column("detalle")]
        [Unicode(false)]
        public string? Detalle { get; set; }

        [Column("firma")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Firma { get; set; }

        [Column("cargo")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Cargo { get; set; }

        [Column("archivo")]
        [StringLength(300)]
        [Unicode(false)]
        public string? Archivo { get; set; }

        [Column("nro_folios")]
        public int? NroFolios { get; set; }

        [Column("dias_atencion")]
        public short? DiasAtencion { get; set; }

        [Column("estado")]
        public short Estado { get; set; }

        [Column("id_usuario_registro")]
        public int? IdUsuarioRegistro { get; set; }

        [Column("id_usuario_actualiza")]
        public int? IdUsuarioActualiza { get; set; }

        [Column("fecha_hora_actualizacion", TypeName = "datetime")]
        public DateTime FechaHoraActualizacion { get; set; }

        [Column("Documento_Descripcion")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DocumentoDescripcion { get; set; }

        [Column("Documento_Codigo")]
        [StringLength(5)]
        [Unicode(false)]
        public string? DocumentoCodigo { get; set; }

        [Column("Documento_Prioridad_Codigo")]
        [StringLength(5)]
        [Unicode(false)]
        public string? DocumentoPrioridadCodigo { get; set; }

        [Column("Documento_Prioridad_Descripcion")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DocumentoPrioridadDescripcion { get; set; }

        [Column("Forma_Recepcion_Codigo")]
        [StringLength(5)]
        [Unicode(false)]
        public string? FormaRecepcionCodigo { get; set; }

        [Column("Forma_Recepcion_Descripcion")]
        [StringLength(50)]
        [Unicode(false)]
        public string? FormaRecepcionDescripcion { get; set; }

        [Column("Origen_Descripcion")]
        [StringLength(20)]
        [Unicode(false)]
        public string? OrigenDescripcion { get; set; }

        [Column("Area_Origen_Nombre")]
        [StringLength(100)]
        [Unicode(false)]
        public string? AreaOrigenNombre { get; set; }

        [Column("Area_Origen_Destino")]
        [StringLength(100)]
        [Unicode(false)]
        public string? AreaOrigenDestino { get; set; }

        [Column("Persona_Asignada")]
        [StringLength(180)]
        [Unicode(false)]
        public string? PersonaAsignada { get; set; }

        [Column("Estado_Descripcion")]
        [StringLength(50)]
        [Unicode(false)]
        public string? EstadoDescripcion { get; set; }
    }
}
