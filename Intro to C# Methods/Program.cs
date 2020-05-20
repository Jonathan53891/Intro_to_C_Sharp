using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /**
             * Methods are simply a block of code that performs a specifc task.
             * We will use methods a lot while working with C#. We can utilize
             * a method to take code we've written and put it into it's own
             * container, which can allow us to further execute our program and
             * perform the task that we would like it to perform. We can call
             * methods at any point throughout our program and use them at
             * various spots throughout our program. That being said, methods
             * are a tool within C# that is certainly worth our time learning.
             *
             * We can demonstrate this by creating a method that simply says hi
             * to the user.
             */

            SayHi("Jonathan", 20); // passes string Jonathan and integer 20
            SayHi("Albert", 30);   // passes string Albert and integer 30
            SayHi("Megan", 40);    // passes string Megan and integer 40
            SayHi("Eugene", 50);   // passes string Eugene and integer 50

            /*
             * We can see above that were are able to reuse our method multiple
             * times, which helps in demonstrating how useful methods can be in
             * certain programs.
             */

            Console.ReadLine();
        }

        /*
         * To create a new method, we will have to place our code outside the
         * "public static void Main(string[] args){}" as demonstrated using
         * these comments. It is worth mentioning that "public static void
         * Main(string[] args){}" is a method it of itself, meaning it is a
         * specifc block of code that has been implemented in our C# program to
         * perform a certain task. Although that is the "main" method that works
         * as essentially the heart of our C# programs, we can create other
         * methods as we will begin to see in the following example.
         *
         * To create our new method, we must write "static", which we will touch
         * on later on. However, we can just state for now that "static" is
         * required to form a new method.
         *
         * After "static," we must specify a return type. The power of using
         * methods is that we can not only use them to perform specific
         * functions, but they can also return specific information back to us.
         *
         * We will learn more about return types later, but for now we will
         * simply write "void", which essentially means that the method will
         * not return any type.
         *
         * Since our method is performing a specific task, it is in our best
         * interest to name the method based on the functionality that the
         * method has. For instance, since the method below is simply producing
         * a greeting onto the console, we can name it "SayHi", as we can
         * clearly see below.
         */

        static void SayHi(string name, int age) // passes in the parameters "name" and "age"
        {
            //All of the code found within these curly brackets is apart of this method

            Console.WriteLine("Hello " + name + "! You are " + age + " years old!"); //prints greeting/name/age

            /*
             * However, simply writing this method isn't enough for this program
             * to run effectively. If we just run the program as is (without
             * anything else in the main method), the console will simply produce
             * a blank output. Thus, we must call this particular method inside
             * of the main method.
             */

            /*
             * People often refer to these as methods, but people also refer to
             * these as functions. Methods and functions are essentially the
             * same thing. They are slightly different by definition, however
             * they can (and are) be used interchangably. To be clear, we are
             * working with methods, not functions. However, this issue isn't
             * truly significant, just something to lightly touch on.
             */
        }
    }

}
