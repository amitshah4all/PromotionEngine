namespace PromotionEngineClient
{
    /// <summary>
    /// Console application class to get product prices using promotion offers.
    /// </summary>
    class Program : ProductContext
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            ProcessOrders();
        }
    }
}
