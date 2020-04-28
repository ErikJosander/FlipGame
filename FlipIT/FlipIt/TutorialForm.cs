using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipIt
{
    public partial class TutorialForm : Form
    {
        // TODO - create a short tuturial
        public TutorialForm()
        {
            InitializeComponent();
            HideAllForms();
            BorderButton();
            MessageBox.Show("Click on the Roll Dice button");
            rollDiceButton.Enabled = true;
            rollDiceButton.Visible = true;
        }
        private void HideAllForms()
        {
            rollDiceButton.Visible = false;
            rollDiceButton.Enabled = false;
            evaluateButton.Visible = false;
            evaluateButton.Enabled = false;
            dicePictureOne.Visible = false;
            dicePictureTwo.Visible = false;
            scoreListBox.Enabled = false;
            scoreListBox.Visible = false;
            clickBoxGroup.Visible = false;
            clickBoxGroup.Enabled = false;
            programLabel.Visible = false;
            totalRollLabel.Visible = false;
            playersTurnLabel.Visible = false;
        }
     
        private void BorderButton()
        {            
            rollDiceButton.FlatStyle = FlatStyle.Flat;
            rollDiceButton.FlatAppearance.BorderColor = Color.Yellow;
            rollDiceButton.FlatAppearance.BorderSize = 1;
        }
        private void RemoveBorderButton()
        {
            rollDiceButton.FlatStyle = FlatStyle.Standard;
            rollDiceButton.FlatAppearance.BorderColor = Color.White;
            rollDiceButton.FlatAppearance.BorderSize = 0;
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            dicePictureOne.Visible = true;
            dicePictureTwo.Visible = true;
            totalRollLabel.Visible = true;
            totalRollLabel.Text = "Total Roll: 3";
            rollDiceButton.Enabled = false;
            RemoveBorderButton();
            MessageBox.Show("You rolled a total of three");
            MessageBox.Show("Now click on the white buttons");
        }
    }
}
