namespace Calculater.Brokers;
public static class ReportR
{
    public static void ShowMenu()
    {
        Console.WriteLine("Calculator Application: ");

        Console.WriteLine("1. Basic and Advanced Calculater:");
        Console.WriteLine("2. Multiplication table:");
        Console.WriteLine("3. Exit:");

        Console.WriteLine("Choose option:");
    }

    public static void ExitFromProgram()
    {
        Console.WriteLine("Thank you for using our calculator.");

    }

    public static void DefaultCase()
    {
        Console.WriteLine("We have only 3 options, check and try again!");
    }
}
