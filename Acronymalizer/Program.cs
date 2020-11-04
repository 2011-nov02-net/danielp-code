using System;

namespace Acronymalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase.");
            String userInput = Console.ReadLine();

            String[] words = userInput.Split(" ");

            String Acronym = new String("");

            for( int i = 0; i < words.Length; i++)
            {
                //TODO: skip and and the, and some other basic words.
                //skip any enteries that are empty
                if(words[i].Length > 0)
                {
                    //avoid leading spaces
                    words[i] = words[i].Trim();

                    //append the character to the acronym
                    Acronym = Acronym + words[i][0];
                }
            }

            //make the acronym upper case like real acronyms
            Acronym = Acronym.ToUpper();
            Console.WriteLine(Acronym);
        }
    }
}
