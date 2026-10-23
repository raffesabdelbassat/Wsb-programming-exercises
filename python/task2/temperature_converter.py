direction = input("Convert Celsius to Fahrenheit (C) or Fahrenheit to Celsius (F)? ").upper()
temperature = float(input("Enter the temperature: "))

if direction == "C":
    converted = temperature * 1.8 + 32
    print(f"{temperature:g}°C = {converted:g}°F")
elif direction == "F":
    converted = (temperature - 32) / 1.8
    print(f"{temperature:g}°F = {converted:g}°C")
else:
    print("Invalid direction. Enter C or F.")
