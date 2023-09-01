namespace Calculater.Brokers;
public class ValueManipulatR
{
    public static int ConvertInputOption()
    {

        int firstOption = 0;
        try
        {
            firstOption = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("The input is not in a correct format");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value is too large or too small, take a look data type.");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        return firstOption;
    }

    public static decimal GetInputByMessageToNumbers(string message)
    {
        Console.Write(message);
        decimal result;

        while (!decimal.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
            Console.Write(message);
        }

        return result;
    }

    public static string GetValidOperation(string message)
    {
        string result;

        do
        {
            Console.Write(message);
            result = Console.ReadLine();

            if (!IsValidOperation(result))
            {
                Console.WriteLine("Invalid operation. Please choose from +, -, *, /, %, sqrt, pow");
            }
        } while (!IsValidOperation(result));

        return result;
    }

    private static bool IsValidOperation(string input)
    {
        string[] validOperations = { "+", "-", "*", "/", "%", "sqrt", "pow" };
        return validOperations.Contains(input);
    }

    public static decimal GetInputByMessageToTable(string message)
    {
        Console.Write(message);
        decimal result;

        while (!decimal.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter valid numeric values.");
            Console.Write(message);
        }

        return result;
    }
    public static string GetUserValueByMessage(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
    public static decimal ConvertUserValueTodecimal(string userValue)
    {
        return Convert.ToDecimal(userValue);
    }
}

