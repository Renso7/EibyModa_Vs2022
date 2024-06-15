using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DetalleDocEntrada
{
    [Key]
    public int IdDetalleDocEntrada { get; set; }

    public int? IdDocEntrada { get; set; }

    public int? IdProducto { get; set; }

    public int? IdMarca { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalle { get; set; }

    public int? IdProveedor { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Lote { get; set; }

    public int? Cantidad { get; set; }

    [Column("PCosto", TypeName = "decimal(10, 2)")]
    public decimal? Pcosto { get; set; }

    [Column("PVenta", TypeName = "decimal(10, 2)")]
    public decimal? Pventa { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PrecioUnidad { get; set; }

    public int? StockMinimo { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("DetalleDocEntrada")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdDocEntrada")]
    [InverseProperty("DetalleDocEntrada")]
    public virtual DocEntrada? IdDocEntradaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleDocEntrada")]
    public virtual Producto? IdProductoNavigation { get; set; }

    [ForeignKey("IdProveedor")]
    [InverseProperty("DetalleDocEntrada")]
    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
