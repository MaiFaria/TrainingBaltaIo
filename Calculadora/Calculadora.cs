namespace Training.BaltaIo.Calculadora;

public abstract class Calculator
{
    public static void Menu()
    {
        var res = ValidateDesiredMenu();

        if (res == 0)
            Environment.Exit(0);

        ValidateValues(out float v1, out float v2);

        switch (res)
        {
            case 1:
                Result((v1 + v2), "Sum");
                break;
            case 2:
                Result((v1 / v2), "Division");
                break;
            case 3:
                Result((v1 * v2), "Multiplication");
                break;
            case 4:
                Result((v1 - v2), "Subtraction");
                break;
            default:
                Menu();
                break;
        }
    }

    private static short ValidateDesiredMenu()
    {
        Console.Clear();

        Console.WriteLine("Select the desired operation");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Division");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Subtraction");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("---------------------------------------");

        return short.Parse(Console.ReadLine());
    }

    private static void ValidateValues(out float v1, out float v2)
    {
        Console.Clear();

        Console.WriteLine("First Value: ");
        v1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Second Value: ");
        v2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");
    }

    private static void Result(float result, string v)
    {
        Console.WriteLine($"The result of {v} is {result}");
        Console.ReadKey();
        Menu();
    }
}
