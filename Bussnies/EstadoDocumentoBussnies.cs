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
    public class EstadoDocumentoBussnies : IEstadoDocumentoBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IEstadoDocumentoRepository _EstadoDocumentoRepository;
        private readonly IMapper _mapper;
        public EstadoDocumentoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _EstadoDocumentoRepository = new EstadoDocumentoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<EstadoDocumentoResponse> GetAll()
        {
            List<EstadoDocumento> EstadoDocumentos = _EstadoDocumentoRepository.GetAll();
            List<EstadoDocumentoResponse> lstResponse = _mapper.Map<List<EstadoDocumentoResponse>>(EstadoDocumentos);
            return lstResponse;
        }

        public EstadoDocumentoResponse GetById(int id)
        {
            EstadoDocumento EstadoDocumento = _EstadoDocumentoRepository.GetById(id);
            EstadoDocumentoResponse resul = _mapper.Map<EstadoDocumentoResponse>(EstadoDocumento);
            return resul;
        }

        public EstadoDocumentoResponse Create(EstadoDocumentoRequest entity)
        {
            EstadoDocumento EstadoDocumento = _mapper.Map<EstadoDocumento>(entity);
            EstadoDocumento = _EstadoDocumentoRepository.Create(EstadoDocumento);
            EstadoDocumentoResponse result = _mapper.Map<EstadoDocumentoResponse>(EstadoDocumento);
            return result;
        }
        public List<EstadoDocumentoResponse> InsertMultiple(List<EstadoDocumentoRequest> lista)
        {
            List<EstadoDocumento> EstadoDocumentos = _mapper.Map<List<EstadoDocumento>>(lista);
            EstadoDocumentos = _EstadoDocumentoRepository.InsertMultiple(EstadoDocumentos);
            List<EstadoDocumentoResponse> result = _mapper.Map<List<EstadoDocumentoResponse>>(EstadoDocumentos);
            return result;
        }

        public EstadoDocumentoResponse Update(EstadoDocumentoRequest entity)
        {
            EstadoDocumento EstadoDocumento = _mapper.Map<EstadoDocumento>(entity);
            EstadoDocumento = _EstadoDocumentoRepository.Update(EstadoDocumento);
            EstadoDocumentoResponse result = _mapper.Map<EstadoDocumentoResponse>(EstadoDocumento);
            return result;
        }

        public List<EstadoDocumentoResponse> UpdateMultiple(List<EstadoDocumentoRequest> lista)
        {
            List<EstadoDocumento> EstadoDocumentos = _mapper.Map<List<EstadoDocumento>>(lista);
            EstadoDocumentos = _EstadoDocumentoRepository.UpdateMultiple(EstadoDocumentos);
            List<EstadoDocumentoResponse> result = _mapper.Map<List<EstadoDocumentoResponse>>(EstadoDocumentos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _EstadoDocumentoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<EstadoDocumentoRequest> lista)
        {
            List<EstadoDocumento> EstadoDocumentos = _mapper.Map<List<EstadoDocumento>>(lista);
            int cantidad = _EstadoDocumentoRepository.DeleteMultipleItems(EstadoDocumentos);
            return cantidad;
        }

        public GenericFilterResponse<EstadoDocumentoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<EstadoDocumentoResponse> result = _mapper.Map<GenericFilterResponse<EstadoDocumentoResponse>>(_EstadoDocumentoRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
