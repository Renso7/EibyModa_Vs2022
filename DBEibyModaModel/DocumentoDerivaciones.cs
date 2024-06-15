using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("documento_derivaciones")]
public partial class DocumentoDerivaciones
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_documento")]
    public int? IdDocumento { get; set; }

    [Column("id_documento_forma_asignacion")]
    public short? IdDocumentoFormaAsignacion { get; set; }

    [Column("fecha_derivacion")]
    public DateOnly? FechaDerivacion { get; set; }

    [Column("hora_derivacion")]
    public TimeOnly? HoraDerivacion { get; set; }

    [Column("id_area")]
    public int? IdArea { get; set; }

    [Column("detalle")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Detalle { get; set; }

    [Column("usuario")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [Column("proveido_atencion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProveidoAtencion { get; set; }

    [Column("id_estado")]
    public bool? IdEstado { get; set; }

    [ForeignKey("IdArea")]
    [InverseProperty("DocumentoDerivaciones")]
    public virtual Area? IdAreaNavigation { get; set; }

    [ForeignKey("IdDocumentoFormaAsignacion")]
    [InverseProperty("DocumentoDerivaciones")]
    public virtual FormaAsignacion? IdDocumentoFormaAsignacionNavigation { get; set; }

    [ForeignKey("IdDocumento")]
    [InverseProperty("DocumentoDerivaciones")]
    public virtual Documento? IdDocumentoNavigation { get; set; }
}
