using PriceCalculatorKataModel.Models;
namespace PriceCalculatorKataModel
{
    public interface IPriceCalculator
    {
        PriceResult Calculate(Product product);
    }
}
