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
        CupOfDice cup = new CupOfDice();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void roll_button_Click(object sender, EventArgs e)
        {     
            dice_label_1.Image = cup.diceArray[0].RollDice();
            dice_label_2.Image = cup.diceArray[1].RollDice();
            dice_label_3.Image = cup.diceArray[2].RollDice();
            dice_label_4.Image = cup.diceArray[3].RollDice();
            dice_label_5.Image = cup.diceArray[4].RollDice();
        }

    }
}
