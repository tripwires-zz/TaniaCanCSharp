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
            Console.WriteLine("Gief Name");
            var input = Console.ReadLine();

            //turns the string into an array of chars
            char[] characters = input.ToCharArray();

            var reverse = input.Reverse();

            foreach (char ch in reverse)
            {
                Console.Write(ch);
            }

            Console.ReadLine();
        }
    }
}
