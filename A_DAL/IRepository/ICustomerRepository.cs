using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepository
{
    internal interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer();
        List<Customer> GetAllCustomerByName(string name);
        bool CreateCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(string customerID);
    }
}
