using System;

class GradeAverage
{
    static void Main()
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
