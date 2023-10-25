using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.MockedRepositories
{
    public class CustomerMockedRepository : Abstractions.Interfaces.Repositories.ICustomerRepository
    {


        private readonly List<Abstractions.Interfaces.Models.ICustomer> _cutomers;
        public CustomerMockedRepository() 
        
        {
            _cutomers = new List<ICustomer>();

            _cutomers.Add(new Models.Customer() { FirstName = "Linda1", LastName = "Agnete1", Email = "123.ucl@ucl1.dk", PhoneNumber = "20304051" });
            _cutomers.Add(new Models.Customer() { FirstName = "Linda2", LastName = "Agnete2", Email = "456.ucl@ucl2.dk", PhoneNumber = "20304052" });
            _cutomers.Add(new Models.Customer() { FirstName = "Linda3", LastName = "Agnete3", Email = "789.ucl@ucl3.dk", PhoneNumber = "20304053" });
            _cutomers.Add(new Models.Customer() { FirstName = "Linda4", LastName = "Agnete4", Email = "101.ucl@ucl4.dk", PhoneNumber = "20304054" });
            _cutomers.Add(new Models.Customer() { FirstName = "Linda5", LastName = "Agnete5", Email = "121.ucl@ucl5.dk", PhoneNumber = "20304055" });


        }

        public ICustomer CreateCustomer(string firstName, string lastName, string phoneNumber, string email)
        {

            throw new NotImplementedException();

        }

        public bool DeleteCustomer(int id)
        {
           
            var customerToDelete = _cutomers.FirstOrDefault(x => x.Id == id);
            if (customerToDelete != null) 
            { 
            
                _cutomers.Remove(customerToDelete);
                return true;
            }

            return false;
        }

        public List<ICustomer> GetAllCostumers()
        {
            return _cutomers;
        }

        public ICustomer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(int Id, string firstName, string lastName, string phoneNumber, string email)
        {
            throw new NotImplementedException();
        }
    }
}
