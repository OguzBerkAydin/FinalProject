using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categorDal.GetAll();
        }

        public Category GetByCategoryId(int categoryId)
        {
            return _categorDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
