using System;

namespace Acronymalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase");
            String userInput = Console.ReadLine();

            String[] words = userInput.Split(" ");

            String Acronym = new String("");

            for( int i = 0; i < words.Length; i++){

                if(words[i].Length > 0)
                {
                    words[i] = words[i].Trim();
                    Acronym = Acronym + words[i][0];
                }
                
            }
            Console.WriteLine(Acronym);
        }
    }
}
