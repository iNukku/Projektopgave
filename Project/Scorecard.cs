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
        private int ones;

        public int Ones
        {
            get { return ones; }
            set { ones = value; }
        }

        #endregion

        #region constructor
        #endregion

        #region methods
        public bool CombinationIsLocked()
        {
            //TBD
            return false;
        }
        #endregion
    }
}
