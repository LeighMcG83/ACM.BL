/* =====================================================================================
*Structure  :   Class:    |  Address
 *          :   --------  |  ----------- 
 *          :   Property: |  StreetLine1
 *          :             |  StreetLine2
 *          :             |  City
 *          :             |  State/County
 *          :             |  Country
 *          :             |  AddressType
 *          :   --------  |  ------------
 *          :   Method:   |  Validate()
 *          :             |  
 * --------------------------------------------------------------------------------------------------*/



using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        // constructors
        public Address():this(1)
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }


        // properties
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State_County { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public int AddressType { get; set; }
        public int? AddressId { get; private set; }

     

        // Class Methods

        //// <summary>
        //// Validate address details
        //// </summary>
        //public override bool Validate()
        //{
        //    var isValid = true;

        //    if (string.IsNullOrWhiteSpace(Address)) { isValid = false; }

        //    return isValid;
        //}

        // <summary>
        // Validate address id
        // </summary>
        public bool Validate(int addressId)
        {
            var isValid = true;

            if (AddressId == null) { isValid = false; }

            return isValid;
        }


    }
}
