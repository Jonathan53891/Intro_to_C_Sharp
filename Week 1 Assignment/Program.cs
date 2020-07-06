using System;
using static System.Console;

namespace Programming_Assignment_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Write("Enter the first integer: ");

            //int num1 = ReadLine();
            /*
             * If we use the line above, we will receive an error because
             * ReadLine() takes in the user input as a string. So we must
             * convert the user input from a string to an integer.
             */

            int num1 = Convert.ToInt32(ReadLine());
            /* 
             * The program will run now, since the string gets converted
             * to an integer
             */

            Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(ReadLine());

            WriteLine("The two numbers you entered are: " + num1 + " and " + num2);
            WriteLine("The sum of the two numbers is " + (num1 + num2));
            WriteLine("The difference of the two numbers is " + (num1 - num2));
            WriteLine("The product of the two numbers is " + (num1 * num2));
            WriteLine("The quotient of the two numbers is " + (num1 / num2));
            WriteLine("The remainder of the two numbers is " + (num1 % num2));
            WriteLine(""); //for spacing

            if (num1 == num2)
            {
                WriteLine("Both numbers are the same.");
            }
            else
            {
                WriteLine("Given numbers are NOT the same.");
                WriteLine("The larger of the two numbers is " + Math.Max(num1, num2));
            }

            WriteLine("Press the [enter] key to continue");

            ReadLine();
        }
    }
}
