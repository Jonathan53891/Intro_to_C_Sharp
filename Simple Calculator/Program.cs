using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /** We can utilize a special method in C# convert a string into a
             * number.
             */

            Console.WriteLine("43" + "56"); // prints "4356" (combines the strings together)

            //int num = "45"; // C# does not allow strings to be stored in integer variables
                              // However, we can do the following:

            int num = Convert.ToInt32("45"); // converts string to integer
            Console.WriteLine(num + 6); // prints 51 (45 + 6 = 51, since 45 is now an integer)

            Console.Write("Enter a number (integer): ");

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

            Console.Write("Enter another number (integer): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Result: " + (num1 + num2)); //adds the two inputted numbers
            /**
             * However, we must note that this calculator cannot calculate
             * decimal values. Since num1 and num2 were set to be integers, they
             * can only work with whole numbers. Thus, if we input decimal
             * numbers while running this particular program, the program will
             * stall.
             *
             * To combat this, we can simply use doubles instead of ints.
             */

            Console.Write("Enter a number (integer or decimal): ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number (integer or decimal): ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Final Result: " + (num3 + num4)); //adds the two inputted numbers

            Console.ReadLine();
        }
    }
}
