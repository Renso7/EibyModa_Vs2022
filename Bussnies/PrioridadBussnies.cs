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
    public class PrioridadBussnies : IPrioridadBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IPrioridadRepository _PrioridadRepository;
        private readonly IMapper _mapper;
        public PrioridadBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _PrioridadRepository = new PrioridadRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<PrioridadResponse> GetAll()
        {
            List<Prioridad> Prioridads = _PrioridadRepository.GetAll();
            List<PrioridadResponse> lstResponse = _mapper.Map<List<PrioridadResponse>>(Prioridads);
            return lstResponse;
        }

        public PrioridadResponse GetById(int id)
        {
            Prioridad Prioridad = _PrioridadRepository.GetById(id);
            PrioridadResponse resul = _mapper.Map<PrioridadResponse>(Prioridad);
            return resul;
        }

        public PrioridadResponse Create(PrioridadRequest entity)
        {
            Prioridad Prioridad = _mapper.Map<Prioridad>(entity);
            Prioridad = _PrioridadRepository.Create(Prioridad);
            PrioridadResponse result = _mapper.Map<PrioridadResponse>(Prioridad);
            return result;
        }
        public List<PrioridadResponse> InsertMultiple(List<PrioridadRequest> lista)
        {
            List<Prioridad> Prioridads = _mapper.Map<List<Prioridad>>(lista);
            Prioridads = _PrioridadRepository.InsertMultiple(Prioridads);
            List<PrioridadResponse> result = _mapper.Map<List<PrioridadResponse>>(Prioridads);
            return result;
        }

        public PrioridadResponse Update(PrioridadRequest entity)
        {
            Prioridad Prioridad = _mapper.Map<Prioridad>(entity);
            Prioridad = _PrioridadRepository.Update(Prioridad);
            PrioridadResponse result = _mapper.Map<PrioridadResponse>(Prioridad);
            return result;
        }

        public List<PrioridadResponse> UpdateMultiple(List<PrioridadRequest> lista)
        {
            List<Prioridad> Prioridads = _mapper.Map<List<Prioridad>>(lista);
            Prioridads = _PrioridadRepository.UpdateMultiple(Prioridads);
            List<PrioridadResponse> result = _mapper.Map<List<PrioridadResponse>>(Prioridads);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _PrioridadRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<PrioridadRequest> lista)
        {
            List<Prioridad> Prioridads = _mapper.Map<List<Prioridad>>(lista);
            int cantidad = _PrioridadRepository.DeleteMultipleItems(Prioridads);
            return cantidad;
        }

        public GenericFilterResponse<PrioridadResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<PrioridadResponse> result = _mapper.Map<GenericFilterResponse<PrioridadResponse>>(_PrioridadRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
