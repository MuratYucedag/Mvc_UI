using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TChangeToStatusTrue(int id)
        {
            _categoryDal.ChangetoStatusTrue(id);
        }

        public void TDelete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public Category TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category item)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
