using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using danielp_code.RockPaperScicsors.Ai;
using danielp_code.RockPaperScicsors.AI;

namespace danielp_code.RockPaperScicsors
{
    class Program
    {
        //switch to list of AI's that know their own name?
        private static readonly List<String> AINames = new List<string> { "random", "smart" };
        private static readonly List<String> PlayerActions = new List<string> { "p, q, h" };
        private static readonly List<String> PlayerMoves = new List<string> { "rock, paper, scissors, r, p, s" };


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Sciscors!");


            //TODO: pull out into function
            // - - - choose your cpu - - - //
            //get input
            string input = null;
            while(!validateAiInput(input, AINames))
            {
                Console.WriteLine("Choose the AI to play against:");
                Console.WriteLine("Random - Randomly chooses moves.");
                Console.WriteLine("Smart - takes into account some information");
                input = Console.ReadLine();
                input = input.Trim().ToLower();
            }

            //use input
            IAI gameai;
            switch (input)
            {
                case ("random"):
                    gameai = new RandomAI();
                    break;

                case ("smart"):
                    gameai = new SmarterAI();
                    break;

                default:
                    Debug.WriteLine("Warning, unknown input made it through the AI choice input validation");
                    gameai = new RandomAI();
                    break;
            }


            // - - - choose your cpu - - - //
            //create the game
            Game game = new Game(gameai);


            //player inputs: play again, see history, exit
            //TODO: PULL OUT INTO FUNCTION 
            //get input
            //loop until quit
            while (true)
            {
                input = "p";
                while (!validateAiInput(input, PlayerActions) ){
                    Console.WriteLine("Choose what to do");
                    Console.WriteLine("q - quit the game.");
                    Console.WriteLine("h - view history");
                    Console.WriteLine("p - play again");
                    input = Console.ReadLine();
                    input = input.Trim().ToLower();
                }

                switch (input)
                {
                    case ("q"):
                        return;
                        break;
                    case ("h"):
                        //TODO: print history
                        break;
                    case ("p"):
                        //todo: get player input, make match, add to history
                        //maybe delegate to a function in game
                        //COULD EVEN make an interface that handles ai and player moves. Ai inherits from it, player is own class
                        //reads lines from console like we expect here.
                        
                        break;
                }
            }
            
        }

        /// <summary>
        /// Check if the input is one of the expected ones, if not, return false so the program will ask again.
        /// </summary>
        /// <param name="input"> Any string</param>
        /// <returns> true if the input is "smart" or "random" otherwise false.</returns>
        protected static bool validateAiInput(String input)
        {
            bool isValid = false;
            //TODO: there's some lambda way to do return based on the result of a switch
            //return var switch 
            switch (input)
            {
                case ("smart"):
                    isValid = true;
                    break;
                case ("random"):
                    isValid = true;
                    break;
                /*
                //Implied
                default:
                    isValid = false;
                    break;
                */
            }

            return isValid;
        }



        private static bool validateAiInput(String input, List<String> validInputs)
        {
            if (validInputs.Contains(input))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
