using Microsoft.Ajax.Utilities;
using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class , new()
    {
        DbMvcCvEntities db = new DbMvcCvEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public T Get(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
        public void Update(T entity)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}