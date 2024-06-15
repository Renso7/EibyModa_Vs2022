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
    public class PersonaRepository : CRUDRepository<Persona>, IPersonaRepository
    {
        public GenericFilterResponse<Persona> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}