using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create instance of Product
            // Pass requested productId as param
            Product product = new Product(productId);

            // here: code that retriec=ves the defined product

            // Temporarily hard coded values to return
            // a poplauted productId
            if (productId == 2)
            {
                product.ProductName = "Longbottom Leaf";
                product.Description = "One of the finest pipeweed's in The Shire";
                product.CurrentPrice = 20.5M;

            }

            Object myObj = new Object();
            Console.WriteLine($"Object: {myObj.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        // <summary>
        // Saves the product data
        // </summary
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)       // if true
            {
                if (product.IsValid)        // if true
                {
                    if (product.IsNew)
                    {
                        // call Insert stored Procedure
                    }
                    else
                    {
                        // call Update stored Procedure
                    } // END OF if IsNew()

                } // END OF if isValid()
               
                else
                {
                    success = false;
                }
            }  //END OF if HasChanged()

            return success;
        }
    }
}
