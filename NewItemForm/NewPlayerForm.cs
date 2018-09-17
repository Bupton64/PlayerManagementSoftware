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


namespace newPlayerForm {
    public partial class NewPlayerForm : Form {

        /***
         * Constructor for the form, normal WinForm initialization.
         ***/
        public NewPlayerForm() {
            InitializeComponent();
        }

        /***
         * Details a player data member with associated property with getters and setters.
         * Exists so the main form can access the details of the new player once the form
         * Has provided its functionality.
         ***/
        private Player _aNewPlayer;
        public Player aNewPlayer {
            get {
                return _aNewPlayer;
            }
            set {
                _aNewPlayer = value;
            }
        }

        /***
         * Attempts to create a new player object from the users input. Provides input validation
         * And informs user if any details are incorrect.
         ***/
        private void addNewPlayerButton_Click(object sender, EventArgs e) {
            try {
                Player temp;
                temp = new Player(Convert.ToInt32(newPlayerIDInput.Text), newPlayerNameInput.Text, newPlayerDOBInput.Text, Convert.ToInt32(newPlayerHeightInput.Text), Convert.ToInt32(newPlayerWeightInput.Text), newPlayerPOBInput.Text);
                aNewPlayer = temp;
                this.Close();
            }
            catch {
                /*** 
                 * If the constructor has failed, then input has been incorrect. 
                 * Warn the user and clear the text boxes.
                 * Allow them to start again
                 ***/
                newPlayerIDInput.Text = "";
                newPlayerNameInput.Text = "";
                newPlayerDOBInput.Text = "";
                newPlayerHeightInput.Text = "";
                newPlayerWeightInput.Text = "";
                newPlayerPOBInput.Text = "";
                MessageBox.Show("Some details are either missing or have been entered incorrectly. Please ensure data is filled in appropriately.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
