using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Producto
{
    [Key]
    public int IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalleVenta { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Marca { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Modelo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Color { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Talla { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? CodBarra { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Imagen { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Estado { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<CarritoCompras> CarritoCompras { get; set; } = new List<CarritoCompras>();

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; } = new List<DetalleDocEntrada>();

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<DetallePedido> DetallePedido { get; set; } = new List<DetallePedido>();

    [ForeignKey("IdCategoria")]
    [InverseProperty("Producto")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("Producto")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<Kardex> Kardex { get; set; } = new List<Kardex>();
}
