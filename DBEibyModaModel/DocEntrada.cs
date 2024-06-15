using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class DocEntrada
{
    [Key]
    public int IdDocEntrada { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdTipoDocumento { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? NroDocumento { get; set; }

    public DateOnly? Fecha { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdDocEntradaNavigation")]
    public virtual ICollection<Almacen> Almacen { get; set; } = new List<Almacen>();

    [InverseProperty("IdDocEntradaNavigation")]
    public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; } = new List<DetalleDocEntrada>();

    [InverseProperty("IdDocEntradaNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdDocEntradaNavigation")]
    public virtual ICollection<DocSalida> DocSalida { get; set; } = new List<DocSalida>();

    [ForeignKey("IdProveedor")]
    [InverseProperty("DocEntrada")]
    public virtual Proveedor? IdProveedorNavigation { get; set; }

    [ForeignKey("IdTipoDocumento")]
    [InverseProperty("DocEntrada")]
    public virtual TipoDoc? IdTipoDocumentoNavigation { get; set; }
}
