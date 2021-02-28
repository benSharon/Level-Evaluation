using LevelEvaluation.Data;
using System;

namespace Q3_StoreApp
{
    class Program
    {
        /// <summary>
        /// This method allows a user named Mikes to add products to his cart
        /// The text after * should be displayed in the console
        /// The text surrounded by -- is an example of a user input
        /// You must complete the todos in the Customer, Cart and Store class first
        /// You must use the Store class
        /// </summary>
        static void Main(string[] args)
        {
            Customer customer = new Customer("Mikes");
            Store store = new Store();

            char choice = ' ';
            char checkout = 'c';

            // * Hello Mikes!
            Console.WriteLine();

            while (choice != checkout)
            {
                // TODO: Print the store products
                // * Here is the list of our products:
                // * 1 Apple 1.00
                // * 2 Juice 7.50
                // * 3 Bread 2.50
                // * 4 Cookies 3.75
                // * 5 Cereal 4.00
                // * 6 Milk 4.50

                Console.WriteLine("Hello Mikes!");
                Console.WriteLine("Here is the list of our products:");
                store.DisplayProducts();

                Console.WriteLine();

                // * Enter a number to add a product to your cart
                // * or c to proceed to checkout

                Console.Write("Enter a number to add a product to your cart or 'c' to proceed to checkout: ");
                string input = Console.ReadLine();


                // -- 4 --
                // TODO: Store the user's choice in the choice variable


                // -------------- SCENARIOS --------------
                // *** SCENARIO 1: user enters c ***
                // * Your cart contains the following items:
                // * Milk, Cereal, Cookies
                // * Your total is $xx.xx
                // * Thank you for shopping at StoreApp

                // *** SCENARIO 2: Item is not in cart ***
                // * You have successfully added "Cookies"

                // *** SCENARIO 3: Item is in cart ***
                // * This product is already in your cart
                // -------------- SCENARIOS --------------


                // TODO: If SCENARIO 1: Print the customer's cart info
                if (input == checkout.ToString())
                {
                    Console.WriteLine("Your cart contains the following items:");
                    Console.WriteLine(customer.Cart.ListProducts());
                    Console.WriteLine($"Your total is ${customer.Cart.Total}");
                    Console.WriteLine("=============================================");
                }

                else
                {
                    // TODO: If SCENARIO 2: Add the product to the user's cart and indicate it to the user
                    int index = int.Parse(input) - 1;
                    if (!store.IsProductInCart(index, customer.Cart))
                    {
                        var product = store.GetProductAtIndex(index);
                        Console.WriteLine("Item is not in cart.");
                        customer.Cart.AddProduct(product);
                        Console.WriteLine($"You have successfully added '{product.Name}'");
                        Console.WriteLine("=============================================");
                    }

                    // TODO: If SCENARIO 3: Tell the user that the product is already in their cart
                    else if (store.IsProductInCart(index, customer.Cart))
                    {
                        Console.WriteLine("The product is already in your cart.");
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
