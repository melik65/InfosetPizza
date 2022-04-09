using Infoset.DataAccessLayer.Abstarct;
using Infoset.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Infoset.DataAccessLayer.EntityFramework
{
    public class EfGenericRepository<T> : IRepositoryDal<T> where T : class
    {
        protected DbSet<T> table;
        protected Context db;
        public EfGenericRepository()
        {
            db = new Context();
            table = db.Set<T>();
        }
        public void AddRange(List<T> items)
        {
            table.AddRangeAsync(items);
            db.SaveChangesAsync();
        }

        public void Delete(T p)
        {
            table.Remove(p);
            db.SaveChanges();
        }

        public void DeleteRange(List<T> items)
        {
            table.RemoveRange(items);
            db.SaveChanges();
        }

        public T Get(int id)
        {
            return  table.Find(id);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return table.Where(filter).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return table.Where(filter).AsQueryable();
        }

        public void Insert(T p)
        {
            table.Add(p);
            db.SaveChanges();
        }

        public void Update(T p)
        {
            table.Update(p);
            db.SaveChanges();
        }
    }
}
