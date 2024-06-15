using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class ProveedorRequest
    {
        public int IdProveedor { get; set; }

        [StringLength(255)]

        public string? Rsocial { get; set; }

        [Column("RUC")]
        [StringLength(15)]

        public string? Ruc { get; set; }

        [StringLength(15)]

        public string? Telefono { get; set; }

        [StringLength(255)]

        public string? Email { get; set; }

        [StringLength(255)]

        public string? Direccion { get; set; }
    }
}
