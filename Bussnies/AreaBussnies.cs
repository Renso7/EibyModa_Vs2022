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
    public class AreaBussnies : IAreaBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IAreaRepository _AreaRepository;
        private readonly IMapper _mapper;
        public AreaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _AreaRepository = new AreaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<AreaResponse> GetAll()
        {
            List<Area> Areas = _AreaRepository.GetAll();
            List<AreaResponse> lstResponse = _mapper.Map<List<AreaResponse>>(Areas);
            return lstResponse;
        }

        public AreaResponse GetById(int id)
        {
            Area Area = _AreaRepository.GetById(id);
            AreaResponse resul = _mapper.Map<AreaResponse>(Area);
            return resul;
        }

        public AreaResponse Create(AreaRequest entity)
        {
            Area Area = _mapper.Map<Area>(entity);
            Area = _AreaRepository.Create(Area);
            AreaResponse result = _mapper.Map<AreaResponse>(Area);
            return result;
        }
        public List<AreaResponse> InsertMultiple(List<AreaRequest> lista)
        {
            List<Area> Areas = _mapper.Map<List<Area>>(lista);
            Areas = _AreaRepository.InsertMultiple(Areas);
            List<AreaResponse> result = _mapper.Map<List<AreaResponse>>(Areas);
            return result;
        }

        public AreaResponse Update(AreaRequest entity)
        {
            Area Area = _mapper.Map<Area>(entity);
            Area = _AreaRepository.Update(Area);
            AreaResponse result = _mapper.Map<AreaResponse>(Area);
            return result;
        }

        public List<AreaResponse> UpdateMultiple(List<AreaRequest> lista)
        {
            List<Area> Areas = _mapper.Map<List<Area>>(lista);
            Areas = _AreaRepository.UpdateMultiple(Areas);
            List<AreaResponse> result = _mapper.Map<List<AreaResponse>>(Areas);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _AreaRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<AreaRequest> lista)
        {
            List<Area> Areas = _mapper.Map<List<Area>>(lista);
            int cantidad = _AreaRepository.DeleteMultipleItems(Areas);
            return cantidad;
        }

        public GenericFilterResponse<AreaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<AreaResponse> result = _mapper.Map<GenericFilterResponse<AreaResponse>>(_AreaRepository.GetByFilter());

            return result;
        }


        #endregion END CRUD METHODS
    }
}
