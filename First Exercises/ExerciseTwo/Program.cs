using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverse name
            Console.WriteLine("Gief Name");
            string input = Console.ReadLine();

            //turns the string into an array of chars
            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                Console.Write(characters[characters.Length - i - 1]);
            }

            Console.WriteLine();

            var reverse = input.Reverse();
            foreach (char ch in reverse)
            {
                Console.Write(ch);
            }

            Console.ReadLine();
        }
    }
}
