using System;

namespace CargoWiseExperimenting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pricer = new Stock("AUX");
            pricer.PriceChanged += pricer_PriceChanged;
            pricer.Price = 10;
            pricer.Price = 20;
            pricer.Price = 30;
            pricer.Price = 30;
            pricer.Price = 40;
            Console.Read();
        }

        private static void pricer_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            Console.WriteLine(String.Format("Old : {0}, New : {1}. Stock: {2}", e.LastPrice, e.NewPrice, (sender as Stock).Symbol));
        }
    }
}