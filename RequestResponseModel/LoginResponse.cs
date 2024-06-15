using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class LoginResponse
    {
        public bool Success { get; set; }   = false;
        public string Mensaje { get; set; } = "Usuario y/o Password Incorrecto";
        public string Token { get; set; } = "";
        public string TokenExpira { get; set; } = "";
        // NECESITO RETORNAR INFORMACION DEL USUARIO

        public UsuarioLoginResponse Usuario { get; set; } = null;
        public RolResponse Rol { get; set; }  = null;
        public PersonaResponse? Persona { get; set; } = null;
        //Retorna la informacion dl rol al que corresponda
    }
}
