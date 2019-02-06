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
            var input = Console.ReadLine();

            while (input.ToLower() != "quit")
            {
                list.Add(input);
                input = Console.ReadLine();
            }

            List<string> distinct = list.Distinct().ToList(); // takes out the double elements of the list and put it in a  new list - uses linq
            Console.WriteLine("Unique nrs: ");
            foreach (var nr in distinct)
            {
                Console.WriteLine(nr);
            }

            List<string> selfDistinct = SelfDistinct(list);
            foreach (var nr in selfDistinct)
            {
                Console.WriteLine(nr);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// returns a distinct list of strings
        /// </summary>
        /// <param name="list">a list of strings</param>
        /// <returns>distinct list of strings</returns>
        private static List<string> SelfDistinct(List<string> list)
        {
            List<string> answer = new List<string>();
            foreach(string str in list)
            {
                if (!answer.Contains(str))
                {
                    answer.Add(str);
                }
            }
            return answer;
        }
    }
}
