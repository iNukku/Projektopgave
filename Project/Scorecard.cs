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
        //private Dictionary<string, int> scores = new Dictionary<string, int>();
        //private Dictionary<string, bool> scoresAreUsed = new Dictionary<string, bool>();

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

            //scores["ones"] = 0;
            //scores["twos"] = 0;
            //scores["threes"] = 0;
            //scores["fours"] = 0;
            //scores["fives"] = 0;
            //scores["sixes"] = 0;
            //scores["one Pair"] = 0;
            //scores["two pair"] = 0;
            //scores["three of Kind"] = 0;
            //scores["four of kind"] = 0;
            //scores["little straight"] = 0;
            //scores["big straight"] = 0;
            //scores["full house"] = 0;
            //scores["chance"] = 0;
            //scores["yatzy"] = 0;

            //scoresAreUsed["ones"] = false;
            //scoresAreUsed["twos"] = false;
            //scoresAreUsed["threes"] = false;
            //scoresAreUsed["fours"] = false;
            //scoresAreUsed["fives"] = false;
            //scoresAreUsed["sixes"] = false;
            //scoresAreUsed["one pair"] = false;
            //scoresAreUsed["two pair"] = false;
            //scoresAreUsed["three of kind"] = false;
            //scoresAreUsed["four of kind"] = false;
            //scoresAreUsed["little straight"] = false;
            //scoresAreUsed["big straight"] = false;
            //scoresAreUsed["full house"] = false;
            //scoresAreUsed["chance"] = false;
            //scoresAreUsed["yatzy"] = false;
        }
        #endregion

        #region methods

        //private void setAllCombinationsUsed()
        //{
        //    int count = 0;
        //    foreach (var value in scoresAreUsed.Values)
        //    {
        //        if (value == false)
        //        {
        //            count += 1;
        //        }
        //    }

        //    if (count == 0)
        //    {
        //        allCombinationsUsed = true;
        //    }
        //    else
        //    {
        //        allCombinationsUsed = false;
        //    }
            
        //}

        //private void setSumOfSingleValues()
        //{
        //    SumOfSingleValues = scores["ones"] + scores["twos"] + scores["threes"] + scores["fours"] + scores["fives"] + scores["sixes"];
        //}

        //private void setSumOfCombinedValues()
        //{
        //    SumOfCombinedValues = scores["one pair"] + scores["two pair"] + scores["three of kind"] + scores["four of kind"] + scores["little straight"] +
        //        scores["big straight"] + scores["full house"] + scores["chance"] + scores["yatzy"];
        //}

        //private void setTotalSum()
        //{
        //    TotalSum = 0;

        //    TotalSum += Bonus;

        //    foreach (var value in scores.Values)
        //    {
        //        TotalSum += value;
        //    }
        //}

        //public bool ScoreCardIsFull()
        //{
        //    setAllCombinationsUsed();
        //    return allCombinationsUsed;
        //}
        #endregion
    }
}
