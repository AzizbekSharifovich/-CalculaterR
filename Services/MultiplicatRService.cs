using Calculater.Services.Interfaces;

namespace Calculater.Services;
public class MultiplicatRService : IMultiplicatRService
{
    public MultiplicatRService(){}

    public void ShowMultiplicationTable()
    {
        {
            Console.WriteLine("Here is the multiplication table for your reference.");
            for (int outerIteration = 2; outerIteration < 10; outerIteration++)
            {
                Console.WriteLine("===================");
                for (int iteration = 1; iteration <= 10; iteration++)
                {
                    Console.WriteLine($"{outerIteration} * {iteration} = {outerIteration * iteration}");
                }
            }
        }
    }
}

