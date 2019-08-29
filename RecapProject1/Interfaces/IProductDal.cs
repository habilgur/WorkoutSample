using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapProject1.Interfaces
{
    public interface IProductDal
    {
        List<Product> GetAllList();

        List<Product> SearchByText(string key);

        List<Product> SearchByCategoryId( int CategoryId);
    }
}
