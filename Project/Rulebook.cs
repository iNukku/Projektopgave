using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Rulebook
    {
        public const int AMOUNT_OF_DICE = 5;
        public const int MAX_ROUNDS = 3;

        public static int GetOnes(int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                if (value == 1)
                {
                    sum += value;
                }
            }
            return sum;
        }
    }
}
