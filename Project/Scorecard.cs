using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Scorecard
    {
        #region fields and properties
        public int SumOfSingleValues { get; private set; }
        public int SumOfCombinedValues { get; private set; }
        public int Bonus { get; private set; }
        public int TotalSum { get; private set; }
        private bool allCombinationsUsed;
        private int[] scores;
        private bool[] scoresAreUsed;
        private const int COMBINATIONS = 15;

        #endregion

        #region constructor
        public Scorecard()
        {
            allCombinationsUsed = false;
            SumOfSingleValues = 0;
            Bonus = 0;
            TotalSum = 0;
            scores = new int[COMBINATIONS];
            scoresAreUsed = new bool[COMBINATIONS];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = 0;
            }

            for (int i = 0; i < scoresAreUsed.Length; i++)
            {
                scoresAreUsed[i] = false;
            }

        }
        #endregion

        #region methods
        private void setAllCombinationsUsed()
        {
            int count = 0;
            foreach (bool value in scoresAreUsed)
            {
                if (value == false)
                {
                    count += 1;
                }
            }

            if (count == 0)
            {
                allCombinationsUsed = true;
            }
            else
            {
                allCombinationsUsed = false;
            }
        }

        private void setSumOfSingleValues()
        {
            SumOfSingleValues = 0;

            for (int i = 0; i < 6; i++)
            {
                SumOfSingleValues += scores[i];
            }
        }

        private void setSumOfCombinedValues()
        {
            SumOfCombinedValues = 0;

            for (int i = 6; i < scores.Length; i++)
            {
                SumOfCombinedValues += scores[i];
            }
        }

        private void setBonus()
        {
            int sum = SumOfSingleValues;
            Bonus = Rulebook.GetBonus(sum);
        }

        private void setTotal()
        {
            TotalSum = SumOfSingleValues + SumOfCombinedValues + Bonus;
        }

        private void updateValues()
        {
            setSumOfSingleValues();
            setSumOfCombinedValues();
            setAllCombinationsUsed();
            setBonus();
            setTotal();
        }

        public void enterValue(int index, int value)
        {
            scores[index] = value;
            scoresAreUsed[index] = true;
            updateValues();
            setAllCombinationsUsed();
        }


        #endregion
    }
}
