using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CupOfDice
    {
        #region fields and properties
        public Dice[] DiceArray { get; private set; }
        #endregion

        #region Constructors
        public CupOfDice(int amount, int maxValue)
        {
            DiceArray = new Dice[amount];
            for (int i = 0; i < DiceArray.Length; i++)
            {
                DiceArray[i] = new Dice(maxValue);
            }
        }
        #endregion

        #region methods
        public void Shuffle()
        {
            foreach (Dice dice in DiceArray)
            {
                dice.RollDice(); 
            }
        }

        public void ResetDies()
        {
            foreach (Dice dice in DiceArray)
            {
                dice.IsLocked = false;
            }
        }

        public int GetOccurencesOfDiceValue(int value)
        {
            int amount = 0;

            foreach (Dice dice in DiceArray)
            {
                if (dice.DiceValue == value + 1)
                {
                    amount++;
                }
            }
            return amount;
        }
        #endregion
    }
}
