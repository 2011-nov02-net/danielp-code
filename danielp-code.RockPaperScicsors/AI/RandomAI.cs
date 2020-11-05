using System;
using System.Collections.Generic;
using System.Text;
using danielp_code.RockPaperScicsors.Ai;

namespace danielp_code.RockPaperScicsors.AI
{
    class RandomAI : IAI
    {

        private Random rng = new Random();
        private static readonly List<Moves> moves = new List<Moves> { Moves.PAPER, Moves.ROCK, Moves.SCISSORS };

        public Moves GetMove(Moves OpponenPrevMove)
        {
            return moves[rng.Next(3)];
        }
    }
}
