using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Apellido { get; set; }

    [Column("DNI")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Dni { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Clave { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Cargo { get; set; }

    public DateOnly? FechaContrato { get; set; }
}
