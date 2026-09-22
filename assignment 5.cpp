#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
   // create an array of integers
   vector<int> numbers = { 20, 35, 90, 66, 85 };
   // sort numbers numerically in reverse order
   sort ( numbers.rbegin(), numbers.rend() );
   // print numbers
 for ( int num : numbers )
 {
    cout << num << endl;  
  }   
  return 0;
 
   
   
}