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
        public bool AllCombinationsused { get; private set; }
        private int[] scores;
        private bool[] scoresAreUsed;
        private const int COMBINATIONS = 15;
        private int sumOfSingleValues;
        private int sumOfCombinedValues;
        private int bonus;
        private int totalSum;

        #endregion

        #region constructor
        public Scorecard()
        {
            AllCombinationsused = false;
            sumOfSingleValues = 0;
            bonus = 0;
            totalSum = 0;
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
        //Evaluates if every score on scorecard is used and sets the AllCombinationsused property accordingly
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
                AllCombinationsused = true;
            }
            else
            {
                AllCombinationsused = false;
            }
        }

        private void setSumOfSingleValues()
        {
            sumOfSingleValues = 0;

            for (int i = 0; i < 6; i++)
            {
                sumOfSingleValues += scores[i];
            }
        }

        private void setSumOfCombinedValues()
        {
            sumOfCombinedValues = 0;

            for (int i = 6; i < scores.Length; i++)
            {
                sumOfCombinedValues += scores[i];
            }
        }

        private void setBonus()
        {
            bonus = Rulebook.GetBonus(sumOfSingleValues);
        }

        private void setTotal()
        {
            totalSum = sumOfSingleValues + sumOfCombinedValues + bonus;
        }

        //Updates every value influenced by the user choice of combination
        private void updateValues()
        {
            setSumOfSingleValues();
            setSumOfCombinedValues();
            setAllCombinationsUsed();
            setBonus();
            setTotal();
        }

        public void EnterValue(int index, int value)
        {
            scores[index] = value;
            scoresAreUsed[index] = true;
            updateValues();
        }

        public bool CombinationUsed(int value)
        {
            if (scoresAreUsed[value] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ReturnValue(int index)
        {
            return scores[index];
        }

        //Returns the values of single values entries on scorecard, bonus on scorecard, combinedvalues on scorecard and of the total on scorecard as an array
        public int[] ReturnsumsValues()
        {
            updateValues();
            int[] values = new int[]
            {
                sumOfSingleValues,
                bonus,
                sumOfCombinedValues,
                totalSum
            };

            return values;
        }
        #endregion
    }
}
