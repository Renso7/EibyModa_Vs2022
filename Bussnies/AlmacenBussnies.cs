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
    /// <summary>
    /// LA CLASE CARGO BUSSNIES HEREDA LOS METODOS DE ==> IALMACENBUSSNIES
    /// </summary>
    public class AlmacenBussnies : IAlmacenBussnies
    {
        /*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IAlmacenRepository _almacenRepository;
        private readonly IMapper _mapper;
        public AlmacenBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _almacenRepository = new AlmacenRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<AlmacenResponse> GetAll()
        {
            List<Almacen> Almacen = _almacenRepository.GetAll();
            List<AlmacenResponse> lstResponse = _mapper.Map<List<AlmacenResponse>>(Almacen);
            return lstResponse;
        }

        public AlmacenResponse GetById(int id)
        {
            Almacen Almacen = _almacenRepository.GetById(id);
            AlmacenResponse resul = _mapper.Map<AlmacenResponse>(Almacen);
            return resul;
        }

        public AlmacenResponse Create(AlmacenRequest entity)
        {
            Almacen Almacen = _mapper.Map<Almacen>(entity);
            Almacen = _almacenRepository.Create(Almacen);
            AlmacenResponse result = _mapper.Map<AlmacenResponse>(Almacen);
            return result;
        }
        public List<AlmacenResponse> InsertMultiple(List<AlmacenRequest> lista)
        {
            List<Almacen> Almacenes = _mapper.Map<List<Almacen>>(lista);
            Almacenes = _almacenRepository.InsertMultiple(Almacenes);
            List<AlmacenResponse> result = _mapper.Map<List<AlmacenResponse>>(Almacenes);
            return result;
        }

        public AlmacenResponse Update(AlmacenRequest entity)
        {
            Almacen Almacen = _mapper.Map<Almacen>(entity);
            Almacen = _almacenRepository.Update(Almacen);
            AlmacenResponse result = _mapper.Map<AlmacenResponse>(Almacen);
            return result;
        }

        public List<AlmacenResponse> UpdateMultiple(List<AlmacenRequest> lista)
        {
            List<Almacen> Almacenes = _mapper.Map<List<Almacen>>(lista);
            Almacenes = _almacenRepository.UpdateMultiple(Almacenes);
            List<AlmacenResponse> result = _mapper.Map<List<AlmacenResponse>>(Almacenes);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _almacenRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<AlmacenRequest> lista)
        {
            List<Almacen> Almacenes = _mapper.Map<List<Almacen>>(lista);
            int cantidad = _almacenRepository.DeleteMultipleItems(Almacenes);
            return cantidad;
        }


        public GenericFilterResponse<AlmacenResponse> GetByFilter(GenericFilterRequest request)
         {

             GenericFilterResponse<AlmacenResponse> result = _mapper.Map<GenericFilterResponse<AlmacenResponse>>(_almacenRepository.GetByFilter(request));

             return result;
         }


        #endregion END CRUD METHODS
    }
}
