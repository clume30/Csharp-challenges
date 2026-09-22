#include <iostream>
#include <string>
using namespace std;

// class account definition 
class Account 
{
    // list of data members
    private:
   string accountName;
   int accountNumber;
    float balance;
   float credit;
    float debit;
    
    
    public: 
    
  Account ( string accName, int accNumber, float cr, float db )
  {
   
   
   setAccountName( accName );
   setAccountNumber( accNumber ); 
   setCredit( cr );
   setDebit( db );
   
   
  } // end of constructor

    
   // 1.  sets the account name         
 void  setAccountName( string accName )
 {
   cout << "enter your full name\n"; // prompts the user for his full name
   getline( cin, accName );
   accountName = accName;
 }
 
 string getAccountName()
 {
    return accountName;    
 }
 
 
 
 //2.  sets the account number 
 void setAccountNumber( int accNumber )
 {
     cout << "enter your account number\n"; // prompts the user for his account number
     cin >> accNumber;
     accountNumber = accNumber;
 }
 
 // gets the account number 
 int getAccountNumber()
 {
     return accountNumber;
 }
 
 
 
 // 3. sets the credit 
 void setCredit( float cr)
 {  
    cout << "how much do you want to add?\n"; // prompts the user to enter the amount he wants to add
    cin >> cr;
    balance += cr;
   credit = cr;   
 }

 float getCredit()
 {
   return credit;
 }
 

 
// 4. sets the debit
void setDebit( float db )
{
 cout << "how much do you want to use:\n"; // prompts the user to enter the amount he wants to debit
 cin >> db;
 if ( db > balance )
 {
   cout << "insufficient funds,  transaction denied\n";
     
 } else 
 {
    balance -= db; 
     
 }
 
 debit = db;
}


// 5. balance 


float getBalance()
 { 
    return balance;
 }
    
    
};


int main()
{
cout << "********Welcome to clume's Bank*******\n";

Account myAccount( "clume", 8148441135, 20, 0 );
system ("cls");
cout << "Name: " << myAccount.getAccountName() << endl;
cout << "Account Number: " << myAccount.getAccountNumber() << endl;
cout << "Available Balance: " << myAccount.getBalance() << endl;

return 0;
}