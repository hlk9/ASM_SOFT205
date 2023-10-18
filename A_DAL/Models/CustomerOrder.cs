using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string OrderId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public double OrderValue { get; set; }
        public byte OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
