using System;

namespace CargoWiseExperimenting
{
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice, NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
}