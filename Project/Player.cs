using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Player
    {
        #region Fields and Properties
        public string Name { get; }
        public Scorecard PlayerScoreCard { get; private set; }
        #endregion

        #region constructors
        public Player()
        {
            Name = "Player One";
            PlayerScoreCard = new Scorecard();
        }

        public Player(string playername)
        {
            Name = playername;
            PlayerScoreCard = new Scorecard();
        }
        #endregion

        #region Methods
        public void setScoreCardValue(int indexvalue, int value)
        {
            PlayerScoreCard.enterValue(indexvalue, value);
        }
        #endregion

    }
}
