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
    public class DetalleDocEntradaRepository : CRUDRepository<DetalleDocEntrada>, IDetalleDocEntradaRepository
    {
        public GenericFilterResponse<DetalleDocEntrada> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
