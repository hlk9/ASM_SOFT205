using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class staff
    {
        public staff()
        {
            ProductImports = new HashSet<ProductImport>();
            StaffAccounts = new HashSet<StaffAccount>();
        }

        public string StaffId { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public byte Sex { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? StaffAddress { get; set; }
        public string? Email { get; set; }
        public byte? StaffRole { get; set; }
        public virtual ICollection<ProductImport> ProductImports { get; set; }
        public virtual ICollection<StaffAccount> StaffAccounts { get; set; }
    }
}
