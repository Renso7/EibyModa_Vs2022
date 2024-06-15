using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class TipoDoc
{
    [Key]
    public int IdTipoDoc { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Flujo { get; set; }

    [InverseProperty("IdTipoDocumentoNavigation")]
    public virtual ICollection<DocEntrada> DocEntrada { get; set; } = new List<DocEntrada>();

    [InverseProperty("IdTipoDocNavigation")]
    public virtual ICollection<DocSalida> DocSalida { get; set; } = new List<DocSalida>();
}
