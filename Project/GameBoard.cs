using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface GameBoard
    {
        void Playername(string playername);
        void ScoreCard(Scorecard scorecard);
        void setRoundText(string text);
    }
}
