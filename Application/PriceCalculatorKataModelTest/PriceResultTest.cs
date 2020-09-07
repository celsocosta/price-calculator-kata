using PriceCalculatorKataModel;
using PriceCalculatorKataModel.Models;
using Xunit;

namespace PriceCalculatorKataModelTest
{
    public class PriceResultTest
    {
        [Theory]
        [InlineData(0, 0.2, 0, "Product price reported as $0.00 before tax and $0.00 after 20% tax.")]
        [InlineData(20.25, 0.20, 24.30, "Product price reported as $20.25 before tax and $24.30 after 20% tax.")]
        [InlineData(20.25, 0.21, 24.50, "Product price reported as $20.25 before tax and $24.50 after 21% tax.")]
        public void DescribeIsCorrect(decimal baseAmount, decimal taxRate, decimal afterTax, string expectedDescription)
        {
            string filename = "The Little Prince";
            int upc = 12345;
            PriceResult priceResult= new PriceResult(filename, upc, new MoneyCurrency(baseAmount), taxRate, new MoneyCurrency(afterTax));

            Assert.Equal(expectedDescription, priceResult.Describe());
        }
    }
}
