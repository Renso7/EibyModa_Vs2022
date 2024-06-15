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
    public class ProveedorBussnies : IProveedorBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IMapper _mapper;


        public ProveedorBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _proveedorRepository = new ProveedorRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public ProveedorResponse Create(ProveedorRequest entity)
        {
            // CON AUTOMAPPER
            Proveedor proveedor = _mapper.Map<Proveedor>(entity);
            proveedor = _proveedorRepository.Create(proveedor);
            ProveedorResponse result = _mapper.Map<ProveedorResponse>(proveedor);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _proveedorRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<ProveedorRequest> lista)
        {
            List<Proveedor> proveedores = _mapper.Map<List<Proveedor>>(lista);
            int cantidad = _proveedorRepository.DeleteMultipleItems(proveedores);

            return cantidad;
        }



        public List<ProveedorResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Proveedor> proveedor = _proveedorRepository.GetAll();
            List<ProveedorResponse> lstResponse = _mapper.Map<List<ProveedorResponse>>(proveedor);

            return lstResponse;
        }

        public ProveedorResponse GetById(int id)
        {
            Proveedor proveedor = _proveedorRepository.GetById(id);
            ProveedorResponse result = _mapper.Map<ProveedorResponse>(proveedor);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<ProveedorResponse> InsertMultiple(List<ProveedorRequest> lista)
        {
            List<Proveedor> proveedores = _mapper.Map<List<Proveedor>>(lista);
            proveedores = _proveedorRepository.InsertMultiple(proveedores);
            List<ProveedorResponse> result = _mapper.Map<List<ProveedorResponse>>(proveedores);

            return result;
        }

        public ProveedorResponse Update(ProveedorRequest entity)
        {
            Proveedor proveedor = _mapper.Map<Proveedor>(entity);
            proveedor = _proveedorRepository.Update(proveedor);
            ProveedorResponse result = _mapper.Map<ProveedorResponse>(proveedor);


            return result;
        }

        public List<ProveedorResponse> UpdateMultiple(List<ProveedorRequest> lista)
        {
            List<Proveedor> proveedores = _mapper.Map<List<Proveedor>>(lista);
            proveedores = _proveedorRepository.UpdateMultiple(proveedores);
            List<ProveedorResponse> result = _mapper.Map<List<ProveedorResponse>>(proveedores);

            return result;
        }
        public GenericFilterResponse<ProveedorResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<ProveedorResponse> result = _mapper.Map<GenericFilterResponse<ProveedorResponse>>(_proveedorRepository.GetByFilter(request));

            return result;
        }
    }
}
