using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface IStaffAccountRepository
    {
        IEnumerable<StaffAccount> GetAllStaffAccount();
        List<StaffAccount> GetStaffAccountByName(string name);
        bool CreateStaffAccount(StaffAccount staffAccount);
        bool UpdateStaffAccount(StaffAccount staffAccount);
        bool DeleteStaffAccount(string acountID);    

    }
}
