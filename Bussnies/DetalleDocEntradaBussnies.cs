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
    public class DetalleDocEntradaBussnies : IDetalleDocEntradaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDetalleDocEntradaRepository _detalleDocEntradaRepository;
        private readonly IMapper _mapper;


        public DetalleDocEntradaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _detalleDocEntradaRepository = new DetalleDocEntradaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DetalleDocEntradaResponse Create(DetalleDocEntradaRequest entity)
        {
            // CON AUTOMAPPER
            DetalleDocEntrada detalleDocEntrada = _mapper.Map<DetalleDocEntrada>(entity);
            detalleDocEntrada = _detalleDocEntradaRepository.Create(detalleDocEntrada);
            DetalleDocEntradaResponse result = _mapper.Map<DetalleDocEntradaResponse>(detalleDocEntrada);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _detalleDocEntradaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DetalleDocEntradaRequest> lista)
        {
            List<DetalleDocEntrada> detalleDocEntradas = _mapper.Map<List<DetalleDocEntrada>>(lista);
            int cantidad = _detalleDocEntradaRepository.DeleteMultipleItems(detalleDocEntradas);

            return cantidad;
        }



        public List<DetalleDocEntradaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DetalleDocEntrada> detalleDocEntrada = _detalleDocEntradaRepository.GetAll();
            List<DetalleDocEntradaResponse> lstResponse = _mapper.Map<List<DetalleDocEntradaResponse>>(detalleDocEntrada);

            return lstResponse;
        }

        public DetalleDocEntradaResponse GetById(int id)
        {
            DetalleDocEntrada detalleDocEntrada = _detalleDocEntradaRepository.GetById(id);
            DetalleDocEntradaResponse result = _mapper.Map<DetalleDocEntradaResponse>(detalleDocEntrada);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DetalleDocEntradaResponse> InsertMultiple(List<DetalleDocEntradaRequest> lista)
        {
            List<DetalleDocEntrada> detalleDocEntradas = _mapper.Map<List<DetalleDocEntrada>>(lista);
            detalleDocEntradas = _detalleDocEntradaRepository.InsertMultiple(detalleDocEntradas);
            List<DetalleDocEntradaResponse> result = _mapper.Map<List<DetalleDocEntradaResponse>>(detalleDocEntradas);

            return result;
        }

        public DetalleDocEntradaResponse Update(DetalleDocEntradaRequest entity)
        {
            DetalleDocEntrada detalleDocEntrada = _mapper.Map<DetalleDocEntrada>(entity);
            detalleDocEntrada = _detalleDocEntradaRepository.Update(detalleDocEntrada);
            DetalleDocEntradaResponse result = _mapper.Map<DetalleDocEntradaResponse>(detalleDocEntrada);


            return result;
        }

        public List<DetalleDocEntradaResponse> UpdateMultiple(List<DetalleDocEntradaRequest> lista)
        {
            List<DetalleDocEntrada> detalleDocEntradas = _mapper.Map<List<DetalleDocEntrada>>(lista);
            detalleDocEntradas = _detalleDocEntradaRepository.UpdateMultiple(detalleDocEntradas);
            List<DetalleDocEntradaResponse> result = _mapper.Map<List<DetalleDocEntradaResponse>>(detalleDocEntradas);

            return result;
        }
        public GenericFilterResponse<DetalleDocEntradaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DetalleDocEntradaResponse> result = _mapper.Map<GenericFilterResponse<DetalleDocEntradaResponse>>(_detalleDocEntradaRepository.GetByFilter(request));

            return result;
        }
    }
}
