﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("persona_tipo_documento", Schema = "persona")]
[Index("Codigo", Name = "UQ__persona___40F9A206BD6D5A89", IsUnique = true)]
public partial class PersonaTipoDocumento
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("codigo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("descripcion")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [InverseProperty("IdPersonaTipoDocumentoNavigation")]
    public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
}
