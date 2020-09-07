using System;

namespace PriceCalculatorKataModel.Models
{
    public class Product
    {
        public Product(string title, int upc, MoneyCurrency amount)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Undefined Title.");

            Title = title;
            UPC = upc;
            Amount = amount ?? throw new ArgumentException("Undefined MoneyCurrency.");

        }

        public string Title { get; }

        public int UPC { get; }

        public MoneyCurrency Amount {get;}
    }
}
