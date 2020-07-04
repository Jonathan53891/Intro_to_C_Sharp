using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
             * Now, we will begin looking at "if" statements. The logic of "if"
             * statements can proceed like the following example below:
             * 
             * I wake up
             * If I'm hungry
             *      I eat breakfast
             * 
             * I look at my phone
             * If it's about to die
             *      I charge it
             * 
             * I leave my house
             * If it's cloudy
             *      I bring an umbrella
             * otherwise
             *      I bring sunglasses
             * 
             * Essentially, when you follow an "if" statement it has the basic
             * logic IF i do this THEN i do that. If you have coded before, this
             * is not a very difficult concept to grasp.
             */

            bool isMale = true;
            bool isTall = true;

            //When the above variable is TRUE, we want our program to do something
            /*
            if (isMale || isTall) //checks to see if person 1) is male OR 2) is tall
            {
                Console.WriteLine("You are a tall male."); //prints if given true value
            }
            */
            if (isMale && isTall) //checks to see if person 1) is male AND 2) is tall
            {
                Console.WriteLine("You are a tall male."); //prints if given true value
            }
            else if (isMale && !isTall) //checks to see if 1) is male AND 2) is NOT tall
            {
                Console.WriteLine("You are a short male."); //prints if given true & false values
            }
            else if (!isMale && isTall) //checks to see if 1) is NOT male AND 2) is tall
            {
                Console.WriteLine("You are a tall but not male."); //prints if given true & false values
            }
            else
            {
                Console.WriteLine("You are NOT tall OR a male."); //prints if given false value
            }

            /*
             * Since "isMale" is set to be true, the above "for" loop will print
             * the given message, "You are male." If we set "isMale" to be false,
             * we will receive nothing in the console if we try running the 
             * program. Thus, the line of code as seen above is only executed
             * when the variable being used holds true.
             * 
             * (Else statement was added later on)
             */

            Console.ReadLine();
        }

    }

}
