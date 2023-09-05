using Calculater.Brokers;
using Calculater.Services;
using Calculater.Services.Interfaces;

namespace Calculater;
public class Program
{
    public static void Main(string[] args)
    {
        int firstOption = 0;
        do
        {
            ReportR.ShowMenu();
            firstOption = ValueManipulatR.ConvertInputOption();

            switch (firstOption)
            {
                case 1:
                    decimal firstNumber = ValueManipulatR.GetInputByMessageToNumbers("Enter first number: = ");
                    string operation = ValueManipulatR.GetValidOperation("Operation: [+, -, *, /, %, sqrt, pow]: ");

                    if(operation.Equals("sqrt"))
                    {
                        ICalculatRService calculatRService = new CalculatRService(firstNumber, operation);
                        calculatRService.Calculate(); 
                        break;
                    }
                    else
                    {
                        decimal secondNumber = ValueManipulatR.GetInputByMessageToNumbers("Enter second number: = ");
                        ICalculatRService calculatRService = new CalculatRService(
                            firstNumber, operation, secondNumber);
                        calculatRService.Calculate();
                        break;
                    }
                case 2:
                     Console.WriteLine("Multiplication Table Generator");
                   
                     IMultiplicationTableService table = new MultiplicatRService();
                    table.ShowMultiplicationTable(); break;
                case 3:
                    ReportR.ExitFromProgram();break;
                default:
                    ReportR.DefaultCase(); break;

            }
        } while (firstOption != 3);
    }   
}