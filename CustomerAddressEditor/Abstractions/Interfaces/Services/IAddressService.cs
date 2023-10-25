using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Services
{
    public interface IAddressService
    {

        List<Models.IAddress> GetAllAddresses();

        Models.IAddress GetCustomerAddress(ICustomer customer);



    }
}
