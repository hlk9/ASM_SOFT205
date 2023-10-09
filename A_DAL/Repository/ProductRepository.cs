using A_DAL.IRepository;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        ASM_DAMContext _asmContext = new ASM_DAMContext();

        public ProductRepository()
        {
            
        }


        public bool CreateProduct(Product product)
        {
           try
            {
                _asmContext.Products.Add(product);
                _asmContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProduct(string productID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            try
            {
                return _asmContext.Products.ToList();


            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> GetAllProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
           try
            {
                Product prd = _asmContext.Products.Find(product.ProductId);
                prd.ProductName = product.ProductName;
                prd.Price = product.Price;          
                prd.ProductDescription = product.ProductDescription;
                prd.ProductImage = product.ProductImage;
                prd.ProductStatus = product.ProductStatus;
                _asmContext.Update(prd);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
