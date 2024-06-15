using DBEibyModaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{   /*ESTE ES UN EJEMPLO DE POLIMORFISMO EN EL REPOSITORY*/
    public interface IAlquilerRepository:   ICRUDRepository<Alquiler>
    {
    }
}
