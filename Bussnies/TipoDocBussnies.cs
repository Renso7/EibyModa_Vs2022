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
    public class TipoDocBussnies : ITipoDocBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly ITipoDocRepository _tipoDocRepository;
        private readonly IMapper _mapper;


        public TipoDocBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _tipoDocRepository = new TipoDocRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public TipoDocResponse Create(TipoDocRequest entity)
        {
            // CON AUTOMAPPER
            TipoDoc tipoDoc = _mapper.Map<TipoDoc>(entity);
            tipoDoc = _tipoDocRepository.Create(tipoDoc);
            TipoDocResponse result = _mapper.Map<TipoDocResponse>(tipoDoc);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _tipoDocRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<TipoDocRequest> lista)
        {
            List<TipoDoc> TipoDocs = _mapper.Map<List<TipoDoc>>(lista);
            int cantidad = _tipoDocRepository.DeleteMultipleItems(TipoDocs);

            return cantidad;
        }



        public List<TipoDocResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<TipoDoc> tipoDoc = _tipoDocRepository.GetAll();
            List<TipoDocResponse> lstResponse = _mapper.Map<List<TipoDocResponse>>(tipoDoc);

            return lstResponse;
        }

        public TipoDocResponse GetById(int id)
        {
            TipoDoc tipoDoc = _tipoDocRepository.GetById(id);
            TipoDocResponse result = _mapper.Map<TipoDocResponse>(tipoDoc);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<TipoDocResponse> InsertMultiple(List<TipoDocRequest> lista)
        {
            List<TipoDoc> TipoDocs = _mapper.Map<List<TipoDoc>>(lista);
            TipoDocs = _tipoDocRepository.InsertMultiple(TipoDocs);
            List<TipoDocResponse> result = _mapper.Map<List<TipoDocResponse>>(TipoDocs);

            return result;
        }

        public TipoDocResponse Update(TipoDocRequest entity)
        {
            TipoDoc tipoDoc = _mapper.Map<TipoDoc>(entity);
            tipoDoc = _tipoDocRepository.Update(tipoDoc);
            TipoDocResponse result = _mapper.Map<TipoDocResponse>(tipoDoc);


            return result;
        }

        public List<TipoDocResponse> UpdateMultiple(List<TipoDocRequest> lista)
        {
            List<TipoDoc> TipoDocs = _mapper.Map<List<TipoDoc>>(lista);
            TipoDocs = _tipoDocRepository.UpdateMultiple(TipoDocs);
            List<TipoDocResponse> result = _mapper.Map<List<TipoDocResponse>>(TipoDocs);

            return result;
        }
        public GenericFilterResponse<TipoDocResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<TipoDocResponse> result = _mapper.Map<GenericFilterResponse<TipoDocResponse>>(_tipoDocRepository.GetByFilter(request));

            return result;
        }
    }
}
