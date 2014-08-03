using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoWiseExperimenting
{

    public delegate decimal PriceChangedHandler(decimal oldPrice, decimal newPrice);
    public class SomeClass
    {
        private string _symbol;
        private decimal price;

        public SomeClass(string symbol)
        {
            this._symbol = symbol;
        }

        public event PriceChangedHandler PriceChanged;
        
        public double SomeWork(double i)
        {
            return Math.Pow(i, i);
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                if (PriceChanged != null)
                {
                    PriceChanged(price, value);
                }
                price = value;
            }
        }
    }
}
