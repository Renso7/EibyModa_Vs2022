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
    public class DetallePedidoController : ControllerBase
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTORES
        private readonly IDetallePedidoBussnies _detallePedidoBussnies;
        private readonly IMapper _mapper;

        public DetallePedidoController(IMapper mapper)
        {
            _mapper = mapper;
            _detallePedidoBussnies = new DetallePedidoBussnies(mapper);
        }
        #endregion DECLARACION DE VARIABLES Y CONSTRUCTOR

        #region CRUD METHODS

        /// <summary>
        /// RETORNA TODOS LOS REGISTROS DE LA TABLA CARGO
        /// </summary>
        /// <returns>List-CargoResponse</returns>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetallePedidoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get()
        {
            return Ok(_detallePedidoBussnies.GetAll());
        }

        /// <summary>
        /// RETORNA EL REGISTRO DE LA TABLA FILTRADO POR EL PRIMARY KEY
        /// </summary>
        /// <param name="id">PRIMARY KEY</param>
        /// <returns>CargoResponse</returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetallePedidoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Get(int id)
        {
            return Ok(_detallePedidoBussnies.GetById(id));
        }

        /// <summary>
        /// INSERTA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetallePedidoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Create([FromBody] DetallePedidoRequest request)
        {
            return Ok(_detallePedidoBussnies.Create(request));
        }

        /// <summary>
        /// ACTUALIZA UN REGISTRO EN LA TABLA CARGO
        /// </summary>
        /// <param name="request">CargoRequest</param>
        /// <returns>CargoResponse</returns>
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<DetallePedidoResponse>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public IActionResult Update([FromBody] DetallePedidoRequest request)
        {
            return Ok(_detallePedidoBussnies.Update(request));
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
            return Ok(_detallePedidoBussnies.Delete(id));
        }
        #endregion CRUD METHODS
    }
}
