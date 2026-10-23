"""Exercise 3: calculate a student's grade average and report pass/fail."""

count = int(input("How many grades will you enter? "))
if count <= 0:
    print("Enter a number of grades greater than zero.")
else:
    total = 0.0
    for i in range(count):
        total += float(input(f"Enter grade {i + 1} (1-6): "))

    average = total / count
    print(f"Average: {average:.2f}")
    print("Student passed." if average >= 3.0 else "Student failed.")
