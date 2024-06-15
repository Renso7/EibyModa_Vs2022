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
    public class DocSalidaBussnies : IDocSalidaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDocSalidaRepository _docSalidaRepository;
        private readonly IMapper _mapper;


        public DocSalidaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _docSalidaRepository = new DocSalidaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DocSalidaResponse Create(DocSalidaRequest entity)
        {
            // CON AUTOMAPPER
            DocSalida docSalida = _mapper.Map<DocSalida>(entity);
            docSalida = _docSalidaRepository.Create(docSalida);
            DocSalidaResponse result = _mapper.Map<DocSalidaResponse>(docSalida);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _docSalidaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DocSalidaRequest> lista)
        {
            List<DocSalida> docSalidas = _mapper.Map<List<DocSalida>>(lista);
            int cantidad = _docSalidaRepository.DeleteMultipleItems(docSalidas);

            return cantidad;
        }



        public List<DocSalidaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DocSalida> docSalida = _docSalidaRepository.GetAll();
            List<DocSalidaResponse> lstResponse = _mapper.Map<List<DocSalidaResponse>>(docSalida);

            return lstResponse;
        }

        public DocSalidaResponse GetById(int id)
        {
            DocSalida docSalida = _docSalidaRepository.GetById(id);
            DocSalidaResponse result = _mapper.Map<DocSalidaResponse>(docSalida);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DocSalidaResponse> InsertMultiple(List<DocSalidaRequest> lista)
        {
            List<DocSalida> docSalidas = _mapper.Map<List<DocSalida>>(lista);
            docSalidas = _docSalidaRepository.InsertMultiple(docSalidas);
            List<DocSalidaResponse> result = _mapper.Map<List<DocSalidaResponse>>(docSalidas);

            return result;
        }

        public DocSalidaResponse Update(DocSalidaRequest entity)
        {
            DocSalida docSalida = _mapper.Map<DocSalida>(entity);
            docSalida = _docSalidaRepository.Update(docSalida);
            DocSalidaResponse result = _mapper.Map<DocSalidaResponse>(docSalida);


            return result;
        }

        public List<DocSalidaResponse> UpdateMultiple(List<DocSalidaRequest> lista)
        {
            List<DocSalida> docSalidas = _mapper.Map<List<DocSalida>>(lista);
            docSalidas = _docSalidaRepository.UpdateMultiple(docSalidas);
            List<DocSalidaResponse> result = _mapper.Map<List<DocSalidaResponse>>(docSalidas);

            return result;
        }

        public GenericFilterResponse<DocSalidaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DocSalidaResponse> result = _mapper.Map<GenericFilterResponse<DocSalidaResponse>>(_docSalidaRepository.GetByFilter(request));

            return result;
        }
    }
}
