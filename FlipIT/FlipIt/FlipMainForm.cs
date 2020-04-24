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
        // TODO FIX BUG WITH DICEROLL BUTTON
        public static Random rnd = new Random();
        public List<string> diceRolls = new List<string>();
        public List<PlayersAndScore> playersThisTurn;
        public List<ButtonToChoose> choiceButton = new List<ButtonToChoose>();
        public List<Button> formButtons = new List<Button>();
        public int totalRoll;
        public List<int> numbersToChooseFrom = new List<int>();
        public bool oneNumberChoosen = false;
        public bool twoNumbersChoosen = false;
        public bool threeNumbersChoosen = false;
        public int firstChoice = 0;
        public int secondChoice = 0;
        public PlayersAndScore whoIsPlaying;

        public FlipMainForm(List<Person> players)
        {
            InitializeComponent();
            totalRollLabel.Text = "";
            playersThisTurn = ConvertPersonsToPlayers(players);
            whoIsPlaying = playersThisTurn[0];
            ResetGame();
            Mediator.GetInstance().ButtonPressed += (s, e) =>
            {
                BindColorData(e.Button);
            };
            Mediator.GetInstance().TurnFinished += (s, e) =>
            {
                EvaluateIfturnFinnished(e.AvailibleNumbers);
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
        private void EvaluateIfturnFinnished(List<int> availibleNumbers)
        {          
            if (availibleNumbers.Count == 0)
            {
                var lastPlayer = playersThisTurn.LastOrDefault();
                if(whoIsPlaying == lastPlayer)
                {
                    whoIsPlaying.Score += ReturnTurnScore();
                    WireUpLists();
                    var winner = playersThisTurn.OrderBy(x => x.Score).FirstOrDefault();
                    SaveGameToDataBase(playersThisTurn);
                    MessageBox.Show($"Winner: {winner.Name}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Turns Finished");
                    whoIsPlaying.Score += ReturnTurnScore();
                    WireUpLists();
                    var indexOfWhoIsPlaying = playersThisTurn.IndexOf(whoIsPlaying);
                    whoIsPlaying = playersThisTurn[indexOfWhoIsPlaying + 1];
                    ResetGame();
                }
            }
        }
        private void BindColorData(ButtonToChoose button)
        {
            if (oneNumberChoosen == false)
            {
                if (numbersToChooseFrom.Contains(button.Number) && !button.Taken)
                {
                    if (button.Number == totalRoll)
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();
                        DisableAllButtons();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                        rollDiceButton.Enabled = true;
                    }
                    else
                    {
                        button.Taken = true;
                        firstChoice = button.Number;
                        oneNumberChoosen = true;
                        numbersToChooseFrom.Clear();
                        numbersToChooseFrom = CalculateOptions();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                    }
                }
            }
            if (oneNumberChoosen && !twoNumbersChoosen)
            {
                if (numbersToChooseFrom.Contains(button.Number) && !button.Taken)
                {
                    if (button.Number == totalRoll)
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();
                        DisableAllButtons();
                        UpdateNumbersToChooseList();
                        ColorOfButtons();
                        rollDiceButton.Enabled = true;
                    }
                    else
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();
                        twoNumbersChoosen = true;
                        numbersToChooseFrom.Clear();
                        numbersToChooseFrom = CalculateOptions();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                    }
                }
            }
            if (oneNumberChoosen && twoNumbersChoosen && !threeNumbersChoosen)
            {
                if (numbersToChooseFrom.Contains(button.Number) && !button.Taken)
                {
                    if (button.Number == totalRoll)
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();                       
                        DisableAllButtons();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                    }
                    else
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();
                        threeNumbersChoosen = true;
                        numbersToChooseFrom.Clear();
                        numbersToChooseFrom = CalculateOptions();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                    }
                }
            }
            if (threeNumbersChoosen)
            {
                if (numbersToChooseFrom.Contains(button.Number) && !button.Taken)
                {
                    if (button.Number == totalRoll)
                    {
                        button.Taken = true;
                        numbersToChooseFrom.Clear();
                        DisableAllButtons();
                        ColorOfButtons();
                        UpdateNumbersToChooseList();
                    }
                }

            }
            // TODO add more ifs-statments if player choose more the 3 numbers
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
            
            SeedButtonList();
            numbersToChooseFrom.Clear();          
            totalRollLabel.Text = "";
            SeedChoiceButton();
            WireUpLists();
            ColorOfButtons();         
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
            choiceButton.Clear();
            for (int i = 1; i <= 9; i++)
            {
                var button = new ButtonToChoose();
                button.Number = i;
                //button.Taken = false;
                choiceButton.Add(button);
            }
        }
        private void WireUpLists()
        {
            scoreListBox.DataSource = null;
            scoreListBox.DataSource = playersThisTurn;
            scoreListBox.DisplayMember = "Display";
        }
        private void ColorOfButtons()
        {
            int i = 0;
            foreach (Button b in formButtons)
            {
                if (choiceButton[i].Taken)
                {
                    b.BackColor = Color.IndianRed;
                }
                else if (numbersToChooseFrom.Contains(i + 1))
                {
                    b.BackColor = Color.Green;
                }
                else
                {
                    b.BackColor = Color.Gray;
                }
                i += 1;
            }
        }
        private static List<string> DiceRoll()
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
            return output;
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
        private void FlipMainWindow_Load(object sender, EventArgs e)
        {

        }
        private void scoreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rollDiceButton_Click_1(object sender, EventArgs e)
        {          
            oneNumberChoosen = false;
            twoNumbersChoosen = false;
            threeNumbersChoosen = false;
            firstChoice = 0;
            secondChoice = 0;

            EnableAllButtons();
            var diceRolls = DiceRoll();
            dicePictureOne.Visible = true;
            dicePictureTwo.Visible = true;
            dicePictureOne.Image = Image.FromFile(diceRolls[0]);
            dicePictureTwo.Image = Image.FromFile(diceRolls[1]);
            var intDiceRolls = ConvertStringToInt(diceRolls);
            totalRoll = intDiceRolls[0] + intDiceRolls[1];
            totalRollLabel.Visible = true;
            totalRollLabel.Text = $"Total roll: {totalRoll}";
            numbersToChooseFrom.Clear();
            numbersToChooseFrom = CalculateOptions();
            ColorOfButtons();
            Mediator.GetInstance().OnTurnFinished(this, numbersToChooseFrom);
            UpdateNumbersToChooseList();
            
        }
        private List<int> CalculateOptions()
        {
            var output = new List<int>();
            var listOfAvailibleNumbers = new List<int>();
            foreach (var button in choiceButton)
            {
                if (!button.Taken)
                {
                    listOfAvailibleNumbers.Add(button.Number);
                }

            }
            if (oneNumberChoosen && !twoNumbersChoosen)
            {
                totalRoll = (totalRoll - firstChoice);
            }
            if (oneNumberChoosen && twoNumbersChoosen)
            {
                totalRoll = (totalRoll - firstChoice - secondChoice);
            }
            foreach (var x in listOfAvailibleNumbers)
            {
                if (x == totalRoll)
                {
                    output.Add(x);
                }
            }
            foreach (var x in listOfAvailibleNumbers)
            {
                foreach (var y in listOfAvailibleNumbers)
                {
                    if (x + y == totalRoll && x != y)
                    {
                        output.Add(x);
                        output.Add(y);
                    }
                    foreach (var z in listOfAvailibleNumbers)
                    {
                        if (x + y + z == totalRoll && x != y && x != z && y != z)
                        {
                            output.Add(x);
                            output.Add(y);
                            output.Add(z);
                        }
                    }
                }
            }
            return output.Distinct().ToList();
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
        private void UpdateNumbersToChooseList()
        {           
            numbersToChooseFromList.DataSource = null;
            numbersToChooseFromList.DataSource = numbersToChooseFrom;
            foreach (var x in numbersToChooseFrom)
            {
                numbersToChooseFromList.DisplayMember.ToString();
            }
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
