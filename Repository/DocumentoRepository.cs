using DBEibyModaModel;
using IRepository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DocumentoRepository : CRUDRepository<Documento>, IDocumentoRepository
    {
        public GenericFilterResponse<Documento> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }

        public GenericFilterResponse<VDocumento> GetByFilterView(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
