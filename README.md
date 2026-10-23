# Python and C# Console Exercises

Each task is a separate console program in both languages.

| Task | Python | C# |
|---|---|---|
| 1. Calculator | `python/task1/calculator.py` | `csharp/task1/Program.cs` |
| 2. Temperature converter | `python/task2/temperature_converter.py` | `csharp/task2/Program.cs` |
| 3. Grade average | `python/task3/grade_average.py` | `csharp/task3/Program.cs` |

## Run Python programs

From this repository's root, run the file for the task you want. For example:

```bash
python python/task1/calculator.py
python python/task2/temperature_converter.py
python python/task3/grade_average.py
```

## Run a C# program

Each C# file is the `Program.cs` for a console project. Create a project for the task, replace its `Program.cs` with the corresponding file above, and run it. For example:

```bash
dotnet new console -n Task1Calculator
# Copy csharp/task1/Program.cs to Task1Calculator/Program.cs
cd Task1Calculator
dotnet run
```

Repeat with a new console project and the matching `csharp/task2/Program.cs` or `csharp/task3/Program.cs` for the other tasks.
