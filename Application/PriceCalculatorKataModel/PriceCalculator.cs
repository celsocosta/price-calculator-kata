using PriceCalculatorKataModel.Models;
using System;

namespace PriceCalculatorKataModel
{
    public class PriceCalculator : IPriceCalculator
    {
        public PriceCalculator() {
            TaxRate = 0.2m;
        }

        public PriceCalculator(decimal taxRate) : base()
        {
            if (taxRate < 0)
                throw new ArgumentException("TaxRate can not be negative.");

            if (taxRate > 1)
                throw new ArgumentException("TaxRate can not be greater than 1.");

            TaxRate = taxRate;
        }

        public decimal TaxRate { get; }

        public PriceResult Calculate(Product product)
        {
            return new PriceResult(product.Title, product.UPC, product.Amount, TaxRate, product.Amount + product.Amount * TaxRate);
        }
    }
}
