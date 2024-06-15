using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("colaborador", Schema = "rrhh")]
[Index("IdPersona", Name = "UQ__colabora__228148B1A0D7C18F", IsUnique = true)]
public partial class Colaborador
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_persona")]
    public int IdPersona { get; set; }

    [Column("id_cargo")]
    public int IdCargo { get; set; }

    [Column("id_area")]
    public int IdArea { get; set; }

    [Column("id_estado")]
    public bool IdEstado { get; set; }

    [Column("usuario_crea")]
    public int UsuarioCrea { get; set; }

    [Column("usuario_actualiza")]
    public int UsuarioActualiza { get; set; }

    [Column("fecha_crea")]
    [Precision(6)]
    public DateTime FechaCrea { get; set; }

    [Column("fecha_actualiza")]
    [Precision(6)]
    public DateTime FechaActualiza { get; set; }

    [ForeignKey("IdArea")]
    [InverseProperty("Colaborador")]
    public virtual Area IdAreaNavigation { get; set; } = null!;

    [ForeignKey("IdCargo")]
    [InverseProperty("Colaborador")]
    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    [ForeignKey("IdPersona")]
    [InverseProperty("Colaborador")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
