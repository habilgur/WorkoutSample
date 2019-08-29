using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecapProject1.Interfaces
{
    public interface IProduct 
    {
         int ProductId { get; set; }
         string ProductName { get; set; }
         int SupplierID { get; set; }
         int CategoryID { get; set; }
         string QuantityPerUnit { get; set; }
         decimal UnitPrice { get; set; }
         Int16 UnitsInStock { get; set; }
         Int16 UnitsOnOrder { get; set; }
         Int16 ReorderLevel { get; set; }
         bool Discontinued { get; set; }

 
    }
}
