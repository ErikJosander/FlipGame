using FlipGameDataBase.Data;
using FlipGameDataBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipIt
{
    public partial class CreateUserForm : Form
    {
        private IPersonRequester callingForm;
        public CreateUserForm(IPersonRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }
        private void createUserLabel_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var randomColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            createUserLabel.ForeColor = randomColor;

        }
        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            var nameToValidate = nameInputTextBox.Text;
            if (CheckIfCorrect(nameToValidate))
            {
                if (!Repository.SearchForPerson(nameToValidate))
                {
                    Person p = new Person();
                    p.Name = nameToValidate;
                    p.CreatedOn = DateTime.Now;
                    Repository.AddPerson(p);
                    callingForm.PersonComplete(p);
                    this.Close();
                }
                else
                {
                    nameInputTextBox.Text = "";
                    MessageBox.Show("Person allready exist");
                }
            }
            else
            {
                nameInputTextBox.Text = "";
                MessageBox.Show("Invalid input");
            }
        }
        private bool CheckIfCorrect(string input)
        {
            List<string> uglywords = new List<string>();
            uglywords.Add("Ugly");

            if (input.Count() > 12)
            {
                return false;
            }
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            if (uglywords.Contains(input))
            {
                return false;
            }
            Regex r = new Regex("^[a-zA-Z0-9--]*$");
            if (!r.IsMatch(input))
            {
                return false;
            }
            return true;
        }
        private void nameInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
