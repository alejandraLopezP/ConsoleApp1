using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string userInput = "";
            //get value from user
            userInput = Console.ReadLine();
            //cover input to integer
            number = int.Parse(userInput);
            //is number even?
            if(number % 2 == 0)
            {
                Console.WriteLine("Talet {0} är jämnt.", number);
            }
            else
            {
                WriteLine("Talet {0} är udda", number);
            }

          
            //stop until user press a key
            Console.ReadKey();
        }
    }
}
