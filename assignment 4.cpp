#include <iostream>
using namespace std;

void addition ( int &add, int &subtract )
{
   add = 65;
   subtract =70;
}

int main()
{
   int first_value = 45;
  int second_value = 60;
    
      cout << "before swap: " << first_value << second_value << endl;
      
    addition( first_value, second_value );
    
    cout << "after swap: " << first_value << second_value << endl;
    
    
    return 0;
}