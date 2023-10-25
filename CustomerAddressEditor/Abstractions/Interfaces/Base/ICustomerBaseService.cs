using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Base
{
    public interface ICustomerBaseService
    {

        List<Models.ICustomer> GetAllCostumers();

        Models.ICustomer GetCustomer(int id);

        Models.ICustomer CreateCustomer(string firstName, string lastName, string phoneNumber, string email);

        bool UpdateCustomer(int Id, string firstName, string lastName, string phoneNumber, string email);

        bool DeleteCustomer(int id);

    }
}
