using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        #region fields and properties
        private Label[] diceLabels;
        private RadioButton[] singleValueButtons;
        private RadioButton[] multiValueButtons;
        private Game theGame = new Game();
        private Image[] diceImages = new Image[] {
            Properties.Resources.dice_blank,
            Properties.Resources.dice_1,
            Properties.Resources.dice_2,
            Properties.Resources.dice_3,
            Properties.Resources.dice_4,
            Properties.Resources.dice_5,
            Properties.Resources.dice_6 };
        #endregion

        #region constructor
        public Form1()
        {
            InitializeComponent();
            diceLabels = new Label[]
            {
                dice_label_1, dice_label_2, dice_label_3, dice_label_4, dice_label_5
            };
            singleValueButtons = new RadioButton[]
            {
                ones_button, twos_button, threes_button, fours_button, fives_button, sixes_button
            };
            multiValueButtons = new RadioButton[]
            {
                onepair_button, twopairs_button, three_same_button, four_same_button, full_house_button, small_str_button, large_str_button, yatzy_button, chance_button
            };
        }
        #endregion

        #region methods
        private void roll_button_Click(object sender, EventArgs e)
        {
            if (theGame.RoundNumber < 3)
            {
                theGame.StartNewRound();
                showDices(theGame.ReturnDiceValues());
                roll_button.Text = "Roll: " + (theGame.RoundNumber + 1).ToString();
                ones_button.Text = "hej";
                // set roll button til disabled indtil en radiobutton er klicked (event)
            }
            else
            {
                theGame.EndRound();
                roll_button.Text = "Round ended";
            }


        }

        private void showDices(int[] diceValues)
        {
            for (int i = 0; i < diceLabels.Length; i++)
            {
                diceLabels[i].Image = diceImages[diceValues[i]];
            }
        }
        #endregion
    }
}
