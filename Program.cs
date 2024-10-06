using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

string userName = "";
int userAge = 0;
int currentYear = 0;

Console.WriteLine("Please enter your name: ");
userName = Console.ReadLine();

Console.WriteLine("Please enter you age: ");
userAge = Convert.ToInt32(Console.ReadLine());

if (userAge < 0 || userAge > 100)
{
    Console.WriteLine("Invalid Age");
    Console.WriteLine("Age mush be greater than zero");
}

else if (userAge < 18)
    Console.WriteLine("Sorry you're underage");
else if (userAge < 21)
    Console.WriteLine("You need parental concent");
else
    {
        Console.WriteLine("Congratulations!");
        Console.WriteLine("You may sign up for the event!");
    }

Console.WriteLine("Please enter the current year: ");
currentYear = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);
