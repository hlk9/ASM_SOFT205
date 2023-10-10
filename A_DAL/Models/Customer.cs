using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAccounts = new HashSet<CustomerAccount>();
            CustomerOrders = new HashSet<CustomerOrder>();
        }

        public string CustomerId { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumer { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? CustomerAddress { get; set; }
        public byte? Sex { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<CustomerAccount> CustomerAccounts { get; set; }
        public virtual ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
