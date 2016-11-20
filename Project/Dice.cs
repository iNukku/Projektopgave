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
        public int Dice_value { get; }

        private static readonly Random rng = new Random();
        private Image[] dice_images = new Image[7] {
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

        //returnerer et image med repræsentation af Dice_value
        public Image Get_dice_image()
        {
            if (dice_images[Dice_value] != null)
            {
                return dice_images[Dice_value];
            }
            else
            {
                throw new Exception("Picture files can not be found");
            }
        }
    }
}
