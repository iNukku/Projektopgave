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
        private int[] diceValues = new int[Rulebook.AMOUNT_OF_DICE]; // game skal vide fra rulebook hvor mange terninger, det beder bægeret om
        #endregion

        #region Constructors
        public Game()
        {
            cup = new CupOfDice(Rulebook.AMOUNT_OF_DICE);
            RoundNumber = 0;
        }
        #endregion

        #region methods
        public void StartNewRound()
        {
            if (RoundNumber != 3)
            {
                cup.Shuffle();
                RoundNumber++;       
            }
        }

        public void EndRound()
        {

        }

        public int[] ReturnDiceValues()
        {
            for (int i = 0; i < diceValues.Length; i++)
            {
                diceValues[i] = cup.DiceArray[i].DiceValue;
            }
            return diceValues;
        }

        //public int[] ReturnSinglesValues()
        //{

        //}
        #endregion

    }
}
