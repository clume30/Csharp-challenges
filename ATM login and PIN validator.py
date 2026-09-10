print("Welcome to Google account")
user_pin = 2070
i = 0
while i < 3:
    login_pin = int(input("Enter your pin: "))
    if login_pin == user_pin:
         print("Welcome User")
    else:
        print("Invalid pin, try again")
    i += 1
    
print("")
print("Account locked till 5mins later")