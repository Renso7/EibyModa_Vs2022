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
    public class EmpleadoBussnies : IEmpleadoBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;


        public EmpleadoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _empleadoRepository = new EmpleadoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public EmpleadoResponse Create(EmpleadoRequest entity)
        {
            // CON AUTOMAPPER
            Empleado empleado = _mapper.Map<Empleado>(entity);
            empleado = _empleadoRepository.Create(empleado);
            EmpleadoResponse result = _mapper.Map<EmpleadoResponse>(empleado);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _empleadoRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<EmpleadoRequest> lista)
        {
            List<Empleado> empleados = _mapper.Map<List<Empleado>>(lista);
            int cantidad = _empleadoRepository.DeleteMultipleItems(empleados);

            return cantidad;
        }



        public List<EmpleadoResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Empleado> empleado = _empleadoRepository.GetAll();
            List<EmpleadoResponse> lstResponse = _mapper.Map<List<EmpleadoResponse>>(empleado);

            return lstResponse;
        }

        public EmpleadoResponse GetById(int id)
        {
            Empleado empleado = _empleadoRepository.GetById(id);
            EmpleadoResponse result = _mapper.Map<EmpleadoResponse>(empleado);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<EmpleadoResponse> InsertMultiple(List<EmpleadoRequest> lista)
        {
            List<Empleado> empleados = _mapper.Map<List<Empleado>>(lista);
            empleados = _empleadoRepository.InsertMultiple(empleados);
            List<EmpleadoResponse> result = _mapper.Map<List<EmpleadoResponse>>(empleados);

            return result;
        }

        public EmpleadoResponse Update(EmpleadoRequest entity)
        {
            Empleado empleado = _mapper.Map<Empleado>(entity);
            empleado = _empleadoRepository.Update(empleado);
            EmpleadoResponse result = _mapper.Map<EmpleadoResponse>(empleado);


            return result;
        }

        public List<EmpleadoResponse> UpdateMultiple(List<EmpleadoRequest> lista)
        {
            List<Empleado> empleados = _mapper.Map<List<Empleado>>(lista);
            empleados = _empleadoRepository.UpdateMultiple(empleados);
            List<EmpleadoResponse> result = _mapper.Map<List<EmpleadoResponse>>(empleados);

            return result;
        }

        public GenericFilterResponse<EmpleadoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<EmpleadoResponse> result = _mapper.Map<GenericFilterResponse<EmpleadoResponse>>(_empleadoRepository.GetByFilter(request));

            return result;
        }
    }
}
