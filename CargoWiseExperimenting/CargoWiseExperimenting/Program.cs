namespace CargoWiseExperimenting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pricer = new SomeClass("AUX");
            pricer.PriceChanged += PricerOnPriceChanged;
            pricer.Price = 10;
        }

        private static decimal PricerOnPriceChanged(decimal oldPrice, decimal newPrice)
        {
            return oldPrice - newPrice;
        }
    }
}