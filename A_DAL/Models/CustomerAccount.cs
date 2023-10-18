using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class CustomerAccount
    {
        public string AccountId { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
        public string? UserName { get; set; }
        public string? UPassword { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
