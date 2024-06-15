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
    public class ClienteBussnies : IClienteBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;


        public ClienteBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = new ClienteRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public ClienteResponse Create(ClienteRequest entity)
        {
            // CON AUTOMAPPER
            Cliente cliente = _mapper.Map<Cliente>(entity);
            cliente = _clienteRepository.Create(cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(cliente);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _clienteRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<ClienteRequest> lista)
        {
            List<Cliente> clientes = _mapper.Map<List<Cliente>>(lista);
            int cantidad = _clienteRepository.DeleteMultipleItems(clientes);

            return cantidad;
        }



        public List<ClienteResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Cliente> cliente = _clienteRepository.GetAll();
            List<ClienteResponse> lstResponse = _mapper.Map<List<ClienteResponse>>(cliente);

            return lstResponse;
        }

        public ClienteResponse GetById(int id)
        {
            Cliente cliente = _clienteRepository.GetById(id);
            ClienteResponse result = _mapper.Map<ClienteResponse>(cliente);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<ClienteResponse> InsertMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> clientes = _mapper.Map<List<Cliente>>(lista);
            clientes = _clienteRepository.InsertMultiple(clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(clientes);

            return result;
        }

        public ClienteResponse Update(ClienteRequest entity)
        {
            Cliente cliente = _mapper.Map<Cliente>(entity);
            cliente = _clienteRepository.Update(cliente);
            ClienteResponse result = _mapper.Map<ClienteResponse>(cliente);


            return result;
        }

        public List<ClienteResponse> UpdateMultiple(List<ClienteRequest> lista)
        {
            List<Cliente> clientes = _mapper.Map<List<Cliente>>(lista);
            clientes = _clienteRepository.UpdateMultiple(clientes);
            List<ClienteResponse> result = _mapper.Map<List<ClienteResponse>>(clientes);

            return result;
        }

        public GenericFilterResponse<ClienteResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ClienteResponse> result = _mapper.Map<GenericFilterResponse<ClienteResponse>>(_clienteRepository.GetByFilter(request));

            return result;
        }
    }
}
