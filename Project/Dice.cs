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
        private static Random rng = new Random();
        public int Dice_value { get; }
        private Image[] dice_images = new Image[] {
            Properties.Resources.dice_blank,
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6 };

        public Dice()
        {
            Dice_value = rng.Next(1, 7);
        }
    }
}
