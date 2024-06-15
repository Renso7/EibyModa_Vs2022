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
    public class FormaRecepcionRepository : CRUDRepository<FormaRecepcion>, IFormaRecepcionRepository
    {
        public GenericFilterResponse<FormaRecepcion> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
