using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponseModel
{
    public class LoginRequest
    {
        /// <summary>
        /// OBJETO QUE SE USA PARA RECIBIR LOS ATRIBUTOS PARA EL INICIO DE SECION
        /// </summary>
        /// 

        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string UserName { get; set; } = "";
        [Required]
        [StringLength(30, MinimumLength = 3)] 
        public string Password { get; set; } = "";


    }
}
