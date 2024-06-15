using DBEibyModaModel;
using IRepository;
using Microsoft.EntityFrameworkCore;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class UsuarioRepository : CRUDRepository<Usuario>, IUsuarioRepository
    {
        public GenericFilterResponse<Usuario> GetByFilter(GenericFilterRequest request)
        {
            throw new NotImplementedException();
        }
        public Usuario ObternerPorUserName(string username)
        {
            Usuario usuario = dbset
                .Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
                
            return usuario;
        }

        public VUsuario ObtenerVistaUsername(string username)
        {
            VUsuario vUsuario = db.VUsuario.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            return vUsuario;
        }
    }
}

