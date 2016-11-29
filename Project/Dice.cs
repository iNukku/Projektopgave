using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project
{
    public class Dice
    {
        #region fields and properties
        private static Random rng = new Random();
        public int DiceValue { get; private set; }
        public bool DiceIsLocked { get; private set; }
        #endregion

        #region Constructors
        public Dice()
        {
            RollDice();
        }
        #endregion

        #region methods
        //setter terningens værdi 
        public void RollDice()
        {
            if (DiceIsLocked == false)
            {
                DiceValue = rng.Next(1, Rulebook.MAX_DICE_VALUE + 1);
            }
        }
        #endregion
    }
}
