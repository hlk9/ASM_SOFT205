using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class OrderDetail
    {
        public string OrderDetailId { get; set; } = null!;
        public string OrderId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public int Amount { get; set; }

        public virtual CustomerOrder Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
