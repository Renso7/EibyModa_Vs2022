using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DetalleDocSalida
{
    [Key]
    public int IdDetalleDocSalida { get; set; }

    public int? IdDocSalida { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDetalleVenta { get; set; }

    public int? IdAlmacen { get; set; }

    public int? IdDocEntrada { get; set; }

    public int? IdProveedor { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Lote { get; set; }

    public int? Cantidad { get; set; }

    [Column("PCosto", TypeName = "decimal(10, 2)")]
    public decimal? Pcosto { get; set; }

    [ForeignKey("IdAlmacen")]
    [InverseProperty("DetalleDocSalida")]
    public virtual Almacen? IdAlmacenNavigation { get; set; }

    [ForeignKey("IdCategoria")]
    [InverseProperty("DetalleDocSalida")]
    public virtual Categoria? IdCategoriaNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("DetalleDocSalida")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }

    [ForeignKey("IdDocEntrada")]
    [InverseProperty("DetalleDocSalida")]
    public virtual DocEntrada? IdDocEntradaNavigation { get; set; }

    [ForeignKey("IdDocSalida")]
    [InverseProperty("DetalleDocSalida")]
    public virtual DocSalida? IdDocSalidaNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleDocSalida")]
    public virtual Producto? IdProductoNavigation { get; set; }

    [ForeignKey("IdProveedor")]
    [InverseProperty("DetalleDocSalida")]
    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
