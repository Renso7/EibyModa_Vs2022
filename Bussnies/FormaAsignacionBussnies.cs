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
    public class FormaAsignacionBussnies : IFormaAsignacionBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IFormaAsignacionRepository _FormaAsignacionRepository;
        private readonly IMapper _mapper;
        public FormaAsignacionBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _FormaAsignacionRepository = new FormaAsignacionRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<FormaAsignacionResponse> GetAll()
        {
            List<FormaAsignacion> FormaAsignacions = _FormaAsignacionRepository.GetAll();
            List<FormaAsignacionResponse> lstResponse = _mapper.Map<List<FormaAsignacionResponse>>(FormaAsignacions);
            return lstResponse;
        }

        public FormaAsignacionResponse GetById(int id)
        {
            FormaAsignacion FormaAsignacion = _FormaAsignacionRepository.GetById(id);
            FormaAsignacionResponse resul = _mapper.Map<FormaAsignacionResponse>(FormaAsignacion);
            return resul;
        }

        public FormaAsignacionResponse Create(FormaAsignacionRequest entity)
        {
            FormaAsignacion FormaAsignacion = _mapper.Map<FormaAsignacion>(entity);
            FormaAsignacion = _FormaAsignacionRepository.Create(FormaAsignacion);
            FormaAsignacionResponse result = _mapper.Map<FormaAsignacionResponse>(FormaAsignacion);
            return result;
        }
        public List<FormaAsignacionResponse> InsertMultiple(List<FormaAsignacionRequest> lista)
        {
            List<FormaAsignacion> FormaAsignacions = _mapper.Map<List<FormaAsignacion>>(lista);
            FormaAsignacions = _FormaAsignacionRepository.InsertMultiple(FormaAsignacions);
            List<FormaAsignacionResponse> result = _mapper.Map<List<FormaAsignacionResponse>>(FormaAsignacions);
            return result;
        }

        public FormaAsignacionResponse Update(FormaAsignacionRequest entity)
        {
            FormaAsignacion FormaAsignacion = _mapper.Map<FormaAsignacion>(entity);
            FormaAsignacion = _FormaAsignacionRepository.Update(FormaAsignacion);
            FormaAsignacionResponse result = _mapper.Map<FormaAsignacionResponse>(FormaAsignacion);
            return result;
        }

        public List<FormaAsignacionResponse> UpdateMultiple(List<FormaAsignacionRequest> lista)
        {
            List<FormaAsignacion> FormaAsignacions = _mapper.Map<List<FormaAsignacion>>(lista);
            FormaAsignacions = _FormaAsignacionRepository.UpdateMultiple(FormaAsignacions);
            List<FormaAsignacionResponse> result = _mapper.Map<List<FormaAsignacionResponse>>(FormaAsignacions);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _FormaAsignacionRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<FormaAsignacionRequest> lista)
        {
            List<FormaAsignacion> FormaAsignacions = _mapper.Map<List<FormaAsignacion>>(lista);
            int cantidad = _FormaAsignacionRepository.DeleteMultipleItems(FormaAsignacions);
            return cantidad;
        }

        public GenericFilterResponse<FormaAsignacionResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<FormaAsignacionResponse> result = _mapper.Map<GenericFilterResponse<FormaAsignacionResponse>>(_FormaAsignacionRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
