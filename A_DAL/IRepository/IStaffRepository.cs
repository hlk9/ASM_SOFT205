using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface IStaffRepository
    {
        IEnumerable<staff> GetAllStaff();
        List<staff> GetStaffByName(string name);
        bool CreateStaff(staff staff);
        bool DeleteStaff(string staffId);
        bool UpdateStaff(staff staff);
        staff GetOne(string staffId);
    }
}
