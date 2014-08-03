using System;

namespace CargoWiseExperimenting
{
    public class Stock
    {
        private decimal _price;
        private string _symbol;

        public Stock(string symbol)
        {
            this._symbol = symbol;
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value) return;
                OnPriceChanged(new PriceChangedEventArgs(_price, value));
                _price = value;
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            if (PriceChanged != null) PriceChanged(this, e);
        }
    }
}