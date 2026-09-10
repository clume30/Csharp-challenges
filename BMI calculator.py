#BMI Calculator
print("Welcome, User")
# prompt user for their weight and height
weight = float(input("Enter your weight(kg): "))
height = float(input("Enter your height(m^2): "))
bmi = weight / (height ** 2) #performs BMI calculation
if bmi < 18.50:
    print("Underweight")
elif bmi < 25.00:
    print("Normal Weight")
elif bmi < 30.00:
    print("Overweight")
elif bmi < 35.00:
    print("Obesity(Class I)")
elif bmi < 40.00:
    print("Obesity(Class II)")
elif bmi >= 40.00:
    print("Severe Obesity(Class III)")