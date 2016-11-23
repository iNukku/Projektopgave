using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CupOfDice
    {
        private const int AMOUNT_OF_DICE = 5;
        public Dice[] diceArray = new Dice[AMOUNT_OF_DICE];

        public CupOfDice()
        {
            for (int i = 0; i < AMOUNT_OF_DICE; i++)
            {
                diceArray[i] = new Dice();
            }
        }

        public void Shuffle()
        {
            foreach (Dice dice in diceArray)
            {
                    dice.RollDice(); //images hører ikke til dice klasse! skal ligge i forms
            }
        }

    }
}
