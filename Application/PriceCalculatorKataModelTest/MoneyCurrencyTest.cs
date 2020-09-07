using PriceCalculatorKataModel.Models;
using Xunit;

namespace PriceCalculatorKataModelTest
{
    public class MoneyCurrencyTest
    {
        [Fact]
        public void CanCreateMoneyCurrency()
        {
            MoneyCurrency moneyCurrency= new MoneyCurrency(20.25m);

            Assert.Equal(20.25m, moneyCurrency.Value);
            Assert.Equal("$", moneyCurrency.Currency);
        }
    }
}
