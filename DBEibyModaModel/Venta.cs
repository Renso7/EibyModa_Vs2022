using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Venta
{
    [Key]
    public int IdVenta { get; set; }

    public int? IdCliente { get; set; }

    public int? IdDetalle { get; set; }

    public int? IdDetalleVenta { get; set; }

    public int? IdAlquiler { get; set; }

    public DateOnly? Fecha { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Comprobante { get; set; }

    public DateOnly? FechaVenta { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FormaPago { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MontoTotal { get; set; }

    [ForeignKey("IdAlquiler")]
    [InverseProperty("Venta")]
    public virtual Alquiler? IdAlquilerNavigation { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Venta")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [ForeignKey("IdDetalleVenta")]
    [InverseProperty("Venta")]
    public virtual DetalleVenta? IdDetalleVentaNavigation { get; set; }
}
