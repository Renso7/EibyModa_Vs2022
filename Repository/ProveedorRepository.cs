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
    /* public class AlquilerRepository : CRUDRepository<Alquiler>, IAlquilerRepository*/
    public class ProveedorRepository : CRUDRepository<Proveedor>, IProveedorRepository
    {
        public GenericFilterResponse<Proveedor> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
