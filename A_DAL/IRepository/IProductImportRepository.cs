using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface IProductImportRepository
    {
        IEnumerable<ProductImport> GetAllProductImport();
        List<ProductImport> GetAllProductImportByName();
        bool CreatingProductImport(ProductImport productImport);
        bool UpdateProductImport(ProductImport productImport);
        bool DeleteProductImport(string importID);
        ProductImport GetOne(string importID);

    }
}
