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
    public class DocumentoDerivacionesBussnies : IDocumentoDerivacioneBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IDocumentoDerivacionesRepository _DocumentoDerivacionesRepository;
        private readonly IMapper _mapper;
        public DocumentoDerivacionesBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _DocumentoDerivacionesRepository = new DocumentoDerivacionesRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<DocumentoDerivacionesResponse> GetAll()
        {
            List<DocumentoDerivaciones> DocumentoDerivacioness = _DocumentoDerivacionesRepository.GetAll();
            List<DocumentoDerivacionesResponse> lstResponse = _mapper.Map<List<DocumentoDerivacionesResponse>>(DocumentoDerivacioness);
            return lstResponse;
        }

        public DocumentoDerivacionesResponse GetById(int id)
        {
            DocumentoDerivaciones DocumentoDerivaciones = _DocumentoDerivacionesRepository.GetById(id);
            DocumentoDerivacionesResponse resul = _mapper.Map<DocumentoDerivacionesResponse>(DocumentoDerivaciones);
            return resul;
        }

        public DocumentoDerivacionesResponse Create(DocumentoDerivacionesRequest entity)
        {
            DocumentoDerivaciones DocumentoDerivaciones = _mapper.Map<DocumentoDerivaciones>(entity);
            DocumentoDerivaciones = _DocumentoDerivacionesRepository.Create(DocumentoDerivaciones);
            DocumentoDerivacionesResponse result = _mapper.Map<DocumentoDerivacionesResponse>(DocumentoDerivaciones);
            return result;
        }
        public List<DocumentoDerivacionesResponse> InsertMultiple(List<DocumentoDerivacionesRequest> lista)
        {
            List<DocumentoDerivaciones> DocumentoDerivacioness = _mapper.Map<List<DocumentoDerivaciones>>(lista);
            DocumentoDerivacioness = _DocumentoDerivacionesRepository.InsertMultiple(DocumentoDerivacioness);
            List<DocumentoDerivacionesResponse> result = _mapper.Map<List<DocumentoDerivacionesResponse>>(DocumentoDerivacioness);
            return result;
        }

        public DocumentoDerivacionesResponse Update(DocumentoDerivacionesRequest entity)
        {
            DocumentoDerivaciones DocumentoDerivaciones = _mapper.Map<DocumentoDerivaciones>(entity);
            DocumentoDerivaciones = _DocumentoDerivacionesRepository.Update(DocumentoDerivaciones);
            DocumentoDerivacionesResponse result = _mapper.Map<DocumentoDerivacionesResponse>(DocumentoDerivaciones);
            return result;
        }

        public List<DocumentoDerivacionesResponse> UpdateMultiple(List<DocumentoDerivacionesRequest> lista)
        {
            List<DocumentoDerivaciones> DocumentoDerivacioness = _mapper.Map<List<DocumentoDerivaciones>>(lista);
            DocumentoDerivacioness = _DocumentoDerivacionesRepository.UpdateMultiple(DocumentoDerivacioness);
            List<DocumentoDerivacionesResponse> result = _mapper.Map<List<DocumentoDerivacionesResponse>>(DocumentoDerivacioness);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _DocumentoDerivacionesRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<DocumentoDerivacionesRequest> lista)
        {
            List<DocumentoDerivaciones> DocumentoDerivacioness = _mapper.Map<List<DocumentoDerivaciones>>(lista);
            int cantidad = _DocumentoDerivacionesRepository.DeleteMultipleItems(DocumentoDerivacioness);
            return cantidad;
        }

        public GenericFilterResponse<DocumentoDerivacionesResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DocumentoDerivacionesResponse> result = _mapper.Map<GenericFilterResponse<DocumentoDerivacionesResponse>>(_DocumentoDerivacionesRepository.GetByFilter(request));

            return result;
        }


        #endregion END CRUD METHODS
    }
}
