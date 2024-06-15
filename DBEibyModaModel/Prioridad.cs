﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("prioridad", Schema = "documento")]
public partial class Prioridad
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

    [Column("dias_atencion")]
    public short? DiasAtencion { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [InverseProperty("IdPrioridadNavigation")]
    public virtual ICollection<Documento> Documento { get; set; } = new List<Documento>();
}
