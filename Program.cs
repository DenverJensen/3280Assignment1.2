using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            //
            string snumber1; //string of first number from user
            string snumber2; // string of second number from user
            double number1; //first number from user
            double number2; // second number from user
            double sum; //sum of user inputs
            double diff;//difference of user inputs
            double prod; //product of user inputs
            double quot; // quotient of user inputs
            double mod; //remainder of user inputs



            Console.WriteLine("Enter first number: "); //prompt
            snumber1 = Console.ReadLine(); //read

            //validate input
            while (!Double.TryParse(snumber1, out number1))
            {
                Console.WriteLine("Not a valid number, try again.");
                snumber1 = Console.ReadLine();
            }


            Console.WriteLine("Enter second number: "); //prompt
            snumber2 = Console.ReadLine(); //read

            //validate 2nd input
            while (!Double.TryParse(snumber2, out number2))
            {
                Console.WriteLine("Not a valid number, try again.");
                snumber2 = Console.ReadLine();
            }

            sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);

            diff = number1 - number2;
            Console.WriteLine("{0} - {1} = {2}", number1, number2, diff);

            prod = number1 * number2;
            Console.WriteLine("{0} * {1} = {2}", number1, number2, prod);

            quot = number1 / number2;
            Console.WriteLine("{0} / {1} = {2}", number1, number2, quot);

            mod = number1 % number2;
            Console.WriteLine("{0} % {1} = {2}", number1, number2, mod);

            //check if greater than
            if (number1 > number2)
            {
                Console.WriteLine("{0} is greater than {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not greater than {1}", number1, number2);
            }

            // check if less than
            if (number1 < number2)
            {
                Console.WriteLine("{0} is less than {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not less than {1}", number1, number2);
            }

            //check if equal
            if (number1 == number2)
            {
                Console.WriteLine("{0} is equal to {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", number1, number2);
            }
            Console.ReadLine();
        }
    }
}
