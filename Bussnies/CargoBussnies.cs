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
    public class CargoBussnies : ICargoBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly ICargoRepository _CargoRepository;
        private readonly IMapper _mapper;
        public CargoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _CargoRepository = new CargoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<CargoResponse> GetAll()
        {
            List<Cargo> Cargos = _CargoRepository.GetAll();
            List<CargoResponse> lstResponse = _mapper.Map<List<CargoResponse>>(Cargos);
            return lstResponse;
        }

        public CargoResponse GetById(int id)
        {
            Cargo Cargo = _CargoRepository.GetById(id);
            CargoResponse resul = _mapper.Map<CargoResponse>(Cargo);
            return resul;
        }

        public CargoResponse Create(CargoRequest entity)
        {
            Cargo Cargo = _mapper.Map<Cargo>(entity);
            Cargo = _CargoRepository.Create(Cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(Cargo);
            return result;
        }
        public List<CargoResponse> InsertMultiple(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            Cargos = _CargoRepository.InsertMultiple(Cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(Cargos);
            return result;
        }

        public CargoResponse Update(CargoRequest entity)
        {
            Cargo Cargo = _mapper.Map<Cargo>(entity);
            Cargo = _CargoRepository.Update(Cargo);
            CargoResponse result = _mapper.Map<CargoResponse>(Cargo);
            return result;
        }

        public List<CargoResponse> UpdateMultiple(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            Cargos = _CargoRepository.UpdateMultiple(Cargos);
            List<CargoResponse> result = _mapper.Map<List<CargoResponse>>(Cargos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _CargoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<CargoRequest> lista)
        {
            List<Cargo> Cargos = _mapper.Map<List<Cargo>>(lista);
            int cantidad = _CargoRepository.DeleteMultipleItems(Cargos);
            return cantidad;
        }

        public GenericFilterResponse<CargoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<CargoResponse> result = _mapper.Map<GenericFilterResponse<CargoResponse>>(_CargoRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
