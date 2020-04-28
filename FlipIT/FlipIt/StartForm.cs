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
    public partial class StartForm : Form, IPersonRequester
    {
        public List<Person> players = Repository.GetListOfPersons();
        public List<Person> selectedPlayers = new List<Person>();   
        public StartForm()
        {
            InitializeComponent();                              
            WireUpLists();
        }    
        private void WireUpLists()
        {
            dropDownOfPlayers.DataSource = null;
            dropDownOfPlayers.DataSource = players;
            dropDownOfPlayers.DisplayMember = "Name";


            selectedPlayerListBox.DataSource = null;
            selectedPlayerListBox.DataSource = selectedPlayers;
            selectedPlayerListBox.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            Person p = (Person)dropDownOfPlayers.SelectedItem;
            if (p != null && selectedPlayers.Count < 4)
            {
                players.Remove(p);
                selectedPlayers.Add(p);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Maximum of 4 players");
            }
        }
        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            Person p = (Person)selectedPlayerListBox.SelectedItem;
            if (p != null)
            {
                players.Add(p);
                selectedPlayers.Remove(p);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void startGame_Button_Click(object sender, EventArgs e)
        {
            if (selectedPlayers.Count == 0)
            {
                MessageBox.Show("To few players");
            }
            else
            {              
                FlipMainForm fmf = new FlipMainForm(selectedPlayers);               
                fmf.Show();                          
                foreach (var p in selectedPlayers)
                {
                    players.Add(p);
                }              
                selectedPlayers.Clear();
                WireUpLists();
            }
        }
        private void linkLabelCreateNewPlayer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cuf = new CreateUserForm(this);
            cuf.Show();
        }
        public void PersonComplete(Person p)
        {
            selectedPlayers.Add(p);
            WireUpLists();
        }
        private void statisticsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ssf = new ShowStatisticsForm();
            ssf.Show();
        }
        private void deletePLayerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var duf = new DeleteUserForm();
            duf.Show();
        }

        private void tutorialButton_Click(object sender, EventArgs e)
        {
            TutorialForm tf = new TutorialForm();
            tf.Show();
        }
    }
}
