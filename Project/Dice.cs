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
        private int maxValue;
        public int DiceValue { get; private set; }
        public bool IsLocked { get; private set; }
        #endregion

        #region Constructors
        public Dice(int value)
        {
            maxValue = value;
            RollDice();
        }
        #endregion

        #region methods
        //setter terningens værdi 
        public void RollDice()
        {
            if (IsLocked == false)
            {
                DiceValue = rng.Next(1, maxValue + 1);
            }
        }
        #endregion
    }
}
