using DBEibyModaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    /*public interface IAlquilerRepository : ICRUDRepository<Carritocompras>*/
    public interface IUsuarioRepository : ICRUDRepository<Usuario>  
    {
        Usuario ObternerPorUserName (string username);
        VUsuario ObtenerVistaUsername(string username);
    }
}
