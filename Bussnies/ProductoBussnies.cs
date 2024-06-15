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
    public class ProductoBussnies : IProductoBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;


        public ProductoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _productoRepository = new ProductoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public ProductoResponse Create(ProductoRequest entity)
        {
            // CON AUTOMAPPER
            Producto producto = _mapper.Map<Producto>(entity);
            producto = _productoRepository.Create(producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(producto);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _productoRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<ProductoRequest> lista)
        {
            List<Producto> productos = _mapper.Map<List<Producto>>(lista);
            int cantidad = _productoRepository.DeleteMultipleItems(productos);

            return cantidad;
        }



        public List<ProductoResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Producto> producto = _productoRepository.GetAll();
            List<ProductoResponse> lstResponse = _mapper.Map<List<ProductoResponse>>(producto);

            return lstResponse;
        }

        public ProductoResponse GetById(int id)
        {
            Producto producto = _productoRepository.GetById(id);
            ProductoResponse result = _mapper.Map<ProductoResponse>(producto);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<ProductoResponse> InsertMultiple(List<ProductoRequest> lista)
        {
            List<Producto> productos = _mapper.Map<List<Producto>>(lista);
            productos = _productoRepository.InsertMultiple(productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(productos);

            return result;
        }

        public ProductoResponse Update(ProductoRequest entity)
        {
            Producto producto = _mapper.Map<Producto>(entity);
            producto = _productoRepository.Update(producto);
            ProductoResponse result = _mapper.Map<ProductoResponse>(producto);


            return result;
        }

        public List<ProductoResponse> UpdateMultiple(List<ProductoRequest> lista)
        {
            List<Producto> productos = _mapper.Map<List<Producto>>(lista);
            productos = _productoRepository.UpdateMultiple(productos);
            List<ProductoResponse> result = _mapper.Map<List<ProductoResponse>>(productos);

            return result;
        }
        public GenericFilterResponse<ProductoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ProductoResponse> result = _mapper.Map<GenericFilterResponse<ProductoResponse>>(_productoRepository.GetByFilter(request));

            return result;
        }
    }
}
