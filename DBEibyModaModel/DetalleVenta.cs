using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DetalleVenta
{
    [Key]
    public int IdDetalleVenta { get; set; }

    public int? Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Precio { get; set; }

    public DateOnly? Fecha { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<CarritoCompras> CarritoCompras { get; set; } = new List<CarritoCompras>();

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<DetallePedido> DetallePedido { get; set; } = new List<DetallePedido>();

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<Kardex> Kardex { get; set; } = new List<Kardex>();

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();

    [InverseProperty("IdDetalleVentaNavigation")]
    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
