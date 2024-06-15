using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("documento", Schema = "documento")]
public partial class Documento
{
    [Key]
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

    [Column("fecha_registro")]
    public DateOnly FechaRegistro { get; set; }

    [Column("hora_registro")]
    public TimeOnly HoraRegistro { get; set; }

    [Column("fecha_documento")]
    public DateOnly FechaDocumento { get; set; }

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

    [InverseProperty("IdDocumentoNavigation")]
    public virtual ICollection<DocumentoDerivaciones> DocumentoDerivaciones { get; set; } = new List<DocumentoDerivaciones>();

    [ForeignKey("Estado")]
    [InverseProperty("Documento")]
    public virtual EstadoDocumento EstadoNavigation { get; set; } = null!;

    [ForeignKey("IdAreaAsigando")]
    [InverseProperty("DocumentoIdAreaAsigandoNavigation")]
    public virtual Area? IdAreaAsigandoNavigation { get; set; }

    [ForeignKey("IdAreaOrigen")]
    [InverseProperty("DocumentoIdAreaOrigenNavigation")]
    public virtual Area? IdAreaOrigenNavigation { get; set; }

    [ForeignKey("IdFormaRecepcion")]
    [InverseProperty("Documento")]
    public virtual FormaRecepcion IdFormaRecepcionNavigation { get; set; } = null!;

    [ForeignKey("IdPersonaAsignada")]
    [InverseProperty("DocumentoIdPersonaAsignadaNavigation")]
    public virtual Persona? IdPersonaAsignadaNavigation { get; set; }

    [ForeignKey("IdPersonaOrigen")]
    [InverseProperty("DocumentoIdPersonaOrigenNavigation")]
    public virtual Persona? IdPersonaOrigenNavigation { get; set; }

    [ForeignKey("IdPrioridad")]
    [InverseProperty("Documento")]
    public virtual Prioridad IdPrioridadNavigation { get; set; } = null!;

    [ForeignKey("IdTipoDocumento")]
    [InverseProperty("Documento")]
    public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuarioActualiza")]
    [InverseProperty("DocumentoIdUsuarioActualizaNavigation")]
    public virtual Usuario? IdUsuarioActualizaNavigation { get; set; }

    [ForeignKey("IdUsuarioRegistro")]
    [InverseProperty("DocumentoIdUsuarioRegistroNavigation")]
    public virtual Usuario? IdUsuarioRegistroNavigation { get; set; }

    [ForeignKey("Origen")]
    [InverseProperty("Documento")]
    public virtual Origen OrigenNavigation { get; set; } = null!;
}
