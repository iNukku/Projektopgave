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
        public int DiceValue { get; set; }
        private static Random rng = new Random();
        private bool diceIsRolled;
        private bool diceIsLocked;
        private Image[] diceImages = new Image[7] {
            Properties.Resources.dice_blank,
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6 };

        public bool DiceIsLocked
        {
            get { return diceIsLocked; }
            set { diceIsLocked = value; }
        }

        public bool DiceIsRolled
        {
            get { return diceIsRolled; }
            set { diceIsRolled = value; }
        }

        //setter terningens værdi og returnerer et image svarende til værdien
        public Image RollDice()
        {
            if (DiceIsLocked == false)
            {
                DiceValue = rng.Next(1, 7);
                diceIsRolled = true;
            }
            return diceImages[DiceValue];
        }
    }
}
