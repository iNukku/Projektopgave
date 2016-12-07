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
        private int[] diceValues = new int[Rulebook.AMOUNT_OF_DICE];
        public int RoundNumber { get; private set; }
        public bool RoundIsInProgress { get; private set; }
        public bool GameHasEnded { get; private set; }
        #endregion

        #region Constructors
        public Game()
        {
            cup = new CupOfDice(Rulebook.AMOUNT_OF_DICE, Rulebook.MAX_DICE_VALUE);
            playerOne = new Player();
            StartNewTurn();
            RoundNumber = 0;
        }
        #endregion

        #region methods
        public void EvaluateRoll(bool[] values, int chosenCombination)
        {
            //Checks if the combination chosen by the user causes the game to end - else end round
            if (chosenCombination != -1)
            {
                setCombination(chosenCombination);
                checkScoreCardStatus();

                if (GameHasEnded == true)
                {
                    endGame();
                }
                else
                {
                    endRound();
                }
            }

            //checks if round needs to end
            if (RoundNumber < Rulebook.MAX_ROUNDS && chosenCombination == -1)
            {
                RoundIsInProgress = true;
                StartNewRound(values);
            }
            else if (RoundNumber == Rulebook.MAX_ROUNDS && chosenCombination == -1)
            {
                endRound();
            }
            else
            {
                StartNewTurn();
            }
        }

        public int[] ReturnDiceValues()
        {
            for (int i = 0; i < diceValues.Length; i++)
            {
                diceValues[i] = cup.DiceArray[i].DiceValue;
            }
            return diceValues;
        }

        //checks if scorecard already contains a value for the combinatioln of singlevaluedies - if so returns value from scorecard. Otherwise returns value by asking rulebook
        public int ReturnSinglesValues(int dicevalue)
        {
            if (playerOne.ScorecardContainsSingleValue(dicevalue))
            {
                return playerOne.getScoreCardValue(dicevalue);
            }
            else
            {
                int points = Rulebook.GetSinglesValue(dicevalue, cup.GetOccurencesOfDiceValue(dicevalue));
                return points;
            }
        }

        //checks if scorecard already contains combination - in this case it returns scorecardvalue. Otherwise uses rulebook to determnine value for the combination
        public int ReturnCombinationValues(int indexvalue)
        {
            if (playerOne.ScorecardContainsCombinedValue(indexvalue + 6))
            {
                return playerOne.getScoreCardValue(indexvalue + 6);
            }
            else
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
        }

        //Returns the sum of singlevalue combinations, the bonus and also the sum of multivalue combinations and the total score
        public int[] ReturnSumsAndBonuses()
        {
            return playerOne.PlayerScoreCard.ReturnsumsValues();
        }


        private void StartNewTurn()
        {
            RoundNumber = 1;
            RoundIsInProgress = true;
            cup.Shuffle();
        }

        private void StartNewRound(bool[] values)
        {
            LockDies(values);
            cup.Shuffle();
            RoundNumber++;
        }

        private void endRound()
        {
            cup.ResetDies();
            RoundIsInProgress = false;
        }

        private void endGame()
        {
            RoundIsInProgress = false;
            GameHasEnded = true;
        }
        
        private void setCombination(int value)
        {
            if (value <= 5)
            {
                playerOne.SetScoreCardValue(value, ReturnSinglesValues(value));
            }
            else
            {
                playerOne.SetScoreCardValue(value, ReturnCombinationValues(value - 6));
            }
        }

        private void checkScoreCardStatus()
        {
            if (playerOne.ScoreCardisFull() == true)
            {
                GameHasEnded = true;
            }
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
        }
        #endregion
    }
}
