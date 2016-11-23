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
        private Label[] diceLabels;
        
        public Form1()
        {
            InitializeComponent();
            diceLabels = new Label[]
            {
                dice_label_1, dice_label_2, dice_label_3, dice_label_4, dice_label_5
            };

        }
        
        private void roll_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceLabels.Length; i++)
            {
                diceLabels[i].Image = cup.diceArray[i].RollDice(); // skal flyttes til anden klasse (game)
            }
        }
    }
}
