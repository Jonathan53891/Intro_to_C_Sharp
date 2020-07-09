using System;
using static System.Console;

namespace Programming_Assignment_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Write("Enter a salesperson's name: ");
            String name = ReadLine();

            Write("Enter an item number between 1 and 4 or -1 to quit: ");
            int intItem = Convert.ToInt32(ReadLine());

            Write("Enter the quantity sold: ");
            int intQuantity = Convert.ToInt32(ReadLine());

            do
            {
                Console.WriteLine(intItem);
                intItem++;

            } while (intItem == -1);

            switch (intItem)
            {
                case 1:
                    double Item1 = 239.99;
                    double dblItemSales1 = Item1 * intQuantity;
                    Console.WriteLine(name + " has sold " + intQuantity + " of item #1 at " + dblItemSales1);
                    break;
                case 2:
                    double Item2 = 129.75;
                    double dblItemSales2 = Item2 * intQuantity;
                    Console.WriteLine(name + " has sold " + intQuantity + " of item #2 at " + dblItemSales2);
                    break;
                case 3:
                    double Item3 = 99.95;
                    double dblItemSales3 = Item3 * intQuantity;
                    Console.WriteLine(name + " has sold " + intQuantity + " of item #3 at " + dblItemSales3);
                    break;
                case 4:
                    double Item4 = 350.89;
                    double dblItemSales4 = Item4 * intQuantity;
                    Console.WriteLine(name + " has sold " + intQuantity + " of item #4 at " + dblItemSales4);
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

            WriteLine("Press the [enter] key to continue");

            ReadLine();
        }
    }
}
