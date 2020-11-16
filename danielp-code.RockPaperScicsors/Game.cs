using System;
using System.Collections.Generic;
using System.Text;
using danielp_code.RockPaperScicsors.Ai;

namespace danielp_code.RockPaperScicsors
{
    class Game
    {
        private readonly IAI ai;

        private LinkedList<Match> MatchHistory = new LinkedList<Match>();

        public Game(IAI ai)
        {
            this.ai = ai;
            MatchHistory = new LinkedList<Match>();
        }

        public void PlayMatch()
        {
            string input = "p";
            while (!Program.validateAiInput(input, Program.PlayerActions))
            {
                Console.WriteLine("Choose what to do");
                Console.WriteLine("q - quit the game.");
                Console.WriteLine("h - view history");
                Console.WriteLine("p - play again");
                input = Console.ReadLine();
                input = input.Trim().ToLower();
            }
        }

        Moves getPreviousPlayerMove()
        {
            //todo: check last move or default to something incase this is first match
            return Moves.PAPER;
        }


        //TODO: save games, or at least score history
    }
}
