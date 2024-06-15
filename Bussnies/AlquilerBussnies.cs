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
    public class AlquilerBussnies : IAlquilerBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IAlquilerRepository _alquilerRepository;
        private readonly IMapper _mapper;
        

        public AlquilerBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _alquilerRepository = new AlquilerRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public AlquilerResponse Create(AlquilerRequest entity)
        {
            // CON AUTOMAPPER
            Alquiler alquiler = _mapper.Map<Alquiler>(entity);
            alquiler = _alquilerRepository.Create(alquiler);
            AlquilerResponse result = _mapper.Map<AlquilerResponse>(alquiler);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _alquilerRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<AlquilerRequest> lista)
        {
            List<Alquiler> alquileres = _mapper.Map<List<Alquiler>>(lista);
            int cantidad = _alquilerRepository.DeleteMultipleItems(alquileres);

            return cantidad;
        }



        public List<AlquilerResponse> GetAll()
        {
            //CON AUTOMAPPER
           
            List<Alquiler> alquiler = _alquilerRepository.GetAll();
            List<AlquilerResponse> lstResponse = _mapper.Map<List<AlquilerResponse>>(alquiler);

            return lstResponse;
        }

        public AlquilerResponse GetById(int id)
        {
            Alquiler alquiler = _alquilerRepository.GetById(id);
            AlquilerResponse result = _mapper.Map<AlquilerResponse>(alquiler);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<AlquilerResponse> InsertMultiple(List<AlquilerRequest> lista)
        {
            List<Alquiler> alquileres = _mapper.Map<List<Alquiler>>(lista);
            alquileres = _alquilerRepository.InsertMultiple(alquileres);
            List<AlquilerResponse> result = _mapper.Map<List<AlquilerResponse>>(alquileres);

            return result;
        }

        public AlquilerResponse Update(AlquilerRequest entity)
        {
            Alquiler alquiler = _mapper.Map<Alquiler>(entity);
            alquiler = _alquilerRepository.Update(alquiler);
            AlquilerResponse result = _mapper.Map<AlquilerResponse>(alquiler);


            return result;
        }

        public List<AlquilerResponse> UpdateMultiple(List<AlquilerRequest> lista)
        {
            List<Alquiler> alquileres = _mapper.Map<List<Alquiler>>(lista);
            alquileres = _alquilerRepository.UpdateMultiple(alquileres);
            List<AlquilerResponse> result = _mapper.Map<List<AlquilerResponse>>(alquileres);

            return result;
        }

        public GenericFilterResponse<AlquilerResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<AlquilerResponse> result = _mapper.Map<GenericFilterResponse<AlquilerResponse>>(_alquilerRepository.GetByFilter(request));

            return result;
        }
    }
}
