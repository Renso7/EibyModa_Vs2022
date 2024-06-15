using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class AreaRequest
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Codigo { get; set; } = null!;

        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required]
        public bool? IdEstado { get; set; }

        //[InverseProperty("IdAreaNavigation")]
        //public virtual ICollection<Colaborador> Colaboradors { get; set; } = new List<Colaborador>();

        //[InverseProperty("IdAreaNavigation")]
        //public virtual ICollection<DocumentoDerivacione> DocumentoDerivaciones { get; set; } = new List<DocumentoDerivacione>();

        //[InverseProperty("IdAreaAsigandoNavigation")]
        //public virtual ICollection<Documento> DocumentoIdAreaAsigandoNavigations { get; set; } = new List<Documento>();

        //[InverseProperty("IdAreaOrigenNavigation")]
        //public virtual ICollection<Documento> DocumentoIdAreaOrigenNavigations { get; set; } = new List<Documento>();
    }
}
