using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineClient
{
    /// <summary>
    /// Manage product and price processing methods
    /// </summary>
    public class ProductContext
    {
        /// <summary>
        /// Processes the orders.
        /// </summary>
        public static void ProcessOrders()
        {
            PromotionService objPromotion;
            Product objProduct;
            List<Product> products;
            try
            {
                products = new List<Product>();
                Console.WriteLine("Enter number of Products (only numeric values allowed):");

                int noOfProducts = GetIntParsedValue(Console.ReadLine());
                string productType = string.Empty;
                for (int i = 1; i <= noOfProducts; i++)
                {
                    Console.WriteLine($"Order {i}: Enter the type of product:A, B, C or D");
                    productType = CheckValidProductNames(Console.ReadLine(), i);
                    objProduct = new Product(productType);
                    products.Add(objProduct);
                }

                objPromotion = new PromotionService();
                int totalPrice = objPromotion.GetTotalPrice(products);
                Console.WriteLine($"Total Price: { totalPrice}");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objPromotion = null;
                objProduct = null;
                products = null;
            }
        }

        /// <summary>
        /// Checks the parsed value.
        /// </summary>
        /// <param name="inputValue">The input value.</param>
        /// <param name="orderNumber">The order number.</param>
        /// <returns></returns>
        private static string CheckValidProductNames(string inputValue, int orderNumber)
        {
            string[] validValues = { "A", "B", "C", "D" };
            if (!validValues.Contains(inputValue.ToUpper()))
            {
                Console.WriteLine($"Order {orderNumber}: Invalid value entered: Please enter the type of product:A, B, C or D");
                return CheckValidProductNames(Console.ReadLine().ToString(), orderNumber);
            }
            else
                return inputValue;
        }

        /// <summary>
        /// Gets the int parsed value.
        /// </summary>
        /// <param name="inputValue">The input value.</param>
        /// <returns></returns>
        private static int GetIntParsedValue(string inputValue)
        {
            Int32.TryParse(inputValue, out int returnValue);
            if (returnValue > 0)
                return returnValue;
            else
            {
                Console.WriteLine("Enter Valid int value:");
                return GetIntParsedValue(Console.ReadLine().ToString());
            }
        }
    }
}