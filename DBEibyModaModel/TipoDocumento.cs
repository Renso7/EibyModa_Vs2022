using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("tipo_documento", Schema = "documento")]
public partial class TipoDocumento
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("descripcion")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [InverseProperty("IdTipoDocumentoNavigation")]
    public virtual ICollection<Documento> Documento { get; set; } = new List<Documento>();
}
