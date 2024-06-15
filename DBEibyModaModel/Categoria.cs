using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Categoria
{
    [Key]
    public int IdCategoria { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Estado { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<CarritoCompras> CarritoCompras { get; set; } = new List<CarritoCompras>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; } = new List<DetalleDocEntrada>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<DetallePedido> DetallePedido { get; set; } = new List<DetallePedido>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<Kardex> Kardex { get; set; } = new List<Kardex>();

    [InverseProperty("IdCategoriaNavigation")]
    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();
}
