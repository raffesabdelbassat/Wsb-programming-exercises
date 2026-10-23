using System;

class TemperatureConverter
{
    static void Main()
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
}
