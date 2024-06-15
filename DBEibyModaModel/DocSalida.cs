using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DocSalida
{
    [Key]
    public int IdDocSalida { get; set; }

    public int? IdAlmacen { get; set; }

    public int? IdDocEntrada { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdTipoDoc { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NroDoc { get; set; }

    public DateOnly? Fecha { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    [InverseProperty("IdDocSalidaNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [ForeignKey("IdAlmacen")]
    [InverseProperty("DocSalida")]
    public virtual Almacen? IdAlmacenNavigation { get; set; }

    [ForeignKey("IdDocEntrada")]
    [InverseProperty("DocSalida")]
    public virtual DocEntrada? IdDocEntradaNavigation { get; set; }

    [ForeignKey("IdProveedor")]
    [InverseProperty("DocSalida")]
    public virtual Proveedor? IdProveedorNavigation { get; set; }

    [ForeignKey("IdTipoDoc")]
    [InverseProperty("DocSalida")]
    public virtual TipoDoc? IdTipoDocNavigation { get; set; }
}
