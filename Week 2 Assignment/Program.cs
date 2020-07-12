using System.Collections;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Programming_Assignment_2
{
    internal class MainClass
    {
        private static readonly int dblItemSales1;
        private static readonly int dblItemSales2;
        private static readonly int dblItemSales3;
        private static readonly int dblItemSales4;
        //private static readonly double payPerWeek = 200.00;
        //private static readonly double percentage = 0.09;

        public static void Main(string[] args)
        {
            string name = "";
            string input = "";
            //int intItem = 0;
            //int intQuantity = 0;
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
                        //int intQuantity = 0;
                        switch (intItem)
                        {
                            case 1:
                                //Item1Calc();
                                double Item1 = 239.99; //WORKS
                                //double percentage1 = 0.09; //DOESNT WORK
                                double dblItemSales1 = Item1 * intQuantity; //WORKS
                                //double dblItemSales1 = percentage1 * Item1 * intQuantity; //DOESNT WORK
                                WriteLine(name + " has sold " + intQuantity + " of item #1 at $" + dblItemSales1); //WORKS
                                break;
                            case 2:
                                double Item2 = 129.75;
                                //double percentage2 = 0.09;
                                //double dblItemSales2 = percentage2 * Item2 * intQuantity;
                                double dblItemSales2 = Item2 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #2 at $" + dblItemSales2);
                                break;
                            case 3:
                                double Item3 = 99.95;
                                //double percentage3 = 0.09;
                                //double dblItemSales3 = percentage3 * Item3 * intQuantity;
                                double dblItemSales3 = Item3 * intQuantity;
                                WriteLine(name + " has sold " + intQuantity + " of item #3 at $ " + dblItemSales3);
                                break;
                            case 4:
                                double Item4 = 350.99;
                                //double percentage4 = 0.09;
                                //double dblItemSales4 = percentage4 * Item4 * intQuantity;
                                double dblItemSales4 = Item4 * intQuantity;
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
            double TotalSales = dblItemSales1 + dblItemSales2 + dblItemSales3 + dblItemSales4;
            //WriteLine("Salesperson " + name + " sold a total of $" + dblItemSales1);
            WriteLine("Salesperson " + name + " sold a total of $" + TotalSales);
            //WriteLine("Salesperson " + name + " sold a total of $0.00" + (200 + TotalSales));
            WriteLine(); //Space
            WriteLine("Press the [enter] key to continue...");
            ReadLine();
        }
    }
}
