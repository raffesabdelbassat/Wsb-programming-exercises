using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a task: 1) Calculator  2) Temperature converter  3) Grade average");
        Console.Write("Your choice: ");

        switch (Console.ReadLine())
        {
            case "1": Calculator(); break;
            case "2": TemperatureConverter(); break;
            case "3": GradeAverage(); break;
            default: Console.WriteLine("Invalid task."); break;
        }
    }

    static void Calculator()
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

    static void TemperatureConverter()
    {
        Console.Write("Convert Celsius to Fahrenheit (C) or Fahrenheit to Celsius (F)? ");
        string direction = Console.ReadLine()!.ToUpperInvariant();
        Console.Write("Enter the temperature: ");
        double temperature = double.Parse(Console.ReadLine()!);

        switch (direction)
        {
            case "C":
                Console.WriteLine($"{temperature}°C = {temperature * 1.8 + 32}°F");
                break;
            case "F":
                Console.WriteLine($"{temperature}°F = {(temperature - 32) / 1.8}°C");
                break;
            default:
                Console.WriteLine("Invalid direction. Enter C or F.");
                break;
        }
    }

    static void GradeAverage()
    {
        Console.Write("How many grades will you enter? ");
        int count = int.Parse(Console.ReadLine()!);
        if (count <= 0)
        {
            Console.WriteLine("Enter a number of grades greater than zero.");
            return;
        }

        double total = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter grade {i + 1} (1-6): ");
            total += double.Parse(Console.ReadLine()!);
        }

        double average = total / count;
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine(average >= 3.0 ? "Student passed." : "Student failed.");
    }
}
