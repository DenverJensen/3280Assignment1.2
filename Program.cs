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
        /// <summary>
        /// Created by Denver Jensen 09/09/2021
        /// 
        /// This is a console-based program that allows the user to enter two numbers and then prints the results of addition, subtraction, multiplication, division, and the remainder of the two numbers.  
        /// Then the program prints whether the first number is less than the second number, 
        /// then prints whether the first number is greater than the second number, 
        /// then prints whether the first number equals the second number. 
        /// </summary>
        /// <param name="args"></param>
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


            /// receive user input for number1
            Console.WriteLine("Enter first number: "); //prompt
            snumber1 = Console.ReadLine(); //read


            /// Validate user input for number1 is a number and repeat validation until number is received
            while (!Double.TryParse(snumber1, out number1))
            {
                Console.WriteLine("Not a valid number, try again.");
                snumber1 = Console.ReadLine();
            }

            /// receive user input for number2
            Console.WriteLine("Enter second number: "); //prompt
            snumber2 = Console.ReadLine(); //read


            /// Validate user input for number1 is a number and repeat validation until number is received
            while (!Double.TryParse(snumber2, out number2))
            {
                Console.WriteLine("Not a valid number, try again.");
                snumber2 = Console.ReadLine();
            }

            ///sum
            sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);

            ///difference
            diff = number1 - number2;
            Console.WriteLine("{0} - {1} = {2}", number1, number2, diff);

            ///product
            prod = number1 * number2;
            Console.WriteLine("{0} * {1} = {2}", number1, number2, prod);

            ///quotient
            quot = number1 / number2;
            Console.WriteLine("{0} / {1} = {2}", number1, number2, quot);

            ///remainder
            mod = number1 % number2;
            Console.WriteLine("{0} % {1} = {2}", number1, number2, mod);

            /// check if number1 is greater than number2 and display results to console
            if (number1 > number2)
            {
                Console.WriteLine("{0} is greater than {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not greater than {1}", number1, number2);
            }

            /// check if number1 is less than number2 and display results to console
            if (number1 < number2)
            {
                Console.WriteLine("{0} is less than {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not less than {1}", number1, number2);
            }

            /// check if number1 is equal to number2 and display results to console
            if (number1 == number2)
            {
                Console.WriteLine("{0} is equal to {1}", number1, number2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", number1, number2);
            }

            ///
            Console.ReadLine();
        }
    }
}
