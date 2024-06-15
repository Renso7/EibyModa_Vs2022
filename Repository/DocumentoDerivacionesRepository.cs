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
    public class DocumentoDerivacionesRepository : CRUDRepository<DocumentoDerivaciones>, IDocumentoDerivacionesRepository
    {
        public GenericFilterResponse<DocumentoDerivaciones> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
