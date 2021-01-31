/* =====================================================================================
*Structure  :   Class:    | Customer     Product         Order         OrderItem     
 *          :   --------  | -----------  -----------     -----------   ------------
 *          :   Property: | firstName    ProductName     Customer      ProductId
 *          :             | lastName     Description     OrderDate     Quantity
 *          :             | homeAddress  CurrentPrice    ShipAddress   PurchasePrice
 *          :             | workAddress                                OrderItemId
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
    public class OrderItem
    {
        // constructors
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        // properties
        public int OrderItemId { get; private set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        // Class Methods

        // <summary>
        // Validate the order
        // </summary>
        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) { isValid = false; }
            if (ProductId <= 0) { isValid = false; }
            if (PurchasePrice == null) { isValid = false; };

            return isValid;
        }
        // end of ValidateProduct()



        // <summary>
        // Retrieve one order item
        // </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // code to search list for productName

            return new OrderItem();
        }
        // end of RetrieveOrders()




        // <summary>
        // Retrieve all the orders
        // </summary
        public List<OrderItem> RetrieveOrders()
        {
            // Code that retreives all customers

            return new List<OrderItem>();
        }
        // end RetrieveOrders()


        // <summary>
        // Save the product name
        // </summary>
        public bool Save()
        {
            // code that saves the defined customer

            return true;
        }
        // end Save()

    }
}
