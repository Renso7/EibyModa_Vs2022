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
    public class FormaRecepcionBussnies : IFormaRecepcionBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IFormaRecepcionRepository _FormaRecepcionRepository;
        private readonly IMapper _mapper;
        public FormaRecepcionBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _FormaRecepcionRepository = new FormaRecepcionRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<FormaRecepcionResponse> GetAll()
        {
            List<FormaRecepcion> FormaRecepcions = _FormaRecepcionRepository.GetAll();
            List<FormaRecepcionResponse> lstResponse = _mapper.Map<List<FormaRecepcionResponse>>(FormaRecepcions);
            return lstResponse;
        }

        public FormaRecepcionResponse GetById(int id)
        {
            FormaRecepcion FormaRecepcion = _FormaRecepcionRepository.GetById(id);
            FormaRecepcionResponse resul = _mapper.Map<FormaRecepcionResponse>(FormaRecepcion);
            return resul;
        }

        public FormaRecepcionResponse Create(FormaRecepcionRequest entity)
        {
            FormaRecepcion FormaRecepcion = _mapper.Map<FormaRecepcion>(entity);
            FormaRecepcion = _FormaRecepcionRepository.Create(FormaRecepcion);
            FormaRecepcionResponse result = _mapper.Map<FormaRecepcionResponse>(FormaRecepcion);
            return result;
        }
        public List<FormaRecepcionResponse> InsertMultiple(List<FormaRecepcionRequest> lista)
        {
            List<FormaRecepcion> FormaRecepcions = _mapper.Map<List<FormaRecepcion>>(lista);
            FormaRecepcions = _FormaRecepcionRepository.InsertMultiple(FormaRecepcions);
            List<FormaRecepcionResponse> result = _mapper.Map<List<FormaRecepcionResponse>>(FormaRecepcions);
            return result;
        }

        public FormaRecepcionResponse Update(FormaRecepcionRequest entity)
        {
            FormaRecepcion FormaRecepcion = _mapper.Map<FormaRecepcion>(entity);
            FormaRecepcion = _FormaRecepcionRepository.Update(FormaRecepcion);
            FormaRecepcionResponse result = _mapper.Map<FormaRecepcionResponse>(FormaRecepcion);
            return result;
        }

        public List<FormaRecepcionResponse> UpdateMultiple(List<FormaRecepcionRequest> lista)
        {
            List<FormaRecepcion> FormaRecepcions = _mapper.Map<List<FormaRecepcion>>(lista);
            FormaRecepcions = _FormaRecepcionRepository.UpdateMultiple(FormaRecepcions);
            List<FormaRecepcionResponse> result = _mapper.Map<List<FormaRecepcionResponse>>(FormaRecepcions);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _FormaRecepcionRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<FormaRecepcionRequest> lista)
        {
            List<FormaRecepcion> FormaRecepcions = _mapper.Map<List<FormaRecepcion>>(lista);
            int cantidad = _FormaRecepcionRepository.DeleteMultipleItems(FormaRecepcions);
            return cantidad;
        }

        public GenericFilterResponse<FormaRecepcionResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<FormaRecepcionResponse> result = _mapper.Map<GenericFilterResponse<FormaRecepcionResponse>>(_FormaRecepcionRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
