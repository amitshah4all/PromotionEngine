using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Implement product service related methods
    /// </summary>
    public class PromotionService : IPromotionService
    {
        /// <summary>
        /// Gets the type of the price by.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void GetProductPrice(Product product)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetTotalPrice(List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
