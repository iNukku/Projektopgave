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
        private int chosenButtonIndex;
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
                onepair_button, twopairs_button, three_same_button, four_same_button, full_house_button, small_str_button, large_str_button, chance_button, yatzy_button
            };
            diceLocks = new CheckBox[]{
                checkbox_dice_1, checkBox_dice_2, checkBox_dice_3, checkBox_dice_4, checkBox_dice_5
            };
            roll_button.Text = "Round 1";
        }
        #endregion

        #region methods and events
        private void roll_button_Click(object sender, EventArgs e)
        {
            if (theGame.RoundIsInProgress == true)
            {
                theGame.StartNewRound(UserLockedDies(), chooseCombination());
                displayDies(theGame.ReturnDiceValues());
                roll_button.Text = "Round: " + theGame.RoundNumber.ToString();
                displaySinglevalueCombinations();
                displayCombinedValues();

                if (theGame.RoundNumber == 4  || theGame.RoundIsInProgress == false)
                {
                    roll_button.Text = "Click for next turn";
                    showDiceLockbuttons();
                }
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

        private bool[] UserLockedDies()
        {
            bool[] diceWasLocked = new bool[diceLocks.Length];
            for (int i = 0; i < diceLocks.Length; i++)
            {
                if (diceLocks[i].Checked == false)
                {
                    diceWasLocked[i] = false;
                }
                else
                {
                    diceWasLocked[i] = true;
                    diceLocks[i].Visible = false;
                }
            }

            return diceWasLocked;
        }

        private void showDiceLockbuttons()
        {
            foreach (CheckBox box in diceLocks)
            {
                box.Visible = true;
                box.Checked = false;
            }
        }
        //Joins the two radiobutton arrays into one and evaluates if a button has been chosen - returns the index of the chosen button or -1 if evaluation failed
        private int chooseCombination()
        {
            RadioButton[] allRadiobuttons = new RadioButton[singleValueButtons.Length + multiValueButtons.Length];

            for (int i = 0; i < singleValueButtons.Length; i++)
            {
                allRadiobuttons[i] = singleValueButtons[i];
            }

            for (int i = singleValueButtons.Length; i < allRadiobuttons.Length; i++)
            {
                allRadiobuttons[i] = multiValueButtons[i - singleValueButtons.Length];
            }

            for (int i = 0; i < allRadiobuttons.Length; i++)
            {
                if (allRadiobuttons[i].Checked == true && allRadiobuttons[i].Enabled == true)
                {
                    allRadiobuttons[i].Enabled = false;
                    return i;
                }
            }
            return -1;
        }

        //send værdi til thegame og Lås værdi til scoresheet
        #endregion
    }
}
