using PriceCalculatorKataModel.Models;
using System.Globalization;

namespace PriceCalculatorKataModel
{
    public class PriceResult : IPriceResult
    {
        public PriceResult(string title, int upc, MoneyCurrency baseAmount, decimal taxRate, MoneyCurrency afterTax)
        {
            Title = title;
            Upc = upc;
            BaseAmount = baseAmount;
            TaxRate = taxRate;
            AfterTax = afterTax;
        }

        public string Title { get; }
        public int Upc { get; }
        public MoneyCurrency BaseAmount { get; }
        public decimal TaxRate { get; }
        public MoneyCurrency AfterTax { get; }

        public string Describe()
        {
            return $"Product price reported as {BaseAmount.Currency}{BaseAmount.Value.ToString("0.00", CultureInfo.InvariantCulture)} before tax and {AfterTax.Currency}{AfterTax.Value.ToString("0.00", CultureInfo.InvariantCulture)} after {(TaxRate * 100).ToString("0", CultureInfo.InvariantCulture)}% tax.";
        }

    }
}