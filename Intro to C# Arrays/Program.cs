using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /**
             * As we begin working with C#, we will be working with large
             * amounts of data. Although variables are very useful as we learned
             * before, they are unfortunately not sufficient when working with
             * large amounts of data, since variables can only contain one string
             * or number at a time. To deal with this, we can utilize arrays. We
             * can think of arrays as essentially a collection of variables that
             * contain many different values or other types of information.
             */

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            // INDEX POSITIONS:    0  1   2   3   4   5

            /** Here, we've created an array of integers. We can refer to the
             * individual numbers within the brackets as 'elements', and we can
             * also note that the elements within an array are separated by commas.
             */

            Console.WriteLine(luckyNumbers[0]); // prints 4, which is the first element of the
                                                // array, (indicated by the index position 0)

            Console.WriteLine(luckyNumbers[2]); // prints 15, which is the third element of the
                                                // array, (indicated by the index position 2)

            /* We can also change the elements within our array. */

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]); // prints 900, which is the second element of the
                                                // array, (indicated by the index position 1)

            /* In addition to an array of integers, we can also create an array of strings.
             *
             * Also, When working with C#, we might not know at which particular positions we would
             * like to place our elements inside the array. So let's begin by creating an empty
             * array of strings.
             */

            //string[] friends = new string[]; // array of strings
            /*
             * We must place a number inside the square brackets within 'new string[]', which tells
             * C# how many strings we would like this array to hold. Thus, if we place 10 in the
             * square brackets, our array is able to hold 10 strings. This can be seen in the code
             * below:
             */

            string[] friends = new string[10]; // array of strings
            /*
             * Now, we can populate our array with information. We can see this in the following code:
             */
            friends[0] = "Michael";
            friends[1] = "Dwight";
            friends[2] = "Jim";
            friends[3] = "Pam";
            friends[4] = "Andy";
            friends[5] = "Oscar";
            friends[6] = "Angela";
            friends[7] = "Kevin";
            friends[8] = "Darryl";
            friends[9] = "Stanley";

            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
