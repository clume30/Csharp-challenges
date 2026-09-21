// guessing game program
#include <iostream>
#include <string>
using namespace std;

int main()
{
    // declaring variables
    int host_num;// stores the host number
    int user_num; //stores the guesser's number
    int trials = 0; // stores the number of times the user got it 
    int time_left; // stores the time left
    // welcome message
    cout << "Welcome to Dubem's guessing game\n";
    cout << "You are the host enter your number to be guessed: "; // prompts the host for his number
    cin >> host_num;// inserts the user's number into host_num
    system("cls");// clears the terminal
    
   while (user_num != host_num )
   {
   	time_left = 10 - trials;
   	cout << "Guess the number in " << time_left << " trials: ";
    cin >> user_num;
    
    // conditional statement to check if the user's number is high or low
    if(user_num > host_num)
    {
    	cout << "Too high, try again!!\n";
	}
	else if(user_num < host_num)
	{
		cout << "Too low, try again!!\n";
	}
    trials++;
   
    if(trials == 10)
    {
    	cout << "Trials are over!!!, better luck next time";
    	break;
	}
    
   }// end of while loop
   
  if(user_num == host_num)
  {
  	 cout << "Congratulations, you got it in " << trials << " trials";
  }
   

    return 0;
} // end of main function
