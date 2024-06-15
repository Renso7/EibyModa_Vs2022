using AutoMapper;
using Bussnies;
using IBussnies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestResponseModel;
using System.Net;

namespace ApiWebPageEiby.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {/*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTORES
        private readonly IAlquilerBussnies _alquilerBussnies;
        private readonly IMapper _mapper;

        public AlquilerController(IMapper mapper)
        {
            _mapper = mapper;
            _alquilerBussnies = new AlquilerBussnies(mapper);
        }
        #endregion DECLARACION DE VARIABLES Y CONSTRUCTOR

        #region CRUD METHODS

        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA CARGO
        /// </summary>
        /// <returns>List-CargoResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<AlquilerResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            return Ok(_alquilerBussnies.GetAll());
        }

        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>CargoResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<AlquilerResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_alquilerBussnies.GetById(id));
        }

        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<AlquilerResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] AlquilerRequest request)
        {
            return Ok(_alquilerBussnies.Create(request));
        }

        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<AlquilerResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] AlquilerRequest request)
        {
            return Ok(_alquilerBussnies.Update(request));
        }

        /// <summary>
        /// ELIMINA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>cantidad de registros eliminados</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(int))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Delete(int id)
        {
            return Ok(_alquilerBussnies.Delete(id));
        }
        #endregion CRUD METHODS
    }
}
