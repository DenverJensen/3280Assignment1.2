using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            //
            int number1; //first number from user
            int number2; // second number from user
            int sum; //sum of user inputs
            int diff;//difference of user inputs

            Console.Write("Enter first number: "); //prompt
            number1 = Convert.ToInt32(Console.ReadLine()); //read

            Console.Write("Enter the second number: "); //2nd prompt
            number2 = Convert.ToInt32(Console.ReadLine()); //2nd read

            sum = number1 + number2;
            diff = number1 - number2;

            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("{0} + {0} = ", sum);

        }
    }
}
