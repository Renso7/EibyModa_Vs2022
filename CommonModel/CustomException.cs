using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModel
{
    public class CustomException : Exception
    {
        public string CodigoError { get; set; } = "";
        public string MensajeUsuario { get; set; } = "";

        public CustomException() : base()
        {

        }

        public CustomException (string codigoError, string mensajeUsuario)
        {
            this.CodigoError = codigoError;
            this.MensajeUsuario = mensajeUsuario;
        }
    }
}
