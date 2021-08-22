using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PromotionEnginTest
{
    [TestClass]
    public class UnitTest1
    {
        List<Product> productList;
        PromotionService objPromotionService;

        /// <summary>
        /// Tests the initialize.
        /// </summary>
        [TestInitialize]
        public void testInit()
        {
            productList = new List<Product>();
            objPromotionService = new PromotionService();
        }

        /// <summary>
        /// Tests the cleanup.
        /// </summary>
        [TestCleanup]
        public void testCleanup()
        {
            productList = null;
            objPromotionService = null;
        }

        [TestMethod]
        public void Scenario1()
        {

            //Scenario A
            //1 * A 50
            //1 * B 30
            //1 * C 20
            //Total 100

            productList = new List<Product>() { new Product("A"), new Product("B"), new Product("C") };
            
        }
    }
}
