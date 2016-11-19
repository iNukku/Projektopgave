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
            dice_label_1.Text = myDice.Dice_value.ToString();
            dice_label_2.Text = myDice2.Dice_value.ToString();
            dice_label_3.Text = mydice3.Dice_value.ToString();
            dice_label_4.Image = mydice3.getDiceImage(0);
        }
    }
}
