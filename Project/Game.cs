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
        private Player playerOne;
        public int RoundNumber { get; private set; }
        private int[] diceValues = new int[Rulebook.AMOUNT_OF_DICE];
        #endregion

        #region Constructors
        public Game()
        {
            cup = new CupOfDice(Rulebook.AMOUNT_OF_DICE, Rulebook.MAX_DICE_VALUE);
            playerOne = new Player();
            StartNewTurn();
        }
        #endregion

        #region methods
        public void StartNewTurn()
        {
            cup.ResetDies();
            RoundNumber = 0;
        }

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

        public void LockDies(int value)
        {
            cup.DiceArray[value].IsLocked = true;
        }

        public int[] ReturnDiceValues()
        {
            for (int i = 0; i < diceValues.Length; i++)
            {
                diceValues[i] = cup.DiceArray[i].DiceValue;
            }
            return diceValues;
        }

        //returnerer pointantal for en given mængde møngde af terninger af samme værdi
        public int ReturnSinglesValues(int dicevalue)
        {
            int points = Rulebook.CalculateSinglesValue(dicevalue, cup.GetOccurencesOfDiceValue(dicevalue));       
            return points;
        }

        public int ReturnCombinationValues()
        {
            //TBD
            return 22;
        }
        #endregion

    }
}
