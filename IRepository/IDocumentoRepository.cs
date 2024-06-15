using DBEibyModaModel;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    /*IDocumentoRepository*/
    public interface IDocumentoRepository : ICRUDRepository<Documento>
    {
        GenericFilterResponse<VDocumento> GetByFilterView(GenericFilterRequest request);
    }
}
