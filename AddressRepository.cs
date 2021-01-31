using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        // <summary>
        // Retrieve one address
        // </summary>
        public Address Retrieve(int addressId)
        {
            // create instance of address class
            // pass requested ID
            Address address = new Address(addressId);

            // code that will retrieve defined address

            // Temporarily hard-coded values to ensure 
            // return of populated address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State_County = "The Shire";
                address.Country = "Middle Earth";
                address.PostCode = "144";
            }
            return address;
        }

        // IEnumerabel is recommended to return sequence of data
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // code that wil retrieve a defined address
            // for a customer


            // Temporarily hard-coded values to ensure 
            // return a set of populated addresses for a customer
            // e.g. work address and home address
            var addressList = new List<Address>();
            Address address = new Address(1)        // passed a hard-coded 1 as param
        {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State_County = "The Shire",
                Country = "Middle Earth",
                PostCode = "144"
            };
            addressList.Add(address);


            address = new Address(2)        // passed a hard-coded 2 as param
            {
                AddressType = 2,
                StreetLine1 = "The Green Dragon",
                City = "Bywater",
                State_County = "The Shire",
                Country = "Middle Earth",
                PostCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }


        // <summary>
        // Saves the current address
        // </summary
        public bool Save(Address address)
        {
            // code to save current address
            return true;
        }
    }
}
