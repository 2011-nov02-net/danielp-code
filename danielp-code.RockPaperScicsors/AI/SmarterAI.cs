using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using danielp_code.RockPaperScicsors.Ai;

namespace danielp_code.RockPaperScicsors.AI
{
    /// <summary>
    /// Assume the opponent won't choose same thing twice
    /// </summary>
    class SmarterAI : IAI
    {
        private Random rng = new Random();

        public Moves GetMove(Moves opponenPrevMove)
        {
            Moves choice = Moves.PAPER;

            switch (opponenPrevMove)
            {
                case Moves.ROCK:
                    choice = new List<Moves> { Moves.ROCK, Moves.SCISSORS}
                    [rng.Next(2)];
                    break;
                case Moves.PAPER:
                    choice = new List<Moves> { Moves.PAPER, Moves.ROCK }
                    [rng.Next(2)];
                    break;
                case Moves.SCISSORS:
                    choice = new List<Moves> { Moves.SCISSORS, Moves.PAPER }
                    [rng.Next(2)];
                    break;
            }

            return choice;
        }
    }
}
