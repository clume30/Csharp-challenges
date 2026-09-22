// a program to determine whether a triangle is scalene, equilateral or isosceles
#include <iostream>
#include <math.h>

using namespace std;


int main()
{
    cout << "Welcome to our chat\n"; // Welcome message
 // Declaring variables
 float a; // the variable to represent the first side of the triangle imputed by the user 
 float b; // the variable to represent the second side of the triangle imputed by the user
 float c; // the variable to represent the third side of the triangle imputed by the user

// Logic of the calculation
 cout << "Enter the three sides of the triangle separated by space: s"; // prompts user for data
 cin >> a >> b >> c; // assigns the three float numbers into a, b, and c
 float s = ( a + b + c ) / 2.0;
 float area = sqrt(s * (s - a) * (s - b) * (s - c)); // the Hero's formula for area of a scalene and an isoceles triangle
 float area2 = (sqrt(3.0) * a * a) / 4.0;
 
 
    if ( a == b && a == c && b == c )
    {
        cout << "This triangle is an equilateral triangle\n";
        cout << "The area is = " << area2 << endl;
    } 
    else
    {
        if ( a != b && a != c && b != c )
        {
            cout << "This is a scalene triangle\n";
            cout << "The area is = " << area << endl;
        }
        else
        {
            cout << "This is an isosceles triangle\n";
            cout << "The area is = " << area << endl;
        }
    
    }
 return 0;

}
