using System;

namespace SecondProject
{
    // Projects contain classes
    // Classes contain members like methods and fields


    class Program
    {
        //static main method like Java for console to run
        static void Main(string[] args)
        {
            Console.WriteLine("Is there an echo in here?");


            // C# is (strongly) typed

            //unlike java, no like scanners or input streams neccisssary 
            String userInput = Console.ReadLine();
            Console.WriteLine(userInput);


            //look up switch expression, does pattern matching.

            int length = 4;

            //triangle
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
