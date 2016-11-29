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
        public Dice[] DiceArray;
        // gør private ?
        #endregion

        #region Constructors
        public CupOfDice(int value)
        {
            DiceArray = new Dice[value];
            for (int i = 0; i < DiceArray.Length; i++)
            {
                DiceArray[i] = new Dice();
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

        public int OccurencesOfDiceValue(int value)
        {
            int amount = 0;
            foreach (Dice dice in DiceArray)
            {
                if (dice.DiceValue == value)
                {
                    amount++;
                }
            }
            return amount;
        }
        #endregion
    }
}
