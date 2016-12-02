using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Rulebook
    {
        #region Fields and properties
        public const int AMOUNT_OF_DICE = 5;
        public const int MIN_DICE_VALUE = 1;
        public const int MAX_DICE_VALUE = 6;
        public const int MAX_ROUNDS = 3;
        private const int MIN_SINGLEVALUES_FOR_BONUS = 63;
        private const int BONUS = 50;
        private const int YATZEE = 50;
        #endregion

        #region methods
        public static int CalculateSinglesValue(int value, int occurance)
        {
            int totalValue = value * occurance;
            return totalValue;
        }

        public static int GetOnePairValue(int value, int Occurance)
        {
            //TBI
            return 0;
        }

        public static int GetBonus(int sumOfsingleDiceValues)
        {
            if (sumOfsingleDiceValues >= MIN_SINGLEVALUES_FOR_BONUS)
            {
                return BONUS;
            }
            else
            {
                return 0;
            }
        }

        
        #endregion
    }
}
