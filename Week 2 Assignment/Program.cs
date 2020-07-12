using System;
using static System.Console;

namespace Programming_Assignment_2
{
    internal class MainClass
    {
        private static double dblItemSales1;
        private static double dblItemSales2;
        private static double dblItemSales3;
        private static double dblItemSales4;

        public static void Main(string[] args)
        {
            string name = "";
            string input = "";
            Write("Enter a Salesperson's name: ");
            name = Console.ReadLine();

            do
            {
                Write("Enter an item number between 1 and 4 or -1 to quit: ");

                input = Console.ReadLine();
                if (!input.Equals("-1"))
                {
                    int intItem = 0;
                    if (int.TryParse(input, out intItem))
                    {
                        Write("Enter the quantity sold: ");
                        int intQuantity = Convert.ToInt32(ReadLine());
                        switch (intItem)
                        {
                            case 1:
                                double Item1 = 239.99;
                                dblItemSales1 = 0.09 * Item1 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #1 at $" + dblItemSales1);
                                break;
                            case 2:
                                double Item2 = 129.75;
                                dblItemSales2 = 0.09 * Item2 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #2 at $" + dblItemSales2);
                                break;
                            case 3:
                                double Item3 = 99.95;
                                dblItemSales3 = 0.09 * Item3 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #3 at $ " + dblItemSales3);
                                break;
                            case 4:
                                double Item4 = 350.99;
                                dblItemSales4 = 0.09 * Item4 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #4 at $" + dblItemSales4);
                                break;
                            default:
                                WriteLine("Invalid Entry");
                                break;
                        }
                    }
                }
            } while (!input.Equals("-1"));

            WriteLine(""); //Space
            double TotalSales = 200 + dblItemSales1 + dblItemSales2 + dblItemSales3 + dblItemSales4;
            WriteLine("Salesperson " + name + " sold a total of $" + TotalSales);
            WriteLine(); //Space
            WriteLine("Press the [enter] key to continue...");
            ReadLine();
        }
    }
}
