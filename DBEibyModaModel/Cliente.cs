using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

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

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Alquiler> Alquiler { get; set; } = new List<Alquiler>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<CarritoCompras> CarritoCompras { get; set; } = new List<CarritoCompras>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Pedido> Pedido { get; set; } = new List<Pedido>();

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
