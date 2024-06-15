using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBEibyModaModel;

public partial class Pedido
{
    [Key]
    public int IdPedido { get; set; }

    public int? IdCliente { get; set; }

    public DateOnly? Fecha { get; set; }

    [InverseProperty("IdPedidoNavigation")]
    public virtual ICollection<DetallePedido> DetallePedido { get; set; } = new List<DetallePedido>();

    [ForeignKey("IdCliente")]
    [InverseProperty("Pedido")]
    public virtual Cliente? IdClienteNavigation { get; set; }
}
