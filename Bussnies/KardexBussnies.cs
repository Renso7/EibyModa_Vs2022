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
    public class KardexBussnies : IKardexBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IKardexRepository _kardexRepository;
        private readonly IMapper _mapper;


        public KardexBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _kardexRepository = new KardexRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public KardexResponse Create(KardexRequest entity)
        {
            // CON AUTOMAPPER
            Kardex kardex = _mapper.Map<Kardex>(entity);
            kardex = _kardexRepository.Create(kardex);
            KardexResponse result = _mapper.Map<KardexResponse>(kardex);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _kardexRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<KardexRequest> lista)
        {
            List<Kardex> clientes = _mapper.Map<List<Kardex>>(lista);
            int cantidad = _kardexRepository.DeleteMultipleItems(clientes);

            return cantidad;
        }



        public List<KardexResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Kardex> kardex = _kardexRepository.GetAll();
            List<KardexResponse> lstResponse = _mapper.Map<List<KardexResponse>>(kardex);

            return lstResponse;
        }

        public KardexResponse GetById(int id)
        {
            Kardex kardex = _kardexRepository.GetById(id);
            KardexResponse result = _mapper.Map<KardexResponse>(kardex);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<KardexResponse> InsertMultiple(List<KardexRequest> lista)
        {
            List<Kardex> clientes = _mapper.Map<List<Kardex>>(lista);
            clientes = _kardexRepository.InsertMultiple(clientes);
            List<KardexResponse> result = _mapper.Map<List<KardexResponse>>(clientes);

            return result;
        }

        public KardexResponse Update(KardexRequest entity)
        {
            Kardex kardex = _mapper.Map<Kardex>(entity);
            kardex = _kardexRepository.Update(kardex);
            KardexResponse result = _mapper.Map<KardexResponse>(kardex);


            return result;
        }

        public List<KardexResponse> UpdateMultiple(List<KardexRequest> lista)
        {
            List<Kardex> clientes = _mapper.Map<List<Kardex>>(lista);
            clientes = _kardexRepository.UpdateMultiple(clientes);
            List<KardexResponse> result = _mapper.Map<List<KardexResponse>>(clientes);

            return result;
        }
        public GenericFilterResponse<KardexResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<KardexResponse> result = _mapper.Map<GenericFilterResponse<KardexResponse>>(_kardexRepository.GetByFilter(request));

            return result;
        }
    }
}
