using Business.Abstract;
using Core.Utilities.Results;
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
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categorDal.GetAll());
        }

        public IDataResult<Category> Get(int categoryId)
        {
            return new SuccessDataResult<Category>(_categorDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
