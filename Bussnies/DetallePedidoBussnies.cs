using AutoMapper;
using DBEibyModaModel;
using IBussnies;
using IRepository;
using Repository;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussnies
{
    public class DetallePedidoBussnies : IDetallePedidoBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDetallePedidoRepository _detallePedidoRepository;
        private readonly IMapper _mapper;


        public DetallePedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _detallePedidoRepository = new DetallePedidoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DetallePedidoResponse Create(DetallePedidoRequest entity)
        {
            // CON AUTOMAPPER
            DetallePedido detallePedido = _mapper.Map<DetallePedido>(entity);
            detallePedido = _detallePedidoRepository.Create(detallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(detallePedido);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _detallePedidoRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> detallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            int cantidad = _detallePedidoRepository.DeleteMultipleItems(detallePedidos);

            return cantidad;
        }



        public List<DetallePedidoResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DetallePedido> detallePedido = _detallePedidoRepository.GetAll();
            List<DetallePedidoResponse> lstResponse = _mapper.Map<List<DetallePedidoResponse>>(detallePedido);

            return lstResponse;
        }

        public DetallePedidoResponse GetById(int id)
        {
            DetallePedido detallePedido = _detallePedidoRepository.GetById(id);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(detallePedido);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DetallePedidoResponse> InsertMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> detallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            detallePedidos = _detallePedidoRepository.InsertMultiple(detallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(detallePedidos);

            return result;
        }

        public DetallePedidoResponse Update(DetallePedidoRequest entity)
        {
            DetallePedido detallePedido = _mapper.Map<DetallePedido>(entity);
            detallePedido = _detallePedidoRepository.Update(detallePedido);
            DetallePedidoResponse result = _mapper.Map<DetallePedidoResponse>(detallePedido);


            return result;
        }

        public List<DetallePedidoResponse> UpdateMultiple(List<DetallePedidoRequest> lista)
        {
            List<DetallePedido> detallePedidos = _mapper.Map<List<DetallePedido>>(lista);
            detallePedidos = _detallePedidoRepository.UpdateMultiple(detallePedidos);
            List<DetallePedidoResponse> result = _mapper.Map<List<DetallePedidoResponse>>(detallePedidos);

            return result;
        }

        public GenericFilterResponse<DetallePedidoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DetallePedidoResponse> result = _mapper.Map<GenericFilterResponse<DetallePedidoResponse>>(_detallePedidoRepository.GetByFilter(request));

            return result;
        }
    }
}
