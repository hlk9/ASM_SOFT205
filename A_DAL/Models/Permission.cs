using System;
using System.Collections.Generic;

namespace A_DAL.Models
{
    public partial class Permission
    {
        public byte IdPermission { get; set; }
        public string PermissionName { get; set; } = null!;
    }
}
