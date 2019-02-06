using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            //-enter a nr, type quit to exit
            //- duplicates allowed
            //- display unique nrs

            var list = new List<string>();
            Console.WriteLine("Enter a nr or type 'quit' to exit");
            var input = "";


            while (input.ToLower() != "quit")
            {
                input = Console.ReadLine();

                if (input.ToLower() != "quit")
                    list.Add(input);
            }

            List<string> distinct = list.Distinct().ToList(); // takes out the double elements of the list and put it in a  new list - uses linq

             Console.WriteLine("Unique nrs: ");
            foreach (var nr in distinct)
                Console.WriteLine(nr);
        }
    }
}
