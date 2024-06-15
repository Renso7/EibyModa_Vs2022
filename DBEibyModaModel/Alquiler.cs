using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Alquiler
{
    [Key]
    public int IdAlquiler { get; set; }

    public int? IdCliente { get; set; }

    public DateOnly? FechaAlquiler { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Estado { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Garantia { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? GeneracionDeuda { get; set; }

    public int? DiasTranscurridos { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Alquiler")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [InverseProperty("IdAlquilerNavigation")]
    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
