using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project
{
    class Dice
    {       
        private int diceValue;
        private Image diceImage;
        private static Random rng = new Random();
        private bool diceIsLocked;
        private Image[] diceImages = new Image[7] {
            Properties.Resources.dice_blank,
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6 };

        public int DiceValue
        {
            get { return diceValue; }
        }

        public Image DiceImage
        {
            get { return diceImage; }
        }

        public bool DiceIsLocked
        {
            get { return diceIsLocked; }
            set { diceIsLocked = value; }
        }

        //setter terningens værdi og vælger terningens billede
        public void RollDice()
        {
            if (DiceIsLocked == false)
            {
                diceValue = rng.Next(1, 7);
            }
            diceImage = diceImages[DiceValue];
        }
    }
}
