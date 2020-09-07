using PriceCalculatorKataModel;
using PriceCalculatorKataModel.Models;
using System;
using Xunit;

namespace PriceCalculatorKataModelTest
{
    public class PriceCalculatorTest
    {
        private readonly Product product = new Product("The Little Prince", 12345, new MoneyCurrency(20.25m));
        
        [Fact]
        public void HasDefaultTaxRateWithBaseConstructor()
        {
            PriceCalculator priceCalculator = new PriceCalculator();

            Assert.Equal(0.2m, priceCalculator.TaxRate);
        }

        [Theory]
        [InlineData(0.2)]
        [InlineData(0.3)]
        public void HasTaxRateSetWithConstructor(decimal expectedTaxRate)
        {
            PriceCalculator priceCalculator = new PriceCalculator(expectedTaxRate);

            Assert.Equal(expectedTaxRate, priceCalculator.TaxRate);
        }

        [Theory]
        [InlineData(-1.0, "TaxRate can not be negative.")]
        [InlineData(1.1, "TaxRate can not be greater than 1.")]
        public void AssertThrowException_TaxRate(decimal taxRate, string expectedMessage)
        {
            var ex = Assert.Throws<ArgumentException>(() => new PriceCalculator(taxRate));
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Theory]
        [InlineData(0.2)]
        [InlineData(0.21)]
        public void DescribeIsCorrect(decimal taxRate)
        {
            PriceCalculator priceCalculator = new PriceCalculator(taxRate);

            PriceResult priceResult = priceCalculator.Calculate(product);

            Assert.Equal(product.Title, priceResult.Title);
            Assert.Equal(product.UPC, priceResult.Upc);
            Assert.Equal(product.Amount, priceResult.BaseAmount);
            Assert.Equal(taxRate, priceResult.TaxRate);
            Assert.Equal(product.Amount + product.Amount*taxRate, priceResult.AfterTax);

        }
    }
}
