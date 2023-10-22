using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductImports = new HashSet<ProductImport>();
        }

        public string ProductId { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public double Price { get; set; }
        public string? ProductImage { get; set; }
        public int ProductQty { get; set; }
        public int? ProductRemaining { get; set; }
        public int? ProductSold { get; set; }
        public byte? ProductStatus { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImport> ProductImports { get; set; }
    }
}
