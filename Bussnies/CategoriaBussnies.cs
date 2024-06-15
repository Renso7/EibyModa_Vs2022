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
    public class CategoriaBussnies : ICategoriaBussnies
    {
        /*INYECCION DE DEPENDENCIAS*/
        #region DECLARACION DE VARIABLES Y CONSTRUCTOR
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;


        public CategoriaBussnies(IMapper mapper)
        {
            _mapper = mapper;
            _categoriaRepository = new CategoriaRepository();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Declaracionde variables y constructor

        #region END CRUD METHODS
        public CategoriaResponse Create(CategoriaRequest entity)
        {
            // CON AUTOMAPPER
            Categoria categoria = _mapper.Map<Categoria>(entity);
            categoria = _categoriaRepository.Create(categoria);
            CategoriaResponse result = _mapper.Map<CategoriaResponse>(categoria);


            return result;
        }


        public int Delete(int id)
        {
            int cantidad = _categoriaRepository.Delete(id);

            return cantidad;
        }

        public int DeleteMultipleItems(List<CategoriaRequest> lista)
        {
            List<Categoria> categorias = _mapper.Map<List<Categoria>>(lista);
            int cantidad = _categoriaRepository.DeleteMultipleItems(categorias);

            return cantidad;
        }



        public List<CategoriaResponse> GetAll()
        {
            //CON AUTOMAPPER

            List<Categoria> categoria = _categoriaRepository.GetAll();
            List<CategoriaResponse> lstResponse = _mapper.Map<List<CategoriaResponse>>(categoria);

            return lstResponse;
        }

        public CategoriaResponse GetById(int id)
        {
            Categoria categoria = _categoriaRepository.GetById(id);
            CategoriaResponse result = _mapper.Map<CategoriaResponse>(categoria);
            //CARGO RESPONSE RESULTADO = _mapper.Map<AlmacenesResponse>(_almaceneesResponse)
            return result;
        }

        public List<CategoriaResponse> InsertMultiple(List<CategoriaRequest> lista)
        {
            List<Categoria> categorias = _mapper.Map<List<Categoria>>(lista);
            categorias = _categoriaRepository.InsertMultiple(categorias);
            List<CategoriaResponse> result = _mapper.Map<List<CategoriaResponse>>(categorias);

            return result;
        }

        public CategoriaResponse Update(CategoriaRequest entity)
        {
            Categoria categoria = _mapper.Map<Categoria>(entity);
            categoria = _categoriaRepository.Update(categoria);
            CategoriaResponse result = _mapper.Map<CategoriaResponse>(categoria);


            return result;
        }

        public List<CategoriaResponse> UpdateMultiple(List<CategoriaRequest> lista)
        {
            List<Categoria> categorias = _mapper.Map<List<Categoria>>(lista);
            categorias = _categoriaRepository.UpdateMultiple(categorias);
            List<CategoriaResponse> result = _mapper.Map<List<CategoriaResponse>>(categorias);

            return result;
        }


        public GenericFilterResponse<CategoriaResponse> GetByFilter(GenericFilterRequest request)
         {

             GenericFilterResponse<CategoriaResponse> result = _mapper.Map<GenericFilterResponse<CategoriaResponse>>(_categoriaRepository.GetByFilter(request));

             return result;
         }


        #endregion END CRUD METHODS
    }
}
