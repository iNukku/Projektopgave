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
        private CheckBox[] diceLocks;
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
            diceLocks = new CheckBox[]{
                checkbox_dice_1, checkBox_dice_2, checkBox_dice_3, checkBox_dice_4, checkBox_dice_5
            };
        }
        #endregion

        #region methods and events
        private void roll_button_Click(object sender, EventArgs e)
        {
            if (theGame.RoundNumber < 3)
            {
                lockDies();
                theGame.StartNewRound();
                displayDies(theGame.ReturnDiceValues());
                roll_button.Text = "Roll: " + (theGame.RoundNumber + 1).ToString();
                displaySinglevalueCombinations();
                displayCombinedValues();
                chooseSingleValueCombination();         
            }
            else
            {
                theGame.EndRound();
                roll_button.Text = "Round ended";
            }
        }

        private void displayDies(int[] diceValues)
        {
            for (int i = 0; i < diceLabels.Length; i++)
            {
                diceLabels[i].Image = diceImages[diceValues[i]];
            }
        }

        private void displaySinglevalueCombinations()
        {
            for (int i = 0; i < singleValueButtons.Length; i++)
            {
                if (singleValueButtons[i].Enabled == true)
                {
                    singleValueButtons[i].Text = theGame.ReturnSinglesValues(i + 1).ToString();
                }
            }
        }

        private void displayCombinedValues()
        {
            for (int i = 0; i < multiValueButtons.Length; i++)
            {
                multiValueButtons[i].Text = theGame.ReturnCombinationValues(i).ToString();
            }
        }

        private void lockDies()
        {
            for (int i = 0; i < diceLocks.Length; i++)
            {
                if (diceLocks[i].Checked)
                {
                    theGame.LockDies(i);
                }
            }
        }

        private void chooseSingleValueCombination() //det bør være game,d er gør dette -> tjek evt. med game for at enable = false
        {
            foreach (RadioButton button in singleValueButtons)
            {
                if (button.Checked == true && button.Enabled == true)
                {
                    button.Enabled = false;
                    button.Text = "chosen";
                    button.BackColor = Color.Bisque;
                }
            }
        }
        #endregion
    }
}
