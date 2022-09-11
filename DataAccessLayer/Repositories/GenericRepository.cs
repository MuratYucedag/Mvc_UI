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
        Context context = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

        public void Delete(T item)
        {
            _object.Remove(item);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
