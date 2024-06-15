using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Almacen
{
    [Key]
    public int IdAlmacen { get; set; }

    public int? IdDocEntrada { get; set; }

    public int? IdProveedor { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Producto { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Modelo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Talla { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Color { get; set; }

    public int? Stock { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PrecioCompra { get; set; }

    public DateOnly? FechaCompra { get; set; }

    [InverseProperty("IdAlmacenNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdAlmacenNavigation")]
    public virtual ICollection<DocSalida> DocSalida { get; set; } = new List<DocSalida>();

    [ForeignKey("IdDocEntrada")]
    [InverseProperty("Almacen")]
    public virtual DocEntrada? IdDocEntradaNavigation { get; set; }

    [ForeignKey("IdProveedor")]
    [InverseProperty("Almacen")]
    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
