using FlipGameDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipIt
{
    public partial class FlipMainForm : Form
    {

        public static Random rnd = new Random();
        public static List<string> diceRolls = new List<string>();
        public List<PlayersAndScore> playersThisTurn;
        public static List<ButtonToChoose> choiceButton = new List<ButtonToChoose>();
        public static List<Button> formButtons = new List<Button>();
        public static int totalRoll;

        public FlipMainForm(List<Person> players)
        {
            InitializeComponent();
            playersThisTurn = ConvertPersonsToPlayers(players);
            dicePictureOne.Visible = false;
            dicePictureTwo.Visible = false;
            SeedButtonList();
            Mediator.GetInstance().ButtonPressed += (s, e) =>
            {
                BindColorData(e.Button);
            };

            ResetGame();
            WireUpLists();
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
        private void BindColorData(ButtonToChoose button)
        {
            //TODO TEST
            programLabel.Text = "Changed";
            button.Taken = true;
            ColorOfButtons();
        }
        private void ResetGame()
        {
            choiceButton.Clear();
            for (int i = 1; i < 10; i++)
            {
                var button = new ButtonToChoose();
                button.Number = i;
                button.Taken = false;
                choiceButton.Add(button);
            }
        }
        private void WireUpLists()
        {
            scoreListBox.DataSource = null;
            scoreListBox.DataSource = playersThisTurn;
            scoreListBox.DisplayMember = "Display";
            ColorOfButtons();
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
                else
                {
                    b.BackColor = Color.Green;
                }
                i++;
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
            var diceRolls = DiceRoll();
            dicePictureOne.Visible = true;
            dicePictureTwo.Visible = true;
            dicePictureOne.Image = Image.FromFile(diceRolls[0]);
            dicePictureTwo.Image = Image.FromFile(diceRolls[1]);
            var intDiceRolls = ConvertStringToInt(diceRolls);
            totalRoll = intDiceRolls[0] + intDiceRolls[1];
            totalRollLabel.Visible = true;
            totalRollLabel.Text = $"Total roll: {totalRoll}";
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
    }
}
