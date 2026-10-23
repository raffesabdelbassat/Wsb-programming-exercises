using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine()!);
        Console.Write("Choose an operation (+, -, *, /): ");
        string operation = Console.ReadLine()!;

        double result;
        switch (operation)
        {
            case "+": result = first + second; break;
            case "-": result = first - second; break;
            case "*": result = first * second; break;
            case "/":
                if (second == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = first / second;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
