using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetListByTrabzon()
        {
            Context c = new Context();
            return c.Customers.Where(x => x.CustomerCity == "trabzon").ToList();
        }
    }
}
/*
 eksik entityleri
login
hata sayfaları
ninject
entity state
parametreye göre getirme (müşteri adına göre)
rolleme
 */