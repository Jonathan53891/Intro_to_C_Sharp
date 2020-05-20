using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Here, we will explore the various return types we can utilize as
             * we dive further into developing in C#. Essentially, we are able
             * to return values back to their callers within methods.
             */

            //Cube(5); // simply running this line of code will not produce an
                       // output onto the console
            Console.WriteLine(Cube(5)); // prints 125 ((5)^3 = 5*5*5 = 25*5 = 125)

            int cubedNumber = Cube(3); //produces 3^3 = 27
            Console.WriteLine(cubedNumber); // prints 27

            Console.ReadLine();
        }

        /* We will create a method that will cube a number. It will take a
         * number as a parameter, cube it, and return it back to the caller.
         *
         * Here we can begin writing our method with "static", which we will
         * learn more about later on in our C# learning. Next, we must specify
         * the return type, which we will write as "int". Lastly, to give our
         * method a relevant name to the functionality that it will have, we
         * will name it "Cube".
         */

        static int Cube(int num) //method will take one parameter (an integer "num")
        {
            int result = num * num * num; // produces (num)^3 = result
            return result; //We use "return" to return a piece of information back to the caller
                           //Here, we return "result" back to the caller

        }

        /*
         * The method above can also return a string, double, even an array
         * of doubles, and more.
         */

    }

}
