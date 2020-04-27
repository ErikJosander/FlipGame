using FlipGameDataBase.Data;
using FlipGameDataBase.Data.Temps;
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
    public partial class ShowStatisticsForm : Form
    {
        public List<Match> currentMatches = new List<Match>();
        public MatchWithPersons currentmatchWithPersons = new MatchWithPersons();
        public ShowStatisticsForm()
        {
            InitializeComponent();
        }
        private void WireUpList()
        {
            specificMatchListBox.DataSource = null;
            currentmatchWithPersons.PeoplePlaceScore.OrderBy(x => x.Score);
            specificMatchListBox.DataSource = currentmatchWithPersons.PeoplePlaceScore;
            specificMatchListBox.DisplayMember = "Display";
        }
        private void ShowStatisticsForm_Load(object sender, EventArgs e)
        {

        }
        private void getMatchesButton_Click(object sender, EventArgs e)
        {
            currentMatches.Clear();
            treeViewMatches.Nodes.Clear();
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;

            var matches = Repository.GetBetweenDatesMatches(startDate, endDate);
            currentMatches = matches;
            int matchCount = currentMatches.Count();
            int count = 1;
            if (matchCount != 0)
            {
                foreach (var m in currentMatches)
                {
                    treeViewMatches.Nodes.Add($"{m.Id}. {m.PlayedOn}");
                    count++;
                }
            }
        }
        private void selectedNodeMatch_Click(object sender, EventArgs e)
        {
            int exists = 0;
            foreach(var x in treeViewMatches.Nodes)
            {
                exists = 1;
            }
            if(exists == 1)
            {
                string nodeText = treeViewMatches.SelectedNode.Text;

                nodeText = nodeText.Remove(0, 3);
                var selectedDate = DateTime.Parse(nodeText);
                var match = Repository.GetMatchFromDate(selectedDate);
                currentmatchWithPersons = Repository.GetScoreAndPersonsFromMatch(match);
                WireUpList();
            }
        }
        private void specificMatchListBox_DoubleClick(object sender, EventArgs e)
        {
            TempPerson tp = new TempPerson();
            try
            {
                tp = (TempPerson)specificMatchListBox.SelectedItem;
                Person person = Repository.GetPersonFromName(tp.Name);
                PlayerStatistics ps = Repository.GetPlayerStatistics(person);
                MessageBox.Show($"Name: {ps.Name}" +
                    $"{Environment.NewLine}" +
                    $"Created on: {ps.CreatedOn}" +
                    $"{Environment.NewLine}" +
                    $"TotalGames: {ps.TotalGames}" +
                    $"{Environment.NewLine}" +
                    $"Times firstplace: {ps.FirsPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times secondplace: {ps.SecondPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times thirdplace: {ps.ThirdPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times fourthplace: {ps.FourthPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Total score: {ps.TotScore}");
            }
            catch (InvalidCastException)
            {
                Person p = new Person();
                p = (Person)specificMatchListBox.SelectedItem;
                PlayerStatistics ps = Repository.GetPlayerStatistics(p);
                MessageBox.Show($"Name: {ps.Name}" +
                    $"{Environment.NewLine}" +
                    $"Created on: {ps.CreatedOn}" +
                    $"{Environment.NewLine}" +
                    $"TotalGames: {ps.TotalGames}" +
                    $"{Environment.NewLine}" +
                    $"Times firstplace: {ps.FirsPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times secondplace: {ps.SecondPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times thirdplace: {ps.ThirdPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Times fourthplace: {ps.FourthPlaceSum}" +
                    $"{Environment.NewLine}" +
                    $"Total score: {ps.TotScore}");
            }

        }
        private void UpdateTreelistWithFromName(DateTime startDate, DateTime endDate, string nameInput)
        {
            var matches = Repository.GetBetweenDatesMatches(startDate, endDate);
            var nameMatches = Repository.GetMatchesFromName(nameInput);

            var matchesOuput = new List<Match>();
            foreach (var x in matches)
            {
                foreach (var y in nameMatches)
                {
                    if (y.Id == x.Id)
                    {
                        matchesOuput.Add(x);
                    }
                }
            }
            if (matchesOuput.Count == 0)
            {
                MessageBox.Show("No matches played between the dates");
            }
            else
            {
                foreach (var m in matchesOuput)
                {
                    treeViewMatches.Nodes.Add($"{m.Id}. {m.PlayedOn}");
                }
            }
        }
        private void nameSearchButton_Click(object sender, EventArgs e)
        {
            treeViewMatches.Nodes.Clear();
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;
            var input = nameSearchInput.Text;
            if (input == "")
            {
                MessageBox.Show("Need an input");
            }
            else if (!Repository.SearchForPerson(input))
            {
                MessageBox.Show("User don't exists");
            }
            else
            {
                UpdateTreelistWithFromName(startDate, endDate, input);
            }
        }
        private void getAllPlayerButton_Click(object sender, EventArgs e)
        {
            var list = Repository.GetListOfPersons();
            specificMatchListBox.DataSource = null;
            specificMatchListBox.DisplayMember = "";
            specificMatchListBox.DataSource = list;
            specificMatchListBox.DisplayMember = "Name";

        }
    }
}
