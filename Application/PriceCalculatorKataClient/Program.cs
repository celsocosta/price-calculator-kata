using PriceCalculatorKataModel;
using PriceCalculatorKataModel.Models;

namespace PriceCalculatorKataClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Product sample = new Product("The Little Prince", 12345, new MoneyCurrency(20.25m));

            PriceResult result1 = new PriceCalculator().Calculate(sample);//Implicit default tax rate 20%    
            PriceResult result2 = new PriceCalculator(0.2m).Calculate(sample); //Explicit default tax rate 20%
        }
    }
}
