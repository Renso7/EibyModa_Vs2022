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
    public class  DetalleDocSalidaBussnies : IDetalleDocSalidaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDetalleDocSalidaRepository _detalleDocSalidaRepository;
        private readonly IMapper _mapper;


        public DetalleDocSalidaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _detalleDocSalidaRepository = new DetalleDocSalidaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DetalleDocSalidaResponse Create(DetalleDocSalidaRequest entity)
        {
            // CON AUTOMAPPER
            DetalleDocSalida detalleDocSalida = _mapper.Map<DetalleDocSalida>(entity);
            detalleDocSalida = _detalleDocSalidaRepository.Create(detalleDocSalida);
            DetalleDocSalidaResponse result = _mapper.Map<DetalleDocSalidaResponse>(detalleDocSalida);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _detalleDocSalidaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DetalleDocSalidaRequest> lista)
        {
            List<DetalleDocSalida> detalleDocSalidas = _mapper.Map<List<DetalleDocSalida>>(lista);
            int cantidad = _detalleDocSalidaRepository.DeleteMultipleItems(detalleDocSalidas);

            return cantidad;
        }



        public List<DetalleDocSalidaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DetalleDocSalida> detalleDocSalida = _detalleDocSalidaRepository.GetAll();
            List<DetalleDocSalidaResponse> lstResponse = _mapper.Map<List<DetalleDocSalidaResponse>>(detalleDocSalida);

            return lstResponse;
        }

        public DetalleDocSalidaResponse GetById(int id)
        {
            DetalleDocSalida detalleDocSalida = _detalleDocSalidaRepository.GetById(id);
            DetalleDocSalidaResponse result = _mapper.Map<DetalleDocSalidaResponse>(detalleDocSalida);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DetalleDocSalidaResponse> InsertMultiple(List<DetalleDocSalidaRequest> lista)
        {
            List<DetalleDocSalida> detalleDocSalidas = _mapper.Map<List<DetalleDocSalida>>(lista);
            detalleDocSalidas = _detalleDocSalidaRepository.InsertMultiple(detalleDocSalidas);
            List<DetalleDocSalidaResponse> result = _mapper.Map<List<DetalleDocSalidaResponse>>(detalleDocSalidas);

            return result;
        }

        public DetalleDocSalidaResponse Update(DetalleDocSalidaRequest entity)
        {
            DetalleDocSalida detalleDocSalida = _mapper.Map<DetalleDocSalida>(entity);
            detalleDocSalida = _detalleDocSalidaRepository.Update(detalleDocSalida);
            DetalleDocSalidaResponse result = _mapper.Map<DetalleDocSalidaResponse>(detalleDocSalida);


            return result;
        }

        public List<DetalleDocSalidaResponse> UpdateMultiple(List<DetalleDocSalidaRequest> lista)
        {
            List<DetalleDocSalida> detalleDocSalidas = _mapper.Map<List<DetalleDocSalida>>(lista);
            detalleDocSalidas = _detalleDocSalidaRepository.UpdateMultiple(detalleDocSalidas);
            List<DetalleDocSalidaResponse> result = _mapper.Map<List<DetalleDocSalidaResponse>>(detalleDocSalidas);

            return result;
        }

        public GenericFilterResponse<DetalleDocSalidaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DetalleDocSalidaResponse> result = _mapper.Map<GenericFilterResponse<DetalleDocSalidaResponse>>(_detalleDocSalidaRepository.GetByFilter(request));

            return result;
        }
    }
}
