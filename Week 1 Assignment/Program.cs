using System;

namespace Programming_Assignment_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");

            //int num1 = Console.ReadLine();
            /*
             * If we use the line above, we will receive an error because
             * Console.ReadLine() takes in the user input as a string. So we
             * must convert the user input from a string to an integer.
             */

            int num1 = Convert.ToInt32(Console.ReadLine());
            /* The program will run now, since the string gets converted
             * to an integer
             */

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The two numbers you entered are: " + num1 + " and " + num2);
            Console.WriteLine("The sum of the two numbers is " + (num1 + num2)); //adds the two inputted numbers
            Console.WriteLine("The difference of the two numbers is " + (num1 - num2));
            Console.WriteLine("The product of the two numbers is " + (num1 * num2));
            Console.WriteLine("The quotient of the two numbers is " + (num1 / num2));
            Console.WriteLine("The remainder of the two numbers is " + (num1 % num2));
            Console.WriteLine(""); //for spacing
            Console.WriteLine("The larger of the two numbers is " + Math.Max(num1, num2));
            
            Console.ReadLine();
        }
    }
}
