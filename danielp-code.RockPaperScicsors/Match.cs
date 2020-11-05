using System;
using System.Collections.Generic;
using System.Text;

namespace danielp_code.RockPaperScicsors
{
    class Match
    {
        public Moves playerMove { get; }
        public Moves AIMove { get; }
        public MatchResult playerWon
        {
            get
            {
                if(playerMove == AIMove)
                {
                    return MatchResult.TIE;
                }
                else
                {
                    //TODO: CONSIDER MAKING EACH OPTION IT'S OWN CLASS THAT STORES WHAT IT BEATS, or at least a class that
                    //tracks it's enum and the corasponding things it beats. NOTE: only need beats or looses to, IF we don't track
                    //ties
                    switch (playerMove)
                    {
                        case Moves.ROCK:
                            //can't be rock/rock
                            //options paper or sciscors
                            if(AIMove == Moves.PAPER)
                            {
                                //AI: rock. Player:paper
                                return MatchResult.WIN;
                            } else
                            {
                                return MatchResult.LOSS;
                            }
                            break;
                        case Moves.PAPER:
                            //can't be paper/paper
                            if(AIMove == Moves.ROCK)
                            {
                                //AI: rock, player: paper
                                return MatchResult.WIN;
                            } else
                            {
                                return MatchResult.LOSS;
                            }
                            break;
                        case Moves.SCISSORS:
                            if(AIMove == Moves.PAPER)
                            {
                                //AI: paper, Plater: scissors
                                return MatchResult.WIN;
                            } else
                            {
                                return MatchResult.LOSS;
                            }
                            break;
                        //so the compiler will like me
                        default:
                            return MatchResult.TIE;
                    }
                }
            }
        }

        public Match (Moves player, Moves ai)
        {
            playerMove = player;
            AIMove = ai;
        }
    }
}
