using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Giraffe Academy"); // prints normal message
            Console.WriteLine("Giraffe\nAcademy"); // prints giraffe and academy on different lines
            Console.WriteLine("Giraffe\"Academy"); // forward slash allows quotation mark to be printed

            string phrase = "Giraffe Academy" + " is cool"; // you can add two separate strings to be one large string
            Console.WriteLine(phrase); // prints the string
            Console.WriteLine(phrase.Length); // outputs the length of string
            Console.WriteLine(phrase.ToUpper()); // raises all string characters to upper case
            Console.WriteLine(phrase.ToLower()); // lowers all string characters to lower case
            Console.WriteLine(phrase.Contains("Academy")); // returns true, since Academy is inside the phrase
            Console.WriteLine(phrase.Contains("Academies")); // returns false, since Academies is NOT inside the phrase
            Console.WriteLine(phrase[0]); // prints the first character of the phrase (indexing starts at 0)
            Console.WriteLine(phrase[2]); // prints the third character of the phrase
            /* index positions
            Giraffe Academy
            0123456 ...
            */
            Console.WriteLine(phrase[8]); // prints the ninth character of the phrase
            Console.WriteLine(phrase.IndexOf("Academy")); // prints the index position at which the string begins
            Console.WriteLine(phrase.IndexOf('f')); // prints the index position at which the char begins
            Console.WriteLine(phrase.IndexOf('z')); // prints "-1" since there is no "z"
            Console.WriteLine(phrase.Substring(8)); // prints character at index position "8" and the rest of the string
            Console.WriteLine(phrase.Substring(8, 3)); // prints character at index position "8", but just 3 characters total

            Console.ReadLine();
        }
    }
}
