using DBEibyModaModel;
using IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CRUDRepository<TEntity> where TEntity : class//, ICRUDRepository<TEntity>
    {
        #region DECLARACION DE VARIABLES Y COSNTRUCTOR
        internal _dbEIBYMODAContext db;
        //DBSET EN ALGUN MOMENTO SERA CARGO, PERSONA , COLABORADOR, EMPRERSA AREA , ETC
        internal DbSet<TEntity> dbset;

        public CRUDRepository()
        {
            db = new _dbEIBYMODAContext();
            dbset = db.Set<TEntity>();
        }
        #endregion DECLARACION DE VARIABLES

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        
        public TEntity Create(TEntity entity)
        {
            dbset.Add(entity);
            db.SaveChanges();
            return entity;
        }


        //OBJETO PUEDE SER UN ENTERO , SHOR , STRING (TIPO DE DATOS PRIMARIO)
        public int Delete(object id)
        {
            TEntity entityToDelete = dbset.Find(id);
            dbset.Remove(entityToDelete);
            return db.SaveChanges();
        }

        public int DeleteMultipleItems(List<TEntity> lista)
        {
            throw new NotImplementedException();
        }

        

        public List<TEntity> GetAll()
        {
            IQueryable<TEntity> query = dbset;
            return query.ToList();
        }

        public TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        public List<TEntity> InsertMultiple(List<TEntity> lista)
        {
            dbset.AddRange(lista);
            db.SaveChanges();
            return lista;
        }

        public TEntity Update(TEntity entity)
        {
            dbset.Update(entity);
            db.SaveChanges();
            return entity;
        }

        public List<TEntity> UpdateMultiple(List<TEntity> lista)
        {
            dbset.UpdateRange(lista);
            db.SaveChanges();
            return lista;
        }
    }
}
