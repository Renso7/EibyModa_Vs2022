using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class CarritoCompras
{
    [Key]
    public int IdCarritoCompras { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalleVenta { get; set; }

    public int? Cantidad { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("CarritoCompras")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("CarritoCompras")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("CarritoCompras")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("CarritoCompras")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
