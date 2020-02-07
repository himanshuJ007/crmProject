using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using crmProject;
 
namespace crmProject.Test
{
    //[TestClass]
    public class CustomerRepositoryTest
    {
        //[TestMethod]
        public void RetrieveExisting()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "swilliams@greenenergy.com",
                FirstName = "Susan",
                LastName = "Williams"
            };
 
            var actual = customerRepository.Retrieve(1);
 
          //  Assert.AreEqual(expected.CustomerId, actual.CustomerId);
           // Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
          // Assert.AreEqual(expected.FirstName, actual.FirstName);
           // Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}