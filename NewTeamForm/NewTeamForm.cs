using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3ClassLibrary;

namespace NewTeamForm {
    public partial class NewTeamForm : Form {

        /***
         * Constructor for the form, normal WinForm initialization.
         ***/
        public NewTeamForm() {
            InitializeComponent();
        }

        /***
         * Details a team data member with associated property with getters and setters.
         * Exists so the main form can access the details of the new team once the form
         * Has provided its functionality.
         ***/
        private Team _aNewTeam;
        public Team aNewTeam {
            get {
                return _aNewTeam;
            }
            set {
                _aNewTeam = value;
            }
        }

        /***
         * Attempts to create a new team object from the users input. Provides input validation
         * And informs user if any details are incorrect.
         ***/
        private void addNewTeamButton_Click(object sender, EventArgs e) {
            try {
                Team temp;
                temp = new Team(newTeamNameInput.Text, newTeamGroundInput.Text, newTeamCoachInput.Text, Convert.ToInt32(newTeamYearInput.Text), newTeamRegionInput.Text);
                aNewTeam = temp;
                this.Close();
            }
            catch {
                /***
                 * If the constructor has failed, then input has been incorrect. 
                 * Warn the user and clear the text boxes.
                 * Allow them to start again
                 ***/
                newTeamNameInput.Text = "";
                newTeamGroundInput.Text = "";
                newTeamCoachInput.Text = "";
                newTeamYearInput.Text = "";
                newTeamRegionInput.Text = "";
                MessageBox.Show("Some details are either missing or have been entered incorrectly. Please ensure data is filled in appropriately.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
