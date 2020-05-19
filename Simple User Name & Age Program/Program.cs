using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, fellow user!");

            //Console.ReadLine();
            /**
             * Deleting this line of code means that the program has no further
             * instructions aside from Console.WriteLine("Hello"). This means
             * that the program will automatically terminate and the console
             * window just disappears.
             *
             * Actually (as you may have already noticed), Console.ReadLine()
             * essentially pauses the program, as it waits for the user to enter
             * a line of text. Thus, the execution of the entire program is
             * paused as it waits for the user to enter something.
             *
             * Another thing that this line of code does is that it allows the
             * user to enter a line of text.
             *
             * The following program from this point on will be an application
             * that asks for the user's name, allows the user to enter his or
             * her name, and the program outputs a greeting to the user while
             * mentioning the name that is given.
             */

            Console.Write("Enter your name: ");
            /*
             * Console.WriteLine() writes a message on a new line.
             * Console.Write() does not write on a new line
             */

            //Console.ReadLine();
            /* this line of code above allows the user to enter his or her
             * name, but we need to store the name in an object
             */

            string name = Console.ReadLine(); //allows the user to enter a name
                                              //and stores it in a string

            //Console.WriteLine("Hello " + name + "!"); //prints a message to user
            Console.Write("Enter your age: ");

            string age = Console.ReadLine(); //allows the user to enter an age
                                              //and stores it in an object

            Console.WriteLine("Hello " + name + "! You are " + age + " years old!"); //prints a message to user


            Console.ReadLine();
        }
    }
}
