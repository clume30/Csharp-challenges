import os
print("welcome to Clume's Guessing game") #welcomes user
host_input = int(input(("You are the host, Enter the number to be guessed(only whole numbers): ")))
i = 0
user_input = 0
os.system("cls") #clear the terminal
while  host_input != user_input:
    user_input = int(input("Guess the number: "))
    if user_input > host_input:
        print("number too high, try again")
    elif user_input < host_input:
        print("number too low, try again")
    i += 1
    
print("Congratulations, you got it in", i, "trials")
    