using RecapProject1.Entities;
using RecapProject1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapProject1.DAL
{
    public class ProductDal : IProductDal
    {
        public List<Product> GetAllList()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }

        }

        public List<Product> SearchByCategoryId(int CategoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.Where(p => p.CategoryID == CategoryId).ToList();


            }
        }

        public List<Product> SearchByText(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return String.IsNullOrEmpty(key) ? context.Products.ToList()
                                                 : context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();



            }
        }
    }
}
