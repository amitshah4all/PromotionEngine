using System.Collections.Generic;

namespace BusinessLogic
{
    /// <summary>
    /// Manage Product related methods.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Product(string id)
        {
            this.Id = id.ToUpper();

            Dictionary<string, decimal> productPriceList = new Dictionary<string, decimal>();
            productPriceList.Add("A", 50m);
            productPriceList.Add("B", 30m);
            productPriceList.Add("C", 20m);
            productPriceList.Add("D", 15m);

            if (productPriceList.ContainsKey(this.Id))
            {
                productPriceList.TryGetValue(this.Id, out decimal resultValue);
                this.Price = resultValue;
            }
        }
    }
}
