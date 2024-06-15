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
    public class DocEntradaBussnies : IDocEntradaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly IDocEntradaRepository _docEntradaRepository;
        private readonly IMapper _mapper;


        public DocEntradaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _docEntradaRepository = new DocEntradaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        public DocEntradaResponse Create(DocEntradaRequest entity)
        {
            // CON AUTOMAPPER
            DocEntrada docEntrada = _mapper.Map<DocEntrada>(entity);
            docEntrada = _docEntradaRepository.Create(docEntrada);
            DocEntradaResponse result = _mapper.Map<DocEntradaResponse>(docEntrada);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _docEntradaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<DocEntradaRequest> lista)
        {
            List<DocEntrada> docEntradas = _mapper.Map<List<DocEntrada>>(lista);
            int cantidad = _docEntradaRepository.DeleteMultipleItems(docEntradas);

            return cantidad;
        }



        public List<DocEntradaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<DocEntrada> docEntrada = _docEntradaRepository.GetAll();
            List<DocEntradaResponse> lstResponse = _mapper.Map<List<DocEntradaResponse>>(docEntrada);

            return lstResponse;
        }

        public DocEntradaResponse GetById(int id)
        {
            DocEntrada docEntrada = _docEntradaRepository.GetById(id);
            DocEntradaResponse result = _mapper.Map<DocEntradaResponse>(docEntrada);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<DocEntradaResponse> InsertMultiple(List<DocEntradaRequest> lista)
        {
            List<DocEntrada> docEntradas = _mapper.Map<List<DocEntrada>>(lista);
            docEntradas = _docEntradaRepository.InsertMultiple(docEntradas);
            List<DocEntradaResponse> result = _mapper.Map<List<DocEntradaResponse>>(docEntradas);

            return result;
        }

        public DocEntradaResponse Update(DocEntradaRequest entity)
        {
            DocEntrada docEntrada = _mapper.Map<DocEntrada>(entity);
            docEntrada = _docEntradaRepository.Update(docEntrada);
            DocEntradaResponse result = _mapper.Map<DocEntradaResponse>(docEntrada);


            return result;
        }

        public List<DocEntradaResponse> UpdateMultiple(List<DocEntradaRequest> lista)
        {
            List<DocEntrada> docEntradas = _mapper.Map<List<DocEntrada>>(lista);
            docEntradas = _docEntradaRepository.UpdateMultiple(docEntradas);
            List<DocEntradaResponse> result = _mapper.Map<List<DocEntradaResponse>>(docEntradas);

            return result;
        }

        public GenericFilterResponse<DocEntradaResponse> GetByFilter(GenericFilterRequest request)
        {

            GenericFilterResponse<DocEntradaResponse> result = _mapper.Map<GenericFilterResponse<DocEntradaResponse>>(_docEntradaRepository.GetByFilter(request));

            return result;
        }
    }
}
