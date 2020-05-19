using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(58); // prints the number 58
            Console.WriteLine(5 + 8); // prints 13 (5 + 8 = 13)
            Console.WriteLine(5 - 8); // prints -3 (5 - 8 = -3)
            Console.WriteLine(5 * 8); // prints 40 (5 * 8 = 40)
            Console.WriteLine(8 / 4); // prints 2 (8 / 4 = 8/4 = 2/1 = 2)
            Console.WriteLine(5 % 2); // prints 1 (5 / 2 = 2 r 1, thus the program prints the remainder)
            Console.WriteLine(4 + 2 * 3); // prints 10 (4 + 2 * 3 = 4 + (2 * 3) = 4 + (6) = 4 + 6 = 10)
            Console.WriteLine((4 + 2) * 3); // prints 18 ((4 + 2) * 3 = (6) * 3 = 6 * 3 = 18)
            Console.WriteLine(5 / 2); // prints 2, even though 5 / 2 = 2.5
            Console.WriteLine(5 / 2.0); // prints 2.5, since now 2.0 is converted to a double,
                                        // we can work with decimals and ultimately receive a decimal answer
            int num1 = 6;
            Console.WriteLine(num1); // prints 6
            num1++; //incrementation adds 1 to 6
            Console.WriteLine(num1); //prints 7

            int num2 = 6;
            Console.WriteLine(num2); // prints 6
            num2--; //decrementation subtracts 1 from 6
            Console.WriteLine(num2); //prints 5

            //There are many math methods that we can utilize in C#
            Console.WriteLine(Math.Abs(-40)); // prints 40 (|-40| = 40)
            Console.WriteLine(Math.Pow(3,2)); // prints 9 (3^2 = 9)
            Console.WriteLine(Math.Pow(3.8, 2)); // prints 14.4 ((3.8)^2 = 14.4)
            Console.WriteLine(Math.Sqrt(36)); // prints 6 (sqrt(36) = 6)
            Console.WriteLine(Math.Max(4, 90)); // prints 90, since the max between 4 and 90 is clearly 90
            Console.WriteLine(Math.Min(4, 90)); // prints 4, since the min between 4 and 90 is clearly 4
            Console.WriteLine(Math.Round(4.3)); // prints 4, since the decimal 4.3 rounds down to the integer 4

            Console.ReadLine();
        }
    }
}
