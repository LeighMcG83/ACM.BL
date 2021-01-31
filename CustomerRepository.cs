using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // constructors

        // Ctor creates a Collaborative relationship between 
        // Customer and Address Repositories
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        // properties
        private AddressRepository addressRepository { get; set; }


        // <summary>
        // Retreive the customer data
        // </summary
        public Customer Retreive(int customerId)
        {
            // Create instance of Customer
            // Pass required customerId
            Customer customer = new Customer(customerId);

            // Code for retrieval here

            // Temporarily hard coded value to return
            // a populated customerId
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.sh";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId)
                    .ToList();
            }

            return customer;
        }


        // <summary>
        // Retrieve all the customers
        // </summary
        public List<Customer> Retrieve()
        {
            // Code that retreives all customers

            return new List<Customer>();
        }

        // <summary>
        // Saves the customer data
        // </summary
        public bool Save()
        {
            // coed to save current customer

            return true;
        }
    }
}
