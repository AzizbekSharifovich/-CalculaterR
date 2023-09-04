using Calculater.Services.Interfaces;

namespace Calculater.Services;
public class CalculatRService : ICalculatRService
{
    public decimal FirstNumber { get; set; }
    public decimal SecondNumber { get; set; }
    public string Operation { get; set; }
    public decimal Number { get; set; }

    public CalculatRService(decimal firstNumber, string operation, decimal secondNumber)
    {
        FirstNumber = firstNumber;
        Operation = operation;
        SecondNumber = secondNumber;
    }

    public CalculatRService(decimal firstNumber, string operation)
    {
        FirstNumber = firstNumber;
        Operation = operation;
    }
    
    public void Calculate()
    {
        string template = $"{this.FirstNumber} {Operation} {this.SecondNumber} =";

        Console.WriteLine("There are calculation process:");

        decimal result = CalculateValues(Operation, this.FirstNumber, this.SecondNumber);

        if (Operation.Equals("sqrt"))
            Console.WriteLine($"Square root value of {this.FirstNumber} = {result}");
        else
            Console.WriteLine($"{template} {result}");
    }

    public decimal CalculateValues(string operation, decimal firstNumber, decimal secondNumber)
    {
        return operation switch
        {
            "sqrt" => CalculateSquareRoot(firstNumber),
            "+" => Sum(this.FirstNumber, this.SecondNumber),
            "-" => Substract(this.FirstNumber, this.SecondNumber),
            "*" => Multiply(this.FirstNumber, this.SecondNumber),
            "/" => Divide(this.FirstNumber, this.SecondNumber),
            "%" => CalculateRemainder(this.FirstNumber, this.SecondNumber),
            "pow" => CalculatePower(this.FirstNumber, this.SecondNumber),
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

