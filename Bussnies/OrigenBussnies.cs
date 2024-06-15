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
    public class OrigenBussnies : IOrigenBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IOrigenRepository _OrigenRepository;
        private readonly IMapper _mapper;
        public OrigenBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _OrigenRepository = new OrigenRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<OrigenResponse> GetAll()
        {
            List<Origen> Origens = _OrigenRepository.GetAll();
            List<OrigenResponse> lstResponse = _mapper.Map<List<OrigenResponse>>(Origens);
            return lstResponse;
        }

        public OrigenResponse GetById(int id)
        {
            Origen Origen = _OrigenRepository.GetById(id);
            OrigenResponse resul = _mapper.Map<OrigenResponse>(Origen);
            return resul;
        }

        public OrigenResponse Create(OrigenRequest entity)
        {
            Origen Origen = _mapper.Map<Origen>(entity);
            Origen = _OrigenRepository.Create(Origen);
            OrigenResponse result = _mapper.Map<OrigenResponse>(Origen);
            return result;
        }
        public List<OrigenResponse> InsertMultiple(List<OrigenRequest> lista)
        {
            List<Origen> Origens = _mapper.Map<List<Origen>>(lista);
            Origens = _OrigenRepository.InsertMultiple(Origens);
            List<OrigenResponse> result = _mapper.Map<List<OrigenResponse>>(Origens);
            return result;
        }

        public OrigenResponse Update(OrigenRequest entity)
        {
            Origen Origen = _mapper.Map<Origen>(entity);
            Origen = _OrigenRepository.Update(Origen);
            OrigenResponse result = _mapper.Map<OrigenResponse>(Origen);
            return result;
        }

        public List<OrigenResponse> UpdateMultiple(List<OrigenRequest> lista)
        {
            List<Origen> Origens = _mapper.Map<List<Origen>>(lista);
            Origens = _OrigenRepository.UpdateMultiple(Origens);
            List<OrigenResponse> result = _mapper.Map<List<OrigenResponse>>(Origens);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _OrigenRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<OrigenRequest> lista)
        {
            List<Origen> Origens = _mapper.Map<List<Origen>>(lista);
            int cantidad = _OrigenRepository.DeleteMultipleItems(Origens);
            return cantidad;
        }

        public GenericFilterResponse<OrigenResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<OrigenResponse> result = _mapper.Map<GenericFilterResponse<OrigenResponse>>(_OrigenRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
