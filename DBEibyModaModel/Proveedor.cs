using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Proveedor
{
    [Key]
    public int IdProveedor { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Rsocial { get; set; }

    [Column("RUC")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Ruc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<Almacen> Almacen { get; set; } = new List<Almacen>();

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<DetalleDocEntrada> DetalleDocEntrada { get; set; } = new List<DetalleDocEntrada>();

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<DetalleDocSalida> DetalleDocSalida { get; set; } = new List<DetalleDocSalida>();

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<DocEntrada> DocEntrada { get; set; } = new List<DocEntrada>();

    [InverseProperty("IdProveedorNavigation")]
    public virtual ICollection<DocSalida> DocSalida { get; set; } = new List<DocSalida>();
}
