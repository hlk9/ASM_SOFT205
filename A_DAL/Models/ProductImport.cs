using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class ProductImport
    {
        public int ImportId { get; set; }
        public string? StaffId { get; set; }
        public string ProductId { get; set; } = null!;
        public DateTime? ImportDate { get; set; }
        public int ImportQty { get; set; }
        public decimal ImportPrice { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual staff? Staff { get; set; }
    }
}
