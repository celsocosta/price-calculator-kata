using PriceCalculatorKataModel.Models;
using System;
using Xunit;

namespace PriceCalculatorKataModelTest
{
    public class ProductTest
    {
        [Fact]
        public void NullTitleValidation()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Product(null, 12345, new MoneyCurrency(20.25m)));
            Assert.Equal("Undefined Title.", ex.Message);
        }

        [Fact]
        public void EmptyTitleValidation()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Product("", 12345, new MoneyCurrency(20.25m)));
            Assert.Equal("Undefined Title.", ex.Message);
        }

        [Fact]
        public void NullAmountValidation()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Product("The Little Prince", 12345, null));
            Assert.Equal("Undefined MoneyCurrency.", ex.Message);
        }
           
        [Fact]
        public void CanCreateProduct()
        {
            Product product = new Product("The Little Prince", 12345, new MoneyCurrency(20.25m));

            Assert.Equal("The Little Prince", product.Title);
            Assert.Equal(12345, product.UPC);
            Assert.Equal(20.25m, product.Amount.Value);
            Assert.Equal("$", product.Amount.Currency);

        }
    }
}
