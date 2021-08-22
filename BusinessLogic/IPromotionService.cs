using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IPromotionService
    {
        /// <summary>
        /// Gets the type of the price by.
        /// </summary>
        /// <param name="product">The product.</param>
        void GetProductPrice(Product product);

        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <param name="products">The products.</param>
        /// <returns></returns>
        int GetTotalPrice(List<Product> products);
    }
}
