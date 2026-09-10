#Tip and Split Bill Calculator:
#calculates the total bill and adds the tip to the total bill and shares it among friends
bill = float(input("Enter the total bill(Hostess tip 10%): "))
number_of_friends = float(input("Enter the number of friends: "))  
hostess_tip = 0.10 * bill
total_bill = hostess_tip + bill
price_per_friend = total_bill / number_of_friends
prices_per_friend = round(price_per_friend, 2)
total_bills = str(total_bill)
prices_each = str(prices_per_friend)
print("Total bill is: $" + total_bills)
print("price per friend: $" + prices_each)

  
