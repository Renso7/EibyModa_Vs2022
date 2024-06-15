using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("persona_genero", Schema = "persona")]
public partial class PersonaGenero
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("codigo")]
    [StringLength(3)]
    [Unicode(false)]
    public string? Codigo { get; set; }

    [Column("nombre")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("IdGeneroNavigation")]
    public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
}
