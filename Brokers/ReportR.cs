namespace Calculater.Brokers;
public static class ReportR
{
    public static void ShowMenu()
    {
        Console.WriteLine("Universal Calculator Application");

        Console.WriteLine("\n1. Basic Calculater:");
        Console.WriteLine("2. Advanced Calculater:");
        Console.WriteLine("3. Multiplication table:");
        Console.WriteLine("4. Exit:");

        Console.WriteLine("\nChoose option:");
    }

    public static void ExitFromProgram()
    {
        Console.WriteLine("Thank you for using our calculator.");

    }

    public static void DefaultCase()
    {
        Console.WriteLine("We have only 4 options, check and try again!!!");
    }
}
