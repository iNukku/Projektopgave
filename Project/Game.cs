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
        public bool RoundIsInProgress { get; private set; }
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
            RoundNumber = 1;
            RoundIsInProgress = true;
        }

        public void StartNewRound(bool[] values, int chosenCombination)
        {
            if (RoundNumber <= Rulebook.MAX_ROUNDS && chosenCombination == -1)
            {
                LockDies(values);
                cup.Shuffle();
                RoundNumber++;
            }else
            {
                endRound(chosenCombination);
            }
        }

        //låser låste terninger op og evaluerer kombination
        private void endRound()
        {

        }

        private void endRound(int indexOfChosenCombination)
        {
            //Brug index til at sætte kombination
            cup.ResetDies();
            RoundIsInProgress = false;
        }

        public void setCombination()
        {
            //modtag information fra form og sæt værdi i player.scorecard
        }

        private void LockDies(bool[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == true)
                {
                    cup.DiceArray[i].IsLocked = true;
                }
            }
            //cup.DiceArray[value].IsLocked = true;
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
            int points = Rulebook.GetSinglesValue(dicevalue, cup.GetOccurencesOfDiceValue(dicevalue));       
            return points;
        }

        public int ReturnCombinationValues(int indexvalue) //lav check for at se om værdi er i Scorecard - if so: returner scorecardværdi
        {
            int[] values = new int[]
            {
                Rulebook.GetOnePairValue(diceValues),
                Rulebook.GetTwoPairValue(diceValues),
                Rulebook.GetThreeOfAKindValue(diceValues),
                Rulebook.GetFourOfAKindValue(diceValues),
                Rulebook.GetFullHouseValue(diceValues),
                Rulebook.GetSmallStraightValue(diceValues),
                Rulebook.GetLargeStraightValue(diceValues),
                Rulebook.GetChanceVValue(diceValues),
                Rulebook.GetYatzeeValue(diceValues)

            };
            return values[indexvalue];
        }

        #endregion

    }
}
