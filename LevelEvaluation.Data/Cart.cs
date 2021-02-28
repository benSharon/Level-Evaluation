using System;
using System.Collections.Generic;

namespace LevelEvaluation.Data
{
    /// <summary>
    /// This cart class represents an object that
    /// holds the products that a user is likely
    /// to purchase. It has a field that contains
    /// the total of the transaction as well as the
    /// number of products in the cart
    /// </summary>
    public class Cart
    {
        public List<Product> Products { get; set; }
        public double Total { get; set; }

        public Cart() => Products = new List<Product>();

        /// <summary>
        /// This method adds a product to the list
        /// and recalculates the total amount.
        /// </summary>
        public void AddProduct(Product product)
        {
            Products.Add(product);
            Total += product.Price;
        }

        /// <summary>
        /// This method returns a string with all the products in the cart.
        /// Ex.: Products = {
        ///   new Product(Cookies, 2.50),
        ///   new Product(Bread, 5.00),
        ///   new Product(Milk, 3.75)
        /// }
        /// Output: Cookies, Bread, Milk
        /// </summary>

        public string ListProducts()
        {
            var productsList = string.Empty;
            foreach (var i in Products)
                productsList += i.Name + " ";
            return productsList;
        }
    }
}
