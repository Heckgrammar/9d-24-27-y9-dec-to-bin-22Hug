using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE

            string binary = "";
            Console.WriteLine("Enter any integer");
            int integer = Convert.ToInt32(Console.ReadLine());
            while (integer > 0)
            {
                if (integer % 2 == 1)
                {
                    binary = "1" + binary;
                }
                else
                {
                    binary = "0" + binary;
                }
                integer /= 2;
            }
            Console.WriteLine(binary);
        }

        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            string result = "";
            Console.WriteLine("Enter any integer!");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                if (number % 2 == 1)
                {
                    result = "1" + result;
                }
                else
                {
                    result = "0" + result;
                }
                number /= 2;
            }
            Console.WriteLine(result);

           return result; //REMOVE THE RED LINE!
        }
    }
}
