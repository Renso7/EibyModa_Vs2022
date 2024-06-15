using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Kardex
{
    [Key]
    public int IdKardex { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalleVenta { get; set; }

    public int? CantidadIngreso { get; set; }

    public int? CantSalida { get; set; }

    public int? Stock { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? UtilPrecioCosto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? UtilPrecioVenta { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? UtilPorUnidad { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("Kardex")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("Kardex")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("Kardex")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
