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
    public class DocumentoBussnies : IDocumentoBussnies
    {/*INYECCIÓN DE DEPENDECIAS*/
        #region DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE
        private readonly IDocumentoRepository _DocumentoRepository;
        private readonly IMapper _mapper;
        public DocumentoBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _DocumentoRepository = new DocumentoRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion DECLARACIÓN DE VARIABLES Y CONSTRUCTOR / DISPOSE

        #region START CRUD METHODS
        public List<DocumentoResponse> GetAll()
        {
            List<Documento> Documentos = _DocumentoRepository.GetAll();
            List<DocumentoResponse> lstResponse = _mapper.Map<List<DocumentoResponse>>(Documentos);
            return lstResponse;
        }

        public DocumentoResponse GetById(int id)
        {
            Documento Documento = _DocumentoRepository.GetById(id);
            DocumentoResponse resul = _mapper.Map<DocumentoResponse>(Documento);
            return resul;
        }

        public DocumentoResponse Create(DocumentoRequest entity)
        {
            Documento Documento = _mapper.Map<Documento>(entity);
            Documento = _DocumentoRepository.Create(Documento);
            DocumentoResponse result = _mapper.Map<DocumentoResponse>(Documento);
            return result;
        }
        public List<DocumentoResponse> InsertMultiple(List<DocumentoRequest> lista)
        {
            List<Documento> Documentos = _mapper.Map<List<Documento>>(lista);
            Documentos = _DocumentoRepository.InsertMultiple(Documentos);
            List<DocumentoResponse> result = _mapper.Map<List<DocumentoResponse>>(Documentos);
            return result;
        }

        public DocumentoResponse Update(DocumentoRequest entity)
        {
            Documento Documento = _mapper.Map<Documento>(entity);
            Documento = _DocumentoRepository.Update(Documento);
            DocumentoResponse result = _mapper.Map<DocumentoResponse>(Documento);
            return result;
        }

        public List<DocumentoResponse> UpdateMultiple(List<DocumentoRequest> lista)
        {
            List<Documento> Documentos = _mapper.Map<List<Documento>>(lista);
            Documentos = _DocumentoRepository.UpdateMultiple(Documentos);
            List<DocumentoResponse> result = _mapper.Map<List<DocumentoResponse>>(Documentos);
            return result;
        }

        public int Delete(int id)
        {
            int cantidad = _DocumentoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultipleItems(List<DocumentoRequest> lista)
        {
            List<Documento> Documentos = _mapper.Map<List<Documento>>(lista);
            int cantidad = _DocumentoRepository.DeleteMultipleItems(Documentos);
            return cantidad;
        }

        public GenericFilterResponse<DocumentoResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DocumentoResponse> result = _mapper.Map<GenericFilterResponse<DocumentoResponse>>(_DocumentoRepository.GetByFilter(request));

            return result;
        }

        public GenericFilterResponse<VDocumento> GetByFilterView(GenericFilterRequest request)
        {
            GenericFilterResponse<VDocumento> result = _mapper.Map<GenericFilterResponse<VDocumento>>(_DocumentoRepository.GetByFilterView(request));

            return result;
        }




        #endregion END CRUD METHODS
    }
}
