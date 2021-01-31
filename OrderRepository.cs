using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Orders Retrieve(int orderId)
        {
            // Create instance of Orders
            // Pass requested orderId as param
            Orders orders = new Orders(orderId);

            // here: code that retrieves the defined order

            // Temporarily hard coded values to return
            // a poplauted orderId
            if (orderId == 10)
            {
                // use current year in hardcoded data
                orders.OrderDate = new DateTimeOffset(
                    DateTime.Now.Year, 4, 14, 10, 0, 0,   // current year, month, day, hour, minute, second
                    new TimeSpan(7, 0, 0));                 // span of time since (hour, minute, sec.)
            }

            return orders;
        }

        // <summary>
        // Saves the product data
        // </summary
        public bool Save()
        {
            // code that saves the defined customer

            return true;
        }
    }
}
