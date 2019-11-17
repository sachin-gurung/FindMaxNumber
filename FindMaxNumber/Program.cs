using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program and ask the user to enter a series of numbers separated by comma. 
Find the maximum of the numbers and display it on the console. 
For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
*/
namespace FindMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers with commas in between the numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var maxnumber = int.Parse(numbers[0]);
            foreach (var str in numbers)
            {
                var number = int.Parse(str);
                if (number > maxnumber)
                    maxnumber = number;
            }
            Console.WriteLine("The maximum number is " + maxnumber);
        }
    }
}
/*
Enter numbers with commas in between the numbers: 56,87,32,2
The maximum number is 87
Press any key to continue . . .
*/
