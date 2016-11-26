using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Game
    {
        #region fields and properties
        private CupOfDice cup;
        public int RoundNumber { get; private set; }
        #endregion

        #region Constructors
        public Game()
        {
            cup = new CupOfDice(Rulebook.AMOUNT_OF_DICE);
            RoundNumber = 1;
        }
        #endregion

        #region methods
        public void StartNewRound()
        {
            if (RoundNumber != 3)
            {
                cup.Shuffle();
            }
        }

        public void RoundEnded()
        {

        }

        public int[] ReturnDiceValues()
        {
            int[] values = new int[Rulebook.AMOUNT_OF_DICE];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = cup.diceArray[i].DiceValue;
            }
            return values;
        }
        #endregion

    }
}
