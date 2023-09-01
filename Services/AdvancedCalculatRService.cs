using Calculater.Services.Interfaces;

namespace Calculater.Services;
public class AdvancedCalculatRService : IAdvancedCalculatRService
{
    public decimal FirstNumber { get; set; }
    public decimal SecondNumber { get; set; }
    public string Option { get; set; }

    public AdvancedCalculatRService(decimal firstNumber, string option, decimal secondNumber) 
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
        Option = option;
    }

    public decimal CalculateSquareRoot(decimal number)
    {
        return (decimal)Math.Sqrt((double)number);
    }

    public decimal CalculatePower(decimal number, decimal exponent)
    {
        return (decimal)Math.Pow((double)number, (double)exponent);
    }
}

