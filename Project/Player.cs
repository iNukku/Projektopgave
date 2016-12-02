using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Player
    {
        public string Name { get; }
        public Scorecard PlayerScoreCard { get;  private set; }

        public Player()
        {
            Name = "Player One";
            PlayerScoreCard = new Scorecard();
        }
    }
}
