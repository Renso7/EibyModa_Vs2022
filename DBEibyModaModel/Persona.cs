using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

[Table("persona", Schema = "persona")]
[Index("NroDocumento", Name = "UQ__persona__761A4C462E56126E", IsUnique = true)]
public partial class Persona
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("id_persona_tipo_documento")]
    public short? IdPersonaTipoDocumento { get; set; }

    [Column("id_persona_tipo")]
    public short IdPersonaTipo { get; set; }

    [Column("nro_documento")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    [Column("nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [Column("apellido_paterno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoPaterno { get; set; }

    [Column("apellido_materno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoMaterno { get; set; }

    [Column("nombre_completo")]
    [StringLength(180)]
    [Unicode(false)]
    public string? NombreCompleto { get; set; }

    [Column("tipo_sangre")]
    [StringLength(10)]
    public string? TipoSangre { get; set; }

    [Column("fecha_nacimiento")]
    [Precision(6)]
    public DateTime FechaNacimiento { get; set; }

    [Column("id_genero")]
    public short IdGenero { get; set; }

    [Column("email")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("celular")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [Column("id_ubigeo")]
    public int? IdUbigeo { get; set; }

    [Column("direccion")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Direccion { get; set; }

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

    [InverseProperty("IdPersonaNavigation")]
    public virtual Colaborador? Colaborador { get; set; }

    [InverseProperty("IdPersonaAsignadaNavigation")]
    public virtual ICollection<Documento> DocumentoIdPersonaAsignadaNavigation { get; set; } = new List<Documento>();

    [InverseProperty("IdPersonaOrigenNavigation")]
    public virtual ICollection<Documento> DocumentoIdPersonaOrigenNavigation { get; set; } = new List<Documento>();

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Error> Error { get; set; } = new List<Error>();

    [ForeignKey("IdGenero")]
    [InverseProperty("Persona")]
    public virtual PersonaGenero IdGeneroNavigation { get; set; } = null!;

    [ForeignKey("IdPersonaTipoDocumento")]
    [InverseProperty("Persona")]
    public virtual PersonaTipoDocumento? IdPersonaTipoDocumentoNavigation { get; set; }

    [ForeignKey("IdPersonaTipo")]
    [InverseProperty("Persona")]
    public virtual PersonTipo IdPersonaTipoNavigation { get; set; } = null!;

    [ForeignKey("IdUbigeo")]
    [InverseProperty("Persona")]
    public virtual Ubigeo? IdUbigeoNavigation { get; set; }

    [InverseProperty("IdPersonaNavigation")]
    public virtual ICollection<Usuario> Usuario { get; set; } = new List<Usuario>();
}
