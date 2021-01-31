/* =====================================================================================
*Structure  :   Class:    | Customer     Product         Order         OrderItem     
 *          :   --------  | -----------  -----------     -----------   ------------
 *          :   Property: | firstName    ProductName     Customer      ProductId
 *          :             | lastName     Description     OrderDate     Quantity
 *          :             | homeAddress  CurrentPrice    ShipAddress   OrderItemId
 *          :             | workAddress                                PurchasePrice
 *          :   --------  | -----------  ------------    -----------   -----------
 *          :   Method:   | Validate()   Validate()      Validate()    Validate()
 *          :             | Retreive()   Retreive()      Retreive()    Retreice()
 *          :             | Save()       Save()          Save()        Save()
 * --------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{

    public class Product : EntityBase
    {
        // constructors
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        
        // properties
        public int ProductId { get; set; }
       
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = ProductName;
            }
        }

        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }      // ?: allow check if price is null (not set) rather than zero
        
        

        // override the the ToString() base class method 
        // to custoise returned string
        public override string ToString() => ProductName; // reformatted from func body to lambda

        // Methods

        // <summary>
        // Validate the product name
        // </summary>
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                { isValid = false; }
            if(CurrentPrice == null)
                { isValid = false; }

            return isValid;
        }
        // end of ValidateProduct()

       
    }
}
