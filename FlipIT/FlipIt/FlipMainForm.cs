using FlipGameDataBase.Data;
using FlipGameDataBase.Models;
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
    public partial class FlipMainForm : Form
    {
        private static Random rnd = new Random();
        private List<PlayersAndScore> playersThisTurn = new List<PlayersAndScore>();
        private List<ButtonToChoose> choiceButton = new List<ButtonToChoose>();
        private List<Button> formButtons = new List<Button>();
        private int totalRoll = 0;
        private List<int> numbersTakenThisTurn = new List<int>();
        private PlayersAndScore whoIsPlaying = new PlayersAndScore();
        private bool turnDone = false;

        public FlipMainForm(List<Person> players)
        {
            InitializeComponent();
            totalRollLabel.Text = "";
            playersThisTurn = ConvertPersonsToPlayers(players);
            whoIsPlaying = playersThisTurn[0];
            SeedButtonList();
            SeedChoiceButton();
            turnDone = false;
            ResetGame();
            Mediator.GetInstance().ButtonPressed += (s, e) =>
            {
                BindColorData(e.Button);
            };
            Mediator.GetInstance().TurnFinished += (s, y) =>
            {
                EvaluateIfturnFinnished();
            };
        }
        private List<PlayersAndScore> ConvertPersonsToPlayers(List<Person> people)
        {
            List<PlayersAndScore> output = new List<PlayersAndScore>();
            foreach (Person person in people)
            {
                PlayersAndScore player = new PlayersAndScore();
                player.Name = person.Name;
                player.Score = 0;
                output.Add(player);
            }
            return output;
        }
        private void EvaluateIfturnFinnished()
        {
            int count = 0;
            foreach (var n in numbersTakenThisTurn)
            {
                count += n;
            }
            if (count == totalRoll)
            {
                foreach (var x in choiceButton)
                {
                    if (numbersTakenThisTurn.Contains(x.Number))
                    {
                        choiceButton[x.Number - 1].Taken = true;
                    }
                }
                numbersTakenThisTurn.Clear();
                ColorOfButtons();
                evaluateButton.Enabled = false;
                rollDiceButton.Enabled = true;
            }
            else
            {
                numbersTakenThisTurn.Clear();
                foreach (var x in choiceButton)
                {
                    x.TakenOneTurn = false;
                }
                ColorOfButtons();
            }
        }
        private void BindColorData(ButtonToChoose button)
        {
            if (!button.Taken)
            {
                if (!button.TakenOneTurn)
                {
                    button.TakenOneTurn = true;
                    numbersTakenThisTurn.Add(button.Number);
                    ColorOfButtons();
                }
                else
                {
                    button.TakenOneTurn = false;
                    numbersTakenThisTurn.Remove(button.Number);
                    ColorOfButtons();
                }
            }
        }
        private int ReturnTurnScore()
        {
            int output = 0;
            foreach (var b in choiceButton)
            {
                if (!b.Taken)
                {
                    output += b.Number;
                }
            }
            return output;
        }
        private void ResetGame()
        {
            playersTurnLabel.Text = whoIsPlaying.Name;
            dicePictureOne.Visible = false;
            dicePictureTwo.Visible = false;
            //SeedButtonList();
            SeedChoiceButton();
            totalRollLabel.Text = "";
            WireUpLists();
            ColorOfButtons();
            DisableAllButtons();
            evaluateButton.Enabled = false;
            rollDiceButton.Enabled = true;
        }
        private void DisableAllButtons()
        {
            foreach (var b in formButtons)
            {
                b.Enabled = false;
            }
        }
        private void EnableAllButtons()
        {
            foreach (var b in formButtons)
            {
                b.Enabled = true;
            }
        }
        private void SeedChoiceButton()
        {
            if(choiceButton.Count == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    var button = new ButtonToChoose();
                    button.Number = i;
                    //button.Taken = false;
                    choiceButton.Add(button);
                }
            }       
            else
            {
                foreach(var b in choiceButton)
                {
                    b.Taken = false;
                    b.TakenOneTurn = false;
                }
            }
           
        }
        private void SeedButtonList()
        {
            formButtons.Clear();
            formButtons.Add(button1);
            formButtons.Add(button2);
            formButtons.Add(button3);
            formButtons.Add(button4);
            formButtons.Add(button5);
            formButtons.Add(button6);
            formButtons.Add(button7);
            formButtons.Add(button8);
            formButtons.Add(button9);
        }
        private void WireUpLists()
        {
            scoreListBox.DataSource = null;
            scoreListBox.DataSource = playersThisTurn;
            scoreListBox.DisplayMember = "Display";
        }
        private void ColorOfButtons()
        {   
            // TODO - choiceButton list not working correctly every second game
            int i = 0;
            foreach (Button b in formButtons)
            {
                if (choiceButton[i].Taken)
                {
                    b.BackColor = Color.Gold;
                }
                else if (choiceButton[i].TakenOneTurn)
                {
                    b.BackColor = Color.Green;
                }
                else if (!choiceButton[i].TakenOneTurn)
                {
                    b.BackColor = Color.White;
                }
                i += 1;
            }
        }
        private void DiceRoll()
        {
            List<string> output = new List<string>();
            output.Clear();
            int count = 1;
            while (count <= 2)
            {
                int diceRollOne = rnd.Next(1, 6 + 1);
                switch (diceRollOne)
                {
                    case (1):
                        output.Add(Pictures.diceSideOne);
                        break;
                    case (2):
                        output.Add(Pictures.diceSideTwo);
                        break;
                    case (3):
                        output.Add(Pictures.diceSideThree);
                        break;
                    case (4):
                        output.Add(Pictures.diceSideFour);
                        break;
                    case (5):
                        output.Add(Pictures.diceSideFive);
                        break;
                    case (6):
                        output.Add(Pictures.diceSideSix);
                        break;
                }
                count++;
            }
            dicePictureOne.Visible = true;
            dicePictureTwo.Visible = true;
            dicePictureOne.Image = Image.FromFile(output[0]);
            dicePictureTwo.Image = Image.FromFile(output[1]);
            var intDiceRolls = ConvertStringToInt(output);
            totalRoll = intDiceRolls[0] + intDiceRolls[1];
            totalRollLabel.Visible = true;
            totalRollLabel.Text = $"Total roll: {totalRoll}";
            evaluateButton.Enabled = true;
        }
        private List<int> ConvertStringToInt(List<string> diceRoll)
        {
            List<int> output = new List<int>();
            foreach (var s in diceRoll)
            {
                if (s == Pictures.diceSideOne) { output.Add(1); }
                if (s == Pictures.diceSideTwo) { output.Add(2); }
                if (s == Pictures.diceSideThree) { output.Add(3); }
                if (s == Pictures.diceSideFour) { output.Add(4); }
                if (s == Pictures.diceSideFive) { output.Add(5); }
                if (s == Pictures.diceSideSix) { output.Add(6); }
            }
            return output;
        }   
        private void FlipMainWindow_Load(object sender, EventArgs e)
        {

        }
        private void scoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void NextPlayersTurn()
        {
            whoIsPlaying.Score += ReturnTurnScore();
            int whoIndex = playersThisTurn.IndexOf(whoIsPlaying);
            // Check if last turn
            try
            {               
                whoIsPlaying = playersThisTurn[whoIndex + 1];
                MessageBox.Show("Next player");
                evaluateButton.Text = "End Turn";
                turnDone = false;
                ResetGame();
                WireUpLists();             
            }
            catch (ArgumentOutOfRangeException)
            {               
                SaveGameToDataBase(playersThisTurn);
                ResetGame();
                MessageBox.Show("Game done");           
                playersThisTurn.Clear();
                turnDone = false;
                this.Close();
            }           
        }
        /// <summary>
        /// The dice roll button-click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollDiceButton_Click_1(object sender, EventArgs e)
        {      
            EnableAllButtons();
            DiceRoll();
            ColorOfButtons();
            //Return true if no options after diceroll
            if (IfNoAvailibleNumbers())
            {
                rollDiceButton.Enabled = false;
                turnDone = true;
                evaluateButton.Text = "Finnish";
            }
            else
            {             
                rollDiceButton.Enabled = false;
            }
        }
        private void evaluateButton_Click(object sender, EventArgs e)
        {
            if (!turnDone)
            {
                Mediator.GetInstance().OnTurnFinished(this, numbersTakenThisTurn);
            }
            else
            {
                NextPlayersTurn();
            }

        }
        /// <summary>
        /// Return true if no options left, els returns false
        /// </summary>
        /// <returns></returns>
        private bool IfNoAvailibleNumbers()
        {
            List<int> availibleNumbers = new List<int>();
            List<int> numbersTochoosefrom = new List<int>();
            foreach (var b in choiceButton)
            {
                if (!b.Taken)
                {
                    numbersTochoosefrom.Add(b.Number);
                }
            }
            foreach (int x in numbersTochoosefrom)
            {
                if (x == totalRoll)
                {
                    availibleNumbers.Add(x);
                }
            }
            foreach (int x in numbersTochoosefrom)
            {
                foreach (int y in numbersTochoosefrom)
                {
                    if (x + y == totalRoll && x != y)
                    {
                        availibleNumbers.Add(x);
                        availibleNumbers.Add(y);
                    }
                    foreach (int z in numbersTochoosefrom)
                    {
                        if (x + y + z == totalRoll && x != y && x != z && y != z)
                        {
                            availibleNumbers.Add(x);
                            availibleNumbers.Add(y);
                            availibleNumbers.Add(z);
                        }
                    }
                }
            }
            availibleNumbers = availibleNumbers.Distinct().ToList();
            if (availibleNumbers.Count == 0) { return true; }
            else { return false; }
        }
        private static void SaveGameToDataBase(List<PlayersAndScore> players)
        {
            Dictionary<Person, int> personAndScoreDict = new Dictionary<Person, int>();
            foreach (var player in players)
            {
                var person = Repository.GetPersonFromName(player.Name);
                personAndScoreDict.Add(person, player.Score);
            }
            Repository.AddGameToDataBase(personAndScoreDict);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[0]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[1]);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[2]);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[3]);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[4]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[5]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[6]);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[7]);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Mediator.GetInstance().OnButtonPressed(this, choiceButton[8]);
        }      
    }
}
