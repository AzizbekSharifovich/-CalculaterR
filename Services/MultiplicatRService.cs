using Calculater.Services.Interfaces;

namespace Calculater.Services;
public class MultiplicatRService : IMultiplicationTableService
{
    public decimal OuterIteration { get; set; }
    public decimal Iteration { get; set; }

    public MultiplicatRService(decimal outerIteration, decimal iteration)
    {
        OuterIteration = outerIteration;
        Iteration = iteration;
    }

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

