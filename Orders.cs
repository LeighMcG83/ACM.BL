/* =====================================================================================
*Structure  :   Class:    | Customer     Product         Order         OrderItem     
 *          :   --------  | -----------  -----------     -----------   ------------
 *          :   Property: | firstName    ProductName     Customer      Product
 *          :             | lastName     Description     OrderDate     Quantity
 *          :             | homeAddress  CurrentPrice    ShipAddress
 *          :             | workAddress
 *          :   --------  | -----------  ------------    -----------   -----------
 *          :   Method:   | Validate()   Validate()      Validate()    Validate()
 *          :             | Retreice()   Retreice()      Retreice()    Retreice()
 *          :             | Save()       Save()          Save()        Save()
 * --------------------------------------------------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Orders : EntityBase
    {

        // constructors
        public Orders(): this(0)
        {

        }

        public Orders(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }



        // properties        
        public int OrderId { get; private set; }
        
        /* DateTimeOffset allows comparison of DateTime's in 
         * different timezones. ? means nullable type */
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public override string ToString() => 
            $"{OrderDate.Value.Date} ({OrderId})"; // reformatted from func body to lambda
        
         
        // Class Methods

        // <summary>
        // Validate the product name
        // </summary>
        public override bool Validate()
            {
                bool isValid = true;

                if (OrderDate == null)
                {
                    isValid = false;
                }
                return isValid;
            }
            // end of ValidateProduct()
          
    }
}
