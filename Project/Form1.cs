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
        private RadioButton[] singleValueLabels;
        private RadioButton[] multiValueButtons;
        private Game theGame;
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
            singleValueLabels = new RadioButton[]
            {
                ones_button, twos_button, threes_button, fours_button, fives_button, sixes_button
            };
            multiValueButtons = new RadioButton[]
            {
                onepair_button, twopairs_button, three_same_button, four_same_button, full_house_button, small_str_button, large_str_button, yatzy_button, chance_button
            };
            theGame = new Game();
        }
        #endregion

        #region methods
        private void roll_button_Click(object sender, EventArgs e)
        {
            setLabelImages(theGame.ReturnDiceValues());
        }
        private void setLabelImages(int[] diceValues)
        {
            for (int i = 0; i < diceLabels.Length; i++)
            {
                diceLabels[i].Image = diceImages[diceValues[i]];
            }
        }
        #endregion
    }
}
