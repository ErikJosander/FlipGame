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
            var startDate = dateTimePicker1.Value;
            var endDate = dateTimePicker2.Value;

            var matches = Repository.GetBetweenDatesMatches(startDate, endDate);
            currentMatches = matches;
            int matchCount = currentMatches.Count();
            int count = 1;
            if(matchCount != 0)
            {
                foreach(var m in currentMatches)
                {
                    treeViewMatches.Nodes.Add($"{m.Id}. {m.PlayedOn}");
                    count++;
                }              
            }           
        }
        private void selectedNodeMatch_Click(object sender, EventArgs e)
        {
            if(treeViewMatches.SelectedNode.Text != "")
            {
                var nodeText = treeViewMatches.SelectedNode.Text;
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

    }
}
