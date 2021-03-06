using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Implement product service related methods
    /// </summary>
    public class PromotionService : IPromotionService
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetTotalPrice(List<Product> products)
        {
            try
            {
                //Declaration of local variables 
                int productCountA = 0, productPriceA = 50, productCountB = 0, productPriceB = 30,
                    productCountC = 0, productPriceC = 20, productCountD = 0, productPriceD = 15, productPriceCandD = 30;

                foreach (Product pr in products)
                {
                    switch (pr.Id.ToUpper())
                    {
                        case "A":
                            productCountA += 1;
                            break;
                        case "B":
                            productCountB += 1;
                            break;
                        case "C":
                            productCountC += 1;
                            break;
                        case "D":
                            productCountD += 1;
                            break;
                    }
                }

                int totalPriceA = (productCountA / 3) * 130 + (productCountA % 3 * productPriceA);
                int totalPriceB = (productCountB / 2) * 45 + (productCountB % 2 * productPriceB);

                int groupCAndD = ((productCountC + productCountD) / 2);
                int groupCandDPrice = groupCAndD * productPriceCandD;
                
                int totalPriceC = (productCountC - groupCAndD) * productPriceC;
                int totalPriceD = (productCountD - groupCAndD) * productPriceD;

                return totalPriceA + totalPriceB + totalPriceC + totalPriceD + groupCandDPrice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
