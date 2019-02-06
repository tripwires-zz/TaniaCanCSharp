using System;
using System.Collections.Generic;

namespace ExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = 0;
            var input = ""; // the name we get
            var listNames = new List<string>();
            var others = 0;

            //user enters names => enter == exit
            //as long as the input is not empty we will keep asking names

            do
            {
                Console.WriteLine("Enter different names, press enter to exit");

                input = Console.ReadLine();
                if (!listNames.Contains(input) && (!string.IsNullOrEmpty(input)))
                {
                    listNames.Add(input);
                }
                else if (listNames.Contains(input))
                {
                    Console.WriteLine("You already entered that name, enter another one please");
                }

            }while(!string.IsNullOrEmpty(input));

            //the amount of likes
            likes = listNames.Count;

            // => +>2 = likes ==> others = likes - 2
            //no likes = do nothing
            //1 like = [Friend's Name] likes your post
            //2 likes = [Friend 1] and [Friend 2] like your post
            //+2 likes =  [Friend 1], [Friend 2] and [Number of Other People] others like your post
            //
            if (likes > 2)
            {
                others = likes - 2;
                Console.WriteLine("{0}, {1} and {2} others like your post", listNames[0], listNames[1], others);
            }
            else if (likes == 2)
            {
                Console.WriteLine("{0} and {1} like your post", listNames[0], listNames[1]);
            }
            else
            {
                Console.WriteLine("{0} likes your post", listNames[0]);
            }


        }
    }
}
