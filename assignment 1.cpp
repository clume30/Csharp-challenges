#include <iostream>
using namespace std;

int main()
{
 // declaring variables 
 int x;
 int y;
 
  cout << "enter the two integers separated by space: \n";
 cin >> x >> y;    
 
   int add = x + y;
   int subtract = x - y;
   int divide = x / y;
   int multiply = x * y;
   int modulus = x % y;
   int ampersand = x & y;
   
   
   cout << "the sum is: " <<  add << endl;
    cout << "the subtraction is: " << subtract << endl;
    cout << "the division is: " << divide << endl;
    cout << "the multiplication is: " << multiply << endl;
    cout << "the modulus is: " << modulus << endl;
    cout << "the ampersand is: " << ampersand << endl;
    
 
    
}