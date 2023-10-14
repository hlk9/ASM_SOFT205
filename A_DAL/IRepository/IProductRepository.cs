using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        List<Product> GetAllProductsByName(string name);
        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(string productID);
    }
}
