using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CustomerService : Abstractions.Interfaces.Services.ICustomerService
    {
        private readonly Abstractions.Interfaces.Repositories.ICustomerRepository _customerRepository;
        public CustomerService(Abstractions.Interfaces.Repositories.ICustomerRepository customerRepository) 
        { 
            _customerRepository = customerRepository;
        }

        public ICustomer CreateCustomer(string firstName, string lastName, string phoneNumber, string email)
        {
            return _customerRepository.CreateCustomer(firstName, lastName, phoneNumber, email);
        }

        public bool DeleteCustomer(int id)
        {
           return _customerRepository.DeleteCustomer(id);
        }

        public List<ICustomer> GetAllCostumers()
        {
            return _customerRepository.GetAllCostumers();
        }

        public ICustomer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public bool UpdateCustomer(int Id, string firstName, string lastName, string phoneNumber, string email)
        {
            return _customerRepository.UpdateCustomer(Id, firstName, lastName, phoneNumber, email);
        }
    }
}
