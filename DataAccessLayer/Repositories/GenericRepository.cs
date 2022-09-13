using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T item)
        {
            _object.Remove(item);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T item)
        {
            _object.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            c.SaveChanges();
        }
    }
}
