using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IPromotionService
    {
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        int GetTotalPrice(List<Product> products);
    }
}
