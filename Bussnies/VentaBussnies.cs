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
    public class VentaBussnies : IVentaBussnies
    { /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IVentaRepository _ventaRepository;
        private readonly IMapper _mapper;


        public VentaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _ventaRepository = new VentaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public VentaResponse Create(VentaRequest entity)
        {
            // CON AUTOMAPPER
            Venta venta = _mapper.Map<Venta>(entity);
            venta = _ventaRepository.Create(venta);
            VentaResponse result = _mapper.Map<VentaResponse>(venta);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _ventaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<VentaRequest> lista)
        {
            List<Venta> ventas = _mapper.Map<List<Venta>>(lista);
            int cantidad = _ventaRepository.DeleteMultipleItems(ventas);

            return cantidad;
        }



        public List<VentaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Venta> venta = _ventaRepository.GetAll();
            List<VentaResponse> lstResponse = _mapper.Map<List<VentaResponse>>(venta);

            return lstResponse;
        }

        public VentaResponse GetById(int id)
        {
            Venta venta = _ventaRepository.GetById(id);
            VentaResponse result = _mapper.Map<VentaResponse>(venta);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<VentaResponse> InsertMultiple(List<VentaRequest> lista)
        {
            List<Venta> ventas = _mapper.Map<List<Venta>>(lista);
            ventas = _ventaRepository.InsertMultiple(ventas);
            List<VentaResponse> result = _mapper.Map<List<VentaResponse>>(ventas);

            return result;
        }

        public VentaResponse Update(VentaRequest entity)
        {
            Venta venta = _mapper.Map<Venta>(entity);
            venta = _ventaRepository.Update(venta);
            VentaResponse result = _mapper.Map<VentaResponse>(venta);


            return result;
        }

        public List<VentaResponse> UpdateMultiple(List<VentaRequest> lista)
        {
            List<Venta> ventas = _mapper.Map<List<Venta>>(lista);
            ventas = _ventaRepository.UpdateMultiple(ventas);
            List<VentaResponse> result = _mapper.Map<List<VentaResponse>>(ventas);

            return result;
        }
        public GenericFilterResponse<VentaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<VentaResponse> result = _mapper.Map<GenericFilterResponse<VentaResponse>>(_ventaRepository.GetByFilter(request));

            return result;
        }
    }
}
