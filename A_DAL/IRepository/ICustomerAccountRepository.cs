using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface ICustomerAccountRepository
    {
        IEnumerable<CustomerAccount> GetAllCustomerAccount();
        List<CustomerAccount> GetAllCustomerAccountByName(string name);
        bool CreateCustomerAccount(CustomerAccount customerAccount);
        bool UpdateCustomerAccount(CustomerAccount customerAccount);
        bool DeleteCustomerAccount(string customerAccountID);
    }
}
