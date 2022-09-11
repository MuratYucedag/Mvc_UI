using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetList();
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        T GetByID(int id);
    }
}
