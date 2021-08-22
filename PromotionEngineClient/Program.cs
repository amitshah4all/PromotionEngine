﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineClient
{
    /// <summary>
    /// Console application class to get product prices using promotion offers.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ProcessOrders();
        }

        private static void ProcessOrders()
        {
            PromotionService objPromotion;
            Product objProduct;
            List<Product> products;
            try
            {
                products = new List<Product>();
                Console.WriteLine("Enter number of Products (only numeric values allowed):");

                int noOfProducts = GetIntParsedValue(Console.ReadLine());
                string type = string.Empty;
                for (int i = 1; i <= noOfProducts; i++)
                {
                    Console.WriteLine($"Order {i}: Enter the type of product:A, B, C or D");
                    type = Console.ReadLine();
                    objProduct = new Product(type);
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
        /// Gets the int parsed value.
        /// </summary>
        /// <param name="inputValue">The input value.</param>
        /// <returns></returns>
        private static int GetIntParsedValue(string inputValue)
        {
            Int32.TryParse(inputValue, out int returnValue);
            if (returnValue != 0)
                return returnValue;
            else
            {
                Console.WriteLine("Enter Valid int value:");
                return GetIntParsedValue(Console.ReadLine().ToString());
            }
        }
    }
}
