using System.Collections.Generic;

namespace crmProject
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
 
            if (customerId == 1)
            {
                customer.EmailAddress = "swilliams@greenenergy.com";
                customer.FirstName = "Susan";
                customer.LastName = "Williams";
            }
            return customer;
        }
 
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
 
        public bool Save()
        {
            return true;
        }
 
    }
}