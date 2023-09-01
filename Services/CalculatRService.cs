using Calculater.Brokers;
using Calculater.Services.Interfaces;

namespace Calculater.Services;
public class CalculatRService : ICalculatRService, IAdvancedCalculatRService
{
    public decimal FirstValue { get; set; }
    public decimal SecondValue { get; set; }
    public string Operation { get; set; }
    public decimal Number { get; set; }

    public CalculatRService(decimal firstNumber, string operation, decimal secondNumber)
    {
        FirstValue = firstNumber;
        Operation = operation;
        SecondValue = secondNumber;
    }

    public CalculatRService(decimal firstNumber, string operation)
    {
        FirstValue = firstNumber;
        Operation = operation;
    }

    public CalculatRService(decimal firstUserValue) {}
    
    public void Calculate()
    {
        string template = $"{FirstValue} {Operation} {SecondValue} =";
        Console.WriteLine("There are calculation processed:");

        decimal result = CalculateValues(Operation, this.FirstValue, this.SecondValue);

        if (Operation.Equals("sqrt"))
            Console.WriteLine($"Root value of {this.FirstValue} = {result}");
        else
            Console.WriteLine($"{template} {result}");
    }

    public decimal CalculateValues(string operation, decimal firstNumber, decimal secondNumber)
    {
        return operation switch
        {
            "sqrt" => CalculateSquareRoot(number: this.Number),
            "+" => Sum(this.FirstValue, this.SecondValue),
            "-" => Substract(this.FirstValue, this.SecondValue),
            "*" => Multiply(this.FirstValue, this.SecondValue),
            "/" => Divide(this.FirstValue, this.SecondValue),
            "%" => CalculateRemainder(this.FirstValue, this.SecondValue),
            "pow" => CalculatePower(this.FirstValue, this.SecondValue),
            _ => 0
        };
    }

    public decimal Sum(params decimal[] numbers)
    {
        decimal total = 0;
        foreach (decimal number in numbers)
        {
            total += number;
        }
        return total;
    }

    public decimal Sum(decimal firstNumber, decimal secondNumber, decimal thridnumber)
    {
        return firstNumber + secondNumber + thridnumber;
    }

    public decimal Sum(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public decimal Substract(decimal firstNumber, decimal secondNumber)
    {
        return firstNumber - secondNumber;
    }

    public decimal Multiply(decimal firstNumber, decimal multiplier)
    {
        return firstNumber * multiplier;
    }

    public decimal Divide(decimal number, decimal divider)
    {
        return number / divider;
    }

    public decimal CalculateRemainder(decimal firstNumber, decimal divider)
    {
        return firstNumber % divider;
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

