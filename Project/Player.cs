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
        public void SetScoreCardValue(int indexvalue, int value)
        {
            PlayerScoreCard.EnterValue(indexvalue, value);
        }

        public bool ScoreCardisFull()
        {
            if (PlayerScoreCard.AllCombinationsused == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ScorecardContainsSingleValue(int value)
        {
            if (PlayerScoreCard.CombinationUsed(value) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ScorecardContainsCombinedValue(int value)
        {
            if (PlayerScoreCard.CombinationUsed(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getScoreCardValue(int value)
        {
            return 2;
        }
        #endregion

    }
}
