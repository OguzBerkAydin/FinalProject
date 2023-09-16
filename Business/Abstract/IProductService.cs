﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); 
        IDataResult<Product> Get(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetail();
        IResult Add(Product product);
        //IResult Update(Product product);
    }
}
