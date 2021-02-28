using System;
using System.Collections.Generic;

namespace LevelEvaluation.Data
{
    public class Store
    {
        private List<Product> Products { get; }

        /// <summary>
        /// This method prints all the products available.
        /// Ex.: Products = {
        ///   new Product(Cookies, 2.50),
        ///   new Product(Bread, 5.00),
        ///   new Product(Milk, 3.75)
        /// }
        /// Considering the list above, we should obtain:
        /// 1 Cookies 2.50
        /// 2 Bread 5.00
        /// 3 Milk 3.75
        /// </summary>
        public void DisplayProducts()
        {
            for (int i = 0; i < Products.Count; i++)
                Console.WriteLine($"{i + 1} {Products[i].Name} {Products[i].Price}");
        }

        /// <summary>
        /// This method retrieves the product at the index specified.
        /// It then checks if the cart contains the product.
        /// </summary>
        public bool IsProductInCart(int index, Cart cart)
        {
            var storeItem = GetProductAtIndex(index);
            if (cart.Products.Contains(storeItem))
                return true;
            else return false;
        }


        // ----------------------------------------------
        // -------- DO NOT MODIFY THE CODE BELOW --------
        // ----------------------------------------------

        /// <summary>
        /// Returns the product at the index specified
        /// </summary>
        public Product GetProductAtIndex(int index)
        {
            return Products[index];
        }

        #region SETUP
        public Store()
        {
            this.Products = new List<Product>();
            InitializeStore();
        }

        /*
         * This method initializes the store with some products
         */
        private void InitializeStore()
        {
            string[] names = { "Apple", "Juice", "Bread", "Cookies", "Cereal", "Milk" };
            double[] prices = { 1.00, 7.50, 2.50, 3.75, 4.00, 4.50 };

            for (int i = 0; i < names.Length; i++)
                Products.Add(new Product(names[i], prices[i]));
        }
        #endregion
    }
}
