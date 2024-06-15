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
    public class DetalleVentaBussnies : IDetalleVentaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDetalleVentaRepository _detalleVentaRepository;
        private readonly IMapper _mapper;


        public DetalleVentaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _detalleVentaRepository = new DetalleVentaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DetalleVentaResponse Create(DetalleVentaRequest entity)
        {
            // CON AUTOMAPPER
            DetalleVenta detalleVenta = _mapper.Map<DetalleVenta>(entity);
            detalleVenta = _detalleVentaRepository.Create(detalleVenta);
            DetalleVentaResponse result = _mapper.Map<DetalleVentaResponse>(detalleVenta);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _detalleVentaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DetalleVentaRequest> lista)
        {
            List<DetalleVenta> detalleVentas = _mapper.Map<List<DetalleVenta>>(lista);
            int cantidad = _detalleVentaRepository.DeleteMultipleItems(detalleVentas);

            return cantidad;
        }



        public List<DetalleVentaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DetalleVenta> detalleVenta = _detalleVentaRepository.GetAll();
            List<DetalleVentaResponse> lstResponse = _mapper.Map<List<DetalleVentaResponse>>(detalleVenta);

            return lstResponse;
        }

        public DetalleVentaResponse GetById(int id)
        {
            DetalleVenta detalleVenta = _detalleVentaRepository.GetById(id);
            DetalleVentaResponse result = _mapper.Map<DetalleVentaResponse>(detalleVenta);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DetalleVentaResponse> InsertMultiple(List<DetalleVentaRequest> lista)
        {
            List<DetalleVenta> detalleVentas = _mapper.Map<List<DetalleVenta>>(lista);
            detalleVentas = _detalleVentaRepository.InsertMultiple(detalleVentas);
            List<DetalleVentaResponse> result = _mapper.Map<List<DetalleVentaResponse>>(detalleVentas);

            return result;
        }

        public DetalleVentaResponse Update(DetalleVentaRequest entity)
        {
            DetalleVenta detalleVenta = _mapper.Map<DetalleVenta>(entity);
            detalleVenta = _detalleVentaRepository.Update(detalleVenta);
            DetalleVentaResponse result = _mapper.Map<DetalleVentaResponse>(detalleVenta);


            return result;
        }

        public List<DetalleVentaResponse> UpdateMultiple(List<DetalleVentaRequest> lista)
        {
            List<DetalleVenta> detalleVentas = _mapper.Map<List<DetalleVenta>>(lista);
            detalleVentas = _detalleVentaRepository.UpdateMultiple(detalleVentas);
            List<DetalleVentaResponse> result = _mapper.Map<List<DetalleVentaResponse>>(detalleVentas);

            return result;
        }

        public GenericFilterResponse<DetalleVentaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DetalleVentaResponse> result = _mapper.Map<GenericFilterResponse<DetalleVentaResponse>>(_detalleVentaRepository.GetByFilter(request));

            return result;
        }
    }
}
