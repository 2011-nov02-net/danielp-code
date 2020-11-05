using System;
using System.Collections.Generic;
using System.Text;

namespace danielp_code.RockPaperScicsors.Ai
{
    public interface IAI
    {
        Moves GetMove(Moves OpponenPrevMove);
    }
}
