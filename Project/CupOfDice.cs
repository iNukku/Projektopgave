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
        public Dice[] diceArray = new Dice[Rulebook.AMOUNT_OF_DICE];
        #endregion

        #region Constructors
        public CupOfDice(int numberOfDice)
        {
            for (int i = 0; i < numberOfDice; i++)
            {
                diceArray[i] = new Dice();
            }
        }
        #endregion

        #region methods
        public void Shuffle()
        {
            foreach (Dice dice in diceArray)
            {
                dice.RollDice(); //images hører ikke til dice klasse! skal ligge i forms
            }
        }
        #endregion
    }
}
