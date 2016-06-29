using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4C1060Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parsing Numbers and Dates
            /*
            If someone inputs a number into an application then the number will 
            be submitted as a string and not a number. You need to parse the 
            number from the string. The int, decimal, and DateTime data types 
            all include Parse() methods that you can use to parse a string.
            */

            // get first number
            Console.Write("Enter the first number:");
            var firstNum = int.Parse(Console.ReadLine());

            // get second number
            Console.Write("Enter the second number:");
            var secondNum = int.Parse(Console.ReadLine());

            // display result
            var result = firstNum + secondNum;
            Console.WriteLine("The result is " + result.ToString());

            // pause
            Console.ReadLine();

        }
    }
}
