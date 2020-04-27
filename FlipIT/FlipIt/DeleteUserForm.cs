using FlipGameDataBase.Data;
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
    public partial class DeleteUserForm : Form
    {
        public List<Person> people = new List<Person>();
        public DeleteUserForm()
        {
            InitializeComponent();
            people = SeedPeople();
            WireUpLists();
        }

        private List<Person> SeedPeople()
        {
            List<Person> output = new List<Person>();
            output = Repository.GetListOfPersons();
            return output;
        }
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WireUpLists()
        {
            userListBox.DataSource = null;
            userListBox.DataSource = people;
            userListBox.DisplayMember = "Name";
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (userListBox.SelectedItem != null)
            {
                Person p = (Person)userListBox.SelectedItem;
                Repository.DeletePerson(p);
                people.Remove(p);
                WireUpLists();
            }
        }
    }
}
