using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            // -ask to enter 5 nrs
            // - cannot be the same nr as before => ask to reenter => list
            //+ contains to check if the nr is already used or not
            // -after 5 nrs are entered => sort and display them => sort, cw

            int totalNrsEntered = 0;
            List<int> listOfNrs = new List<int>();

            while (totalNrsEntered < 5)
            {
                Console.WriteLine("Enter a nr. You have {0} numbers entered out of 5", totalNrsEntered);

                var input = Convert.ToInt32(Console.ReadLine());


                if (!listOfNrs.Contains(input))
                {
                    listOfNrs.Add(input);
                    totalNrsEntered++;
                }
                else
                {
                    Console.WriteLine("Enter another nr. Your list already contains this nr");
                }
            }
            Console.WriteLine();

            listOfNrs.Sort();
            foreach (int nr in listOfNrs)
            {
                Console.Write(nr + ", ");
            }
            Console.ReadLine();
        }
    }
}
