using System;

namespace Giraffe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /**
             * You can also initialize the strings and prompt the user's input
             * in the following way:
             *
             * string adjective1, plural_noun1, verb_ing_word1, ... , silly_word2
             * 
             * Console.Write("Enter an adjective: ");
             * adjective1 = Console.ReadLine();
             * .
             * .
             * .
             * Console.Write("Enter a (capital-lettered) silly word: ");
             * silly_word2 = Console.ReadLine();
             */

            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            string plural_noun1 = Console.ReadLine();
            Console.Write("Enter a verb ending in 'ing': ");
            string verb_ing_word1 = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            string plural_noun2 = Console.ReadLine();
            Console.Write("Enter a female celebrity: ");
            string female_celebrity = Console.ReadLine();
            Console.Write("Enter a person in the room (male): ");
            string male_person_in_room = Console.ReadLine();
            Console.Write("Enter a (capital-lettered) silly word: ");
            string silly_word1 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();
            Console.Write("Enter a type of food (plural): ");
            string type_of_food_plural = Console.ReadLine(); // used twice
            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjective2 = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjective3 = Console.ReadLine();
            Console.Write("Enter a type of shoe (plural): ");
            string type_of_shoe_plural = Console.ReadLine();
            Console.Write("Enter something alive: ");
            string something_alive = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Enter a verb ending in 'ing': ");
            string verb_ing_word2 = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun3 = Console.ReadLine();
            Console.Write("Enter a (capital-lettered) silly word: ");
            string silly_word2 = Console.ReadLine();


            Console.WriteLine("One of the most " + adjective1 + " things about " +
                              "graduating is that my " + plural_noun1 + " are " +
                              verb_ing_word1 + " a huge party!");
            Console.WriteLine("I decided to have a backyard barbecue for all " +
                              "my family and " +
                              plural_noun2 + ". ");
            Console.WriteLine("I've invited my best friends " + female_celebrity +
                              ", " + male_person_in_room + ", and of course my " +
                              "teacher Mrs. " + silly_word1 + ". ");
            Console.WriteLine("My dad is going to " + verb1 + " hamburgers and " +
                              type_of_food_plural + " on his shiny new " + noun1 +
                              ". ");
            Console.WriteLine("He always thinks his " + type_of_food_plural +
                              " taste really " + adjective2 + ", but I think they " +
                              "taste like " + adjective3 + " " + type_of_shoe_plural +
                              ". ");
            Console.WriteLine("My mom is going to make her famous " +
                              something_alive + " salad, which is my favorite " +
                              noun2 + " ever!");
            Console.WriteLine("Mom said after we finish " + verb_ing_word2 + ", " +
                              "we can go swimming in our new " + noun3 + ". " +
                              silly_word2 + "!");

            Console.ReadLine();
        }
    }
}
