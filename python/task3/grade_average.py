count = int(input("How many grades will you enter? "))

if count <= 0:
    print("Enter a number of grades greater than zero.")
else:
    total = 0.0
    for i in range(count):
        grade = float(input(f"Enter grade {i + 1} (1-6): "))
        total += grade

    average = total / count
    print(f"Average: {average:.2f}")
    if average >= 3.0:
        print("Student passed.")
    else:
        print("Student failed.")
