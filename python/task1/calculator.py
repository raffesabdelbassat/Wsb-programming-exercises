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
        raise SystemExit
    result = first / second
else:
    print("Invalid operation.")
    raise SystemExit

print(f"Result: {result:g}")
