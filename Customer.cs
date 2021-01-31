/* =====================================================================================
 * Worksheet: |  PluralSight Tutorials: Class & OOP
 * Program:   |  ACME CMS
 * Author:    |  Leigh McGuinness - s00183063
 * Date:      |  22/01/21
 * _ _ _ _ _ _| _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
 * Purpose:   |  Program to represent a Customer Management System
 *            | 
 * _ _ _ _ _ _|_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
 * Mods:      |
 * =====================================================================================
 * Structure  :   Class:    | Customer        Product       Order         OrderItem     
 *            :   --------  | ----------      ------------  ----------    -------------
 *            :   Property: | firstName       ProductName   Customer      ProductId
 *            :             | lastName        Description   OrderDate     Quantity
 *            :             | homeAddress     CurrentPrice  ShipAddress   OrderItemId
 *            :             | workAddress                                 
 *            :   --------  | ----------      ------------  ----------    -------------
 *            :   Method:   | Validate()      Validate()    Validate()    Validate()
 *            :             | Retreice()      Retreice()    Retreice()    Retreice()
 *            :             | Save()          Save()        Save()        Save()
 * --------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        // constructors
        public Customer()       // default contructor: no params
        {

        }

        public Customer(int customerId)
        {
            customerId = CustomerId;
            AddressList = new List<Address>();
        }
        
        // properties
        public int CustomerId { get; private set; }  // any caller can get CustomerId, only this class can set
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public int CustomerType { get; set; }

        private string _lastName;

        public string FullName      // read-only as no set()
        {
            get
            {
                string fullName = LastName;  // if there is only a last name, fullNmae = lastName
                if (!string.IsNullOrWhiteSpace(FirstName))  // if there is only a first name.....
                {
                    if (!string.IsNullOrWhiteSpace(fullName)) //.... then the last name is initially null
                    {
                        fullName += ", ";   // append a comma and a space if there is both first and last name
                    }
                    fullName += FirstName;  // append the firstName to "lastName, "
                }
                return fullName;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }


        public static int InstanceCount { get; set; }   // static: belongs to the class, not any created instances

        public override string ToString() => FullName ; // reformatted from func body to lambda


        //**** Class methods ****//

        // <summary>
        // Validate the customer data
        // </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
            {                
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;            
        }
        // end method Validate()

        


    } // end class Customer
}
