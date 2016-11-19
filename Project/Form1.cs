using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dice myDice = new Dice();
            Dice myDice2 = new Dice();
            Dice mydice3 = new Dice();
            Dice myDice4 = new Dice();
            Dice myDice5 = new Dice();

            dice_label_1.Image = myDice.Get_dice_image();
            dice_label_2.Image = myDice2.Get_dice_image();
            dice_label_3.Image = mydice3.Get_dice_image();
            dice_label_4.Image = myDice4.Get_dice_image();
            dice_label_5.Image = myDice5.Get_dice_image();
        }
    }
}
