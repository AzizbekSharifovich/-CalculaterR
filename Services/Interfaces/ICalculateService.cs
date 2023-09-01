namespace Calculater.Services.Interfaces;

public interface ICalculatRService
{
    void Calculate();

    decimal Sum(decimal firstNumber, decimal secondNumber);

    decimal Substract(decimal firstNumber, decimal secondNumber);

    decimal Multiply(decimal firstNumber, decimal multiplier);

    decimal Divide(decimal number, decimal divider);

    decimal CalculateRemainder(decimal firstNumber, decimal divider);

    decimal Sum(decimal firstNumber, decimal secondNumber, decimal thridnumber);

    decimal Sum(params decimal[] numbers);
}
