# Programming Exercises: Python and C#

Console applications for three beginner programming exercises:

1. Two-number calculator (`+`, `-`, `*`, `/`)
2. Celsius/Fahrenheit converter
3. Student grade average and pass/fail check (pass threshold: 3.0)

## Python

Run from the repository root:

```bash
python python/main.py
```

## C#

Create a console project, replace its `Program.cs` with `csharp/Program.cs`, then run:

```bash
dotnet new console -n Exercises
# Copy csharp/Program.cs over Exercises/Program.cs
cd Exercises
dotnet run
```

Choose a task from the menu and follow the prompts.

## Exercise 3 as a separate program

The grade-average task is also available separately, without the task menu:

- Python: `python python/task3/grade_average.py`
- C#: create a console project with `dotnet new console -n GradeAverage`, replace its `Program.cs` with `csharp/task3/Program.cs`, then run `dotnet run` from the project folder.

Enter the number of grades, then each grade from 1 to 6. The program prints the average and whether the student passed (average at least 3.0).
