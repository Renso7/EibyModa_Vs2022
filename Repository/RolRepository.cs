using DBEibyModaModel;
using IRepository;
using Microsoft.EntityFrameworkCore;
using RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RolRepository : CRUDRepository<Rol>, IRolRepository
    {
        public GenericFilterResponse<Rol> GetByFilter(GenericFilterRequest request)
        {
            var query = dbset.Where(x => x.Id == x.Id);
            request.Filtros.ForEach(j =>
            {
                if (!string.IsNullOrEmpty(j.Value))
                {
                    switch (j.Name)
                    {
                        case "id":
                            query = query.Where(x => x.Id == short.Parse(j.Value));
                            break;
                        case "codigo":
                            query = query.Where(x => x.Codigo.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "descripcion":
                            query = query.Where(x => x.Descripcion.ToLower().Contains(j.Value.ToLower()));
                            break;
                        case "idEstado":
                            query = query.Where(x => x.IdEstado == bool.Parse(j.Value));
                            break;
                    }
                }
            });

            GenericFilterResponse<Rol> res = new GenericFilterResponse<Rol>();

            res.TotalRegistros = query.Count();
            res.Lista = query
                //.Include(x => x.Status)
                .Skip((request.NumeroPagina - 1) * request.Cantidad).Take(request.Cantidad)
                .OrderBy(x => x.Descripcion)
                .ToList();

            return res;
        }
    }
}
