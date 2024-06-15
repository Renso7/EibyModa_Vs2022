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
    public class PedidoBussnies : IPedidoBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;


        public PedidoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _pedidoRepository = new PedidoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public PedidoResponse Create(PedidoRequest entity)
        {
            // CON AUTOMAPPER
            Pedido pedido = _mapper.Map<Pedido>(entity);
            pedido = _pedidoRepository.Create(pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(pedido);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _pedidoRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<PedidoRequest> lista)
        {
            List<Pedido> pedidos = _mapper.Map<List<Pedido>>(lista);
            int cantidad = _pedidoRepository.DeleteMultipleItems(pedidos);

            return cantidad;
        }



        public List<PedidoResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Pedido> pedido = _pedidoRepository.GetAll();
            List<PedidoResponse> lstResponse = _mapper.Map<List<PedidoResponse>>(pedido);

            return lstResponse;
        }

        public PedidoResponse GetById(int id)
        {
            Pedido pedido = _pedidoRepository.GetById(id);
            PedidoResponse result = _mapper.Map<PedidoResponse>(pedido);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<PedidoResponse> InsertMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> pedidos = _mapper.Map<List<Pedido>>(lista);
            pedidos = _pedidoRepository.InsertMultiple(pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(pedidos);

            return result;
        }

        public PedidoResponse Update(PedidoRequest entity)
        {
            Pedido pedido = _mapper.Map<Pedido>(entity);
            pedido = _pedidoRepository.Update(pedido);
            PedidoResponse result = _mapper.Map<PedidoResponse>(pedido);


            return result;
        }

        public List<PedidoResponse> UpdateMultiple(List<PedidoRequest> lista)
        {
            List<Pedido> pedidos = _mapper.Map<List<Pedido>>(lista);
            pedidos = _pedidoRepository.UpdateMultiple(pedidos);
            List<PedidoResponse> result = _mapper.Map<List<PedidoResponse>>(pedidos);

            return result;
        }
        public GenericFilterResponse<PedidoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<PedidoResponse> result = _mapper.Map<GenericFilterResponse<PedidoResponse>>(_pedidoRepository.GetByFilter(request));

            return result;
        }
    }
}
