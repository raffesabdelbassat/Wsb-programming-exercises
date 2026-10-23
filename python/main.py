def calculator():
    first = float(input("Enter the first number: "))
    second = float(input("Enter the second number: "))
    operation = input("Choose an operation (+, -, *, /): ")

    if operation == "+":
        result = first + second
    elif operation == "-":
        result = first - second
    elif operation == "*":
        result = first * second
    elif operation == "/":
        if second == 0:
            print("Cannot divide by zero.")
            return
        result = first / second
    else:
        print("Invalid operation.")
        return

    print(f"Result: {result:g}")


def temperature_converter():
    direction = input("Convert Celsius to Fahrenheit (C) or Fahrenheit to Celsius (F)? ")
    temperature = float(input("Enter the temperature: "))

    if direction.upper() == "C":
        converted = temperature * 1.8 + 32
        print(f"{temperature:g}°C = {converted:g}°F")
    elif direction.upper() == "F":
        converted = (temperature - 32) / 1.8
        print(f"{temperature:g}°F = {converted:g}°C")
    else:
        print("Invalid direction. Enter C or F.")


def grade_average():
    count = int(input("How many grades will you enter? "))
    if count <= 0:
        print("Enter a number of grades greater than zero.")
        return

    total = 0.0
    for i in range(count):
        total += float(input(f"Enter grade {i + 1} (1-6): "))

    average = total / count
    print(f"Average: {average:.2f}")
    print("Student passed." if average >= 3.0 else "Student failed.")


print("Choose a task: 1) Calculator  2) Temperature converter  3) Grade average")
choice = input("Your choice: ")

if choice == "1":
    calculator()
elif choice == "2":
    temperature_converter()
elif choice == "3":
    grade_average()
else:
    print("Invalid task.")
