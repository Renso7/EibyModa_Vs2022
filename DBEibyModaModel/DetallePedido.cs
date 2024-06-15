using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DetallePedido
{
    [Key]
    public int IdDetallePedido { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalleVenta { get; set; }

    public int? IdPedido { get; set; }

    public int? Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Precio { get; set; }

    public DateOnly? Fecha { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("DetallePedido")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("DetallePedido")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("DetallePedido")]
    public virtual Pedido? IdPedidoNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetallePedido")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
