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
    public class CarritoComprasBussnies : ICarritoComprasBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly ICarritocomprasRepository _carritocomprasRepository;
        private readonly IMapper _mapper;
        #endregion Declaracionde variables y constructor

        public CarritoComprasBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _carritocomprasRepository = new CarritocomprasRepository();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public CarritoComprasResponse Create(CarritoComprasRequest entity)
        {
            // CON AUTOMAPPER
            CarritoCompras carritocompras = _mapper.Map<CarritoCompras>(entity);
            carritocompras = _carritocomprasRepository.Create(carritocompras);
            CarritoComprasResponse result = _mapper.Map<CarritoComprasResponse>(carritocompras);


            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _carritocomprasRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<CarritoComprasRequest> lista)
        {
            List<CarritoCompras> carritocompras = _mapper.Map<List<CarritoCompras>>(lista);
            int cantidad = _carritocomprasRepository.DeleteMultipleItems(carritocompras);

            return cantidad;
        }

        public List<CarritoComprasResponse> GetAll()
        {
            //CON AUTOMAPPER
            List<CarritoComprasResponse> lstResponse = new List<CarritoComprasResponse>();
            List<CarritoCompras> carritos = _carritocomprasRepository.GetAll();

            lstResponse = _mapper.Map<List<CarritoComprasResponse>>(carritos);
            return lstResponse;
        }

        public CarritoComprasResponse GetById(int id)
        {
            CarritoCompras carritocompras = _carritocomprasRepository.GetById(id);
            CarritoComprasResponse result = _mapper.Map<CarritoComprasResponse>(carritocompras);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<CarritoComprasResponse> InsertMultiple(List<CarritoComprasRequest> lista)
        {
            List<CarritoCompras> carritos = _mapper.Map<List<CarritoCompras>>(lista);
            carritos = _carritocomprasRepository.InsertMultiple(carritos);
            List<CarritoComprasResponse> result = _mapper.Map<List<CarritoComprasResponse>>(carritos);

            return result;
        }

        public CarritoComprasResponse Update(CarritoComprasRequest entity)
        {
            CarritoCompras carritos = _mapper.Map<CarritoCompras>(entity);
            carritos = _carritocomprasRepository.Update(carritos);
            CarritoComprasResponse result = _mapper.Map<CarritoComprasResponse>(carritos);


            return result;
        }

        public List<CarritoComprasResponse> UpdateMultiple(List<CarritoComprasRequest> lista)
        {
            List<CarritoCompras> carritos = _mapper.Map<List<CarritoCompras>>(lista);
            carritos = _carritocomprasRepository.UpdateMultiple(carritos);
            List<CarritoComprasResponse> result = _mapper.Map<List<CarritoComprasResponse>>(carritos);

            return result;
        }

        public GenericFilterResponse<CarritoComprasResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<CarritoComprasResponse> result = _mapper.Map<GenericFilterResponse<CarritoComprasResponse>>(_carritocomprasRepository.GetByFilter(request));

            return result;
        }
    }
}
