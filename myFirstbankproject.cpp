#include <iostream>
#include <string>
using namespace std;

int main()
{
int num;
float balance = 20000.00;
while (num > 4 || num <= 0)
 {
    cout << "  ****** WELCOME TO CLUME'S BANK ****** \n";
    cout << "what do you want from our service today?\n";
    cout << "1. check balance\n";
    cout << "2. deposit money\n";
    cout << "3. withdraw money\n";
    cout << "4. Exit\n";
    
      cin >> num;  
     
 }
 
 switch( num )
    {
      case 1:
       cout << balance;
       break;
    
          
       case 2:
       float deposit;
       cout << "how much do you want to deposit?: \n";
       cin >> deposit;
       balance += deposit;
       cout << "your current balance is:    ₦" << balance << endl;
       break;
       
       
       case 3:
       float amount;
       cout << "how much do you want to withdraw?";
       cin >> amount;
       if (amount > balance )
             {
                 cout << "insufficient balance\n";
             }
        else  {
             balance -= amount;
                  }
           cout << "your balance is:    ₦" << balance << endl;
           
           
         case 4:
         return 0;
        
    }
return 0;
}