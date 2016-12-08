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
        private const int YATZY = 50;
        #endregion

        #region methods
        public static int GetSinglesValue(int value, int occurance)
        {
            int totalValue = (value + 1) * occurance;
            return totalValue;
        }

        public static int GetOnePairValue(int[] value)
        {
            int total = 0;
            Array.Sort(value);
            Array.Reverse(value);
            for (int i = 0; i < value.Length -1; i++)
            {
                if (value[i] == value[i+1])
                {
                    total = value[i] + value[i + 1];
                    return total;
                }
            }
            return total;
        }

        public static int GetTwoPairValue(int[] values)
        {
            int startpairValue = 0;
            int endPairValue = 0;

            Array.Sort(values);

            if (values[0] == values[1] || values[1] == values[2])
            {
                startpairValue = values[1] * 2;
            }

            if (values[3] == values[4])
            {
                endPairValue = values[3] * 2;
            }

            if (values[2] == values[3] && values[1] != values[3])
            {
                endPairValue = values[3] * 2;
            }

            if (startpairValue != 0 && endPairValue != 0)
            {
                return startpairValue + endPairValue;
            }
            else
            {
                return 0;
            }
            

        }

        public static int GetThreeOfAKindValue(int[] values)
        {
            for (int i = 0; i < values.Length -2; i++)
            {
                if (values[i] == values[i +1] && values[i] == values[i + 2])
                {
                    return values[i] * 3;
                }
            }
            return 0;
        }

        public static int GetFourOfAKindValue(int[] values)
        {
            for (int i = 0; i < values.Length - 3; i++)
            {
                if (values[i] == values[i + 1] && values[i] == values[i + 2] && values[i] == values[i + 3])
                {
                    return values[i] * 4;
                }
            }
            return 0;
        }
        
        public static int GetFullHouseValue(int[] values)
        {
            bool containsTwoPairsAtEnds = false;
            bool containsOneTripple = false;

            Array.Sort(values);

            if (values[0] == values[1] && values[4] == values[3])
            {
                containsTwoPairsAtEnds = true;
            }
            if (values[2] == values[0] || values[2] == values[4])
            {
                containsOneTripple = true;
            }

            if (containsTwoPairsAtEnds && containsOneTripple && values[1] != values[4])
            {
                return values.Sum();
            }
            else
            {
                return 0;
            }
        }

        public static int GetSmallStraightValue(int[] values)
        {
            Array.Sort(values);
            bool hasSmallStraight = true;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == i +1 && hasSmallStraight == true)
                {
                    hasSmallStraight = true;
                }
                else
                {
                    hasSmallStraight = false;
                }
            }

            if (hasSmallStraight == true)
            {
                return 15;
            }
            else
            {
                return 0;
            }
        }

        public static int GetLargeStraightValue(int[] values)
        {
            Array.Sort(values);
            bool hasLargeStraight = true;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == i + 2 && hasLargeStraight == true)
                {
                    hasLargeStraight = true;
                }
                else
                {
                    hasLargeStraight = false;
                }
            }

            if (hasLargeStraight == true)
            {
                return 20;
            }
            else
            {
                return 0;
            }
        }

        public static int GetYatzeeValue(int[] values)
        {
            Array.Sort(values);

            if (values[0] == values[values.Length -1])
            {
                return YATZY;
            }
            else
            {
                return 0;
            }
        }

        public static int GetChanceVValue(int[] values)
        {
            int total = 0;
            foreach (int value in values)
            {
                total += value;
            }
            return total;
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
