using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment3ClassLibrary;
using newPlayerForm;
using NewTeamForm;

namespace MainForm{
    public partial class MainForm : Form {
        private List<Player> allPlayers; //< The list of all players in the system.
        private List<Team> allTeams; //< The list of all teams in the system.
        private Dictionary<string, int> ageGroups; //< A dictionary which keeps count of how many players fit into respective age groups for the purposes of charting

        /***
         * Main form constructor, provides WinForm initialization as well as memory allocation and display clearing.
         * Provides a welcome message for users and informs them of proper usage.
         ***/
        public MainForm() {
            InitializeComponent();
            initTeamDetailsDisplay();
            initDict();
            allPlayers = new List<Player>();
            allTeams = new List<Team>();
            MessageBox.Show("Welcome to Benjamin's Player Management Software v1.0!\nBegin using the application by adding teams and players or load them from previous files.\nRemember: Loading players before their team exists will cause them to become unenrolled!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /***
         * Subroutine that initializes the age group counting dictionary in the system.
         ***/
        private void initDict() {
            ageGroups = new Dictionary<string, int>();
            ageGroups.Add("0-9", 0);
            ageGroups.Add("10-19", 0);
            ageGroups.Add("20-29", 0);
            ageGroups.Add("30-39", 0);
            ageGroups.Add("40-49", 0);
            ageGroups.Add("50-59", 0);
            ageGroups.Add("60+", 0);
        }

        /***
         * Subroutine that removes the default text from the team details labels in the form.
         * Without default text, the labels can become lost in te designer, this is a simple way to fix
         ***/
        private void initTeamDetailsDisplay() {
            teamDetailsNameDisplay.Text = "";
            teamDetailsGroundDisplay.Text = "";
            teamDetailsCoachDisplay.Text = "";
            teamDetailsYearDisplay.Text = "";
            teamDetailsRegionDisplay.Text = "";
        }

        /***
         * Subroutine that checks whether any teams are initialized in the system.
         * If not, warns the user.
         ***/
        private void checkTeams() {
            // If there are no teams registered, create a warning with options for the user.
            if (!allTeams.Any()) {
                DialogResult proceed = MessageBox.Show("The system currently has no registered teams. Loading players into this system will cause them to become unenrolled from any team they have previously been enrolled in. Load or add teams into the system first to avoid this.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (proceed == DialogResult.Cancel) {
                    return;
                }
            }
        }

        /***
         * Subroutine responsible for the loading of players into the system.
         * Uses multiple other subroutines and methods to accomplish this along with 
         * Various input validation techniques.
         ***/
        private void playersLoadMenuTool_Click(object sender, EventArgs e) {
            checkTeams();
            //Provide file selection, limited to text files.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                FileStream fs = (FileStream)ofd.OpenFile();
                StreamReader reader = new StreamReader(fs);
                bool invalidLoad = false;
                // Iterate through the input file and read in each player.
                while(reader.Peek() > -1) {
                    string inputLine = reader.ReadLine();
                    try {
                        string[] playerData = inputLine.Split(';');
                        bool isPlayerUnique = checkPlayerisUnique(playerData);
                        if (!isPlayerUnique) {
                            continue;
                        }
                        Player temp = addToTeam(playerData);
                        addPlayerToDisplays(temp);
                    }
                    catch {
                        invalidLoad = true;
                    }
                }
                if (invalidLoad) {
                    MessageBox.Show("The save file appears to be corrupt, some data may not have loaded correctly.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                fs.Close();
            }
        }

        /***
         * Method that checks that a new player object has a unique ID number.
         * @param [in] playerData, a string array containing string versions of data for a new player object.
         * @return false if the player is not unique, else true 
         ***/
        private bool checkPlayerisUnique(string [] playerData) {
            Player checkUnique = (from p in allPlayers where p.ID == Convert.ToInt32(playerData[0]) select p).FirstOrDefault();
            if (checkUnique != null) {
                if (checkUnique.name == playerData[1]) {
                    return false;
                } else {
                    MessageBox.Show("The player " + playerData[1] + " could not be added to the roster because their ID number is invalid. The ID " + playerData[0] + " belongs to " + checkUnique.name + ".", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else {
                return true;
            }
        }

        /***
         * Method for creating the new player object and adding them to their team if they are enrolled in one.
         * @param [in] playerData, string array containing the data to construct the player object.
         ***/
        private Player addToTeam(string [] playerData) {
            // Add player to regular roster if no team
            Player temp;
            if (playerData.Length < 7) {
                temp = new Player(Convert.ToInt32(playerData[0]), playerData[1], playerData[2], Convert.ToInt32(playerData[3]), Convert.ToInt32(playerData[4]), playerData[5]);
            } else {
                temp = new Player(Convert.ToInt32(playerData[0]), playerData[1], playerData[2], Convert.ToInt32(playerData[3]), Convert.ToInt32(playerData[4]), playerData[5], playerData[6]);
                //Find the team the player is signed to, warn that they will be unenrolled if the team does not exist.
                Team result = (from t in allTeams where t.name == temp.teamSignedTo select t).FirstOrDefault();
                if (result != null) {
                    result.playerList.Add(temp); // Add the player to the team's player roster

                } else {
                    MessageBox.Show("The player " + temp.name + " could not be added to '" + temp.teamSignedTo + "' because the team '" + temp.teamSignedTo + "' does not exist.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    temp.teamSignedTo = "";
                }
            }
            return temp;
        }

        /***
         * Subroutine which adds a newly created Player object to the various listviews and charts in the application
         * @param [in] temp, the player object to be added to displays.
         ***/
        private void addPlayerToDisplays(Player temp) {
            // Add player to List, listviews and charts.
            allPlayers.Add(temp);
            playerEnrolListView.Items.Add(new ListViewItem(new[] { temp.name, temp.teamSignedTo })); // Add player to enrolment list view.
            addPlayerToHeightWeightChart(temp);
            addToAgeChart(temp.getAge());
            ListViewItem item = new ListViewItem(new[] { temp.ID.ToString(), temp.name, temp.dateOfBirth.ToShortDateString(), temp.height.ToString(), temp.weight.ToString(), temp.placeOfBirth, temp.teamSignedTo });
            playersListView.Items.Add(item);
        }

        /***
         * Subroutine responsible for adding a player to the age chart in the application
         * @param [in] playerAge, the age of the player being recorded
         ***/
        private void addToAgeChart(int playerAge) {
            if (playerAge < 10) {
                ageGroups["0-9"]++;
            } else if (playerAge < 20) {
                ageGroups["10-19"]++;
            } else if (playerAge < 30) {
                ageGroups["20-29"]++;
            } else if (playerAge < 40) {
                ageGroups["30-39"]++;
            } else if (playerAge < 50) {
                ageGroups["40-49"]++;
            } else if (playerAge < 60) {
                ageGroups["50-59"]++;
            } else {
                ageGroups["60+"]++;
            }
            updateAgeChart();
        }

        /***
         * Subroutine which replots the age chart. To be called when new points are added.
         ***/
        private void updateAgeChart() {
            ageChart.Series["Age"].Points.Clear();
            ageChart.Series["Age"].Points.AddXY("0-9", ageGroups["0-9"]);
            ageChart.Series["Age"].Points.AddXY("10-19", ageGroups["10-19"]);
            ageChart.Series["Age"].Points.AddXY("20-29", ageGroups["20-29"]);
            ageChart.Series["Age"].Points.AddXY("30-39", ageGroups["30-39"]);
            ageChart.Series["Age"].Points.AddXY("40-49", ageGroups["40-49"]);
            ageChart.Series["Age"].Points.AddXY("50-59", ageGroups["50-59"]);
            ageChart.Series["Age"].Points.AddXY("60+", ageGroups["60+"]);
        }

        /***
         * Subroutine for loading teams from a save file into the system.
         * Uses multiple methods and subroutines to achieve this along with
         * Input validation techniques
         ***/
        private void teamsLoadMenuTool_Click(object sender, EventArgs e) {
            //< Provide file selection, limited to text files.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK) {
                FileStream fs = (FileStream)ofd.OpenFile();
                StreamReader reader = new StreamReader(fs);
                bool invalidLoad = false;
                while (reader.Peek() > -1) {
                    string inputLine = reader.ReadLine();
                    try {
                        string[] teamData = inputLine.Split(';');
                        //< Validate the team name is unique
                        bool isUnique = checkTeamIsUnique(teamData[0]);
                        if (!isUnique) {
                            continue;
                        }
                        Team temp = new Team(teamData[0], teamData[1], teamData[2], Convert.ToInt32(teamData[3]), teamData[4]);
                        addTeamToDisplays(temp);
                    }
                    catch {
                        invalidLoad = true;
                    }
                }
                if (invalidLoad) {
                    MessageBox.Show("The save file appears to be corrupt, some data may not have loaded correctly.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                fs.Close();
            }
        }

        /***
         * Method for checking whether a new team is unique or not.
         * @param [in] teamData, a name for the new team 
         * @return false if the name is not unique, else true
         ***/
        private Boolean checkTeamIsUnique(String teamData) {
            Team checkUnique = (from t in allTeams where t.name == teamData select t).FirstOrDefault();
            if (checkUnique != null) {
                MessageBox.Show("The team '" + checkUnique.name + "' already exists and cannot be loaded in twice.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else {
                return true;
            }
        }

        /***
         * Subroutine which adds a newly created Team object to the various listviews in the application
         * @param [in] temp, the team object to be added to displays.
         ***/
        private void addTeamToDisplays(Team temp) {
            allTeams.Add(temp);
            teamEnrolListView.Items.Add(new ListViewItem(temp.name));
            ListViewItem item = new ListViewItem(new[] { temp.name, temp.ground, temp.coachName, temp.yearFounded.ToString(), temp.region });
            teamListView.Items.Add(item);
        }

        /***
         * Subroutine which closes the application when the exit button is clicked.
         ***/
        private void exitMenuTool_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /***
         * Subroutine that opens a new form for adding a player to the system.
         * Provides input validation to ensure no overwriting or duplicate entries.
         ***/
        private void addPlayerMenuTool_Click(object sender, EventArgs e) {
            // The IDE was having some issues when calling this without the namespace.
            newPlayerForm.NewPlayerForm openForm = new newPlayerForm.NewPlayerForm();
            openForm.ShowDialog();
            try {
                Player checkID = (from p in allPlayers where p.ID == openForm.aNewPlayer.ID select p).FirstOrDefault();
                if (checkID != null) {
                    MessageBox.Show("The ID " + checkID.ID + " is already in use by " + checkID.name + ". The new player could not be created with that ID number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }
            try {
                addPlayerToDisplays(openForm.aNewPlayer);        
            }
            catch { }
        }

        /***
         * Subroutine that opens a new form for adding a team to the system.
         * Provides input validation to ensure no overwriting or duplicate entries.
         ***/
        private void addTeamMenuTool_Click(object sender, EventArgs e) {
            NewTeamForm.NewTeamForm openForm = new NewTeamForm.NewTeamForm();
            openForm.ShowDialog();
            try {
                Team checkName = (from t in allTeams where t.name == openForm.aNewTeam.name select t).FirstOrDefault();
                if (checkName != null) {
                    MessageBox.Show("The name " + checkName.name + " is already in use. A new team could not be created with that name. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }
            try {
                addTeamToDisplays(openForm.aNewTeam);
            }
            catch { }
        }

        private int playerSelectedForEnrolmentIndex; //< So that player can be searched by their ID (unique) instead of name when enrolling.
        /***
         * Subroutine that manages the player enrolment listview and displays what player is selected.
         ***/
        private void playerEnrolListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (playerEnrolListView.SelectedItems.Count > 0) {
                int index = playerEnrolListView.SelectedIndices[0];
                selectEnrolPlayerText.Text = playerEnrolListView.Items[index].SubItems[0].Text;
                playerSelectedForEnrolmentIndex = index;
            }
        }

        /***
         * Subroutine that manages the team enrolment listview and displays what team is selected.
         ***/
        private void teamEnrolListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (teamEnrolListView.SelectedItems.Count > 0) {
                int index = teamEnrolListView.SelectedIndices[0];
                selectEnrolTeamText.Text = teamEnrolListView.Items[index].SubItems[0].Text;
            }
        }

        /***
         * Subroutine that enrols a player into a new team. Involves removing the player from
         * Any existing team and updating any displays the player appears in
         ***/
        private void confirmEnrolmentButton_Click(object sender, EventArgs e) {
            if((selectEnrolPlayerText.Text != "") && (selectEnrolTeamText.Text != "")) {
                DialogResult result = MessageBox.Show("Enrol " + selectEnrolPlayerText.Text + " into " + selectEnrolTeamText.Text + "?", "Enrol?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No) {
                    return;
                }
                Player playerToAdd = removePlayerFromOldTeam();
                Team teamToAdd = addPlayerToNewTeam(playerToAdd);
                updateExistingPlayerDisplays(teamToAdd.name);
            } else {
                MessageBox.Show("To enrol, you must select both a player and a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***
         * Method used to remove a player from their existing team as part of the re-enrolment process
         * @return the player object being enrolled into a new team
         ***/
        private Player removePlayerFromOldTeam() {
            //< Find the player object and remove from any previous team.
            int playersID = Convert.ToInt32(playersListView.Items[playerSelectedForEnrolmentIndex].SubItems[0].Text);
            Player playerToAdd = (from p in allPlayers where p.ID == playersID select p).FirstOrDefault();
            if (playerToAdd.teamSignedTo != "") {
                //< Find the team to remove from.
                Team teamToRemove = (from t in allTeams where t.name == playerToAdd.teamSignedTo select t).FirstOrDefault();
                teamToRemove.playerList.Remove(playerToAdd);
            }
            return playerToAdd;
        }

        /***
         * Method that adds an existing player to a new team.
         * @param [in] playerToAdd, the player to be added into a new team
         * @return the team the player has been enrolled in.
         ***/
        private Team addPlayerToNewTeam(Player playerToAdd) {
            //< Find the team object and add player to that team.
            Team teamToAdd = (from t in allTeams where t.name == selectEnrolTeamText.Text select t).FirstOrDefault();
            playerToAdd.teamSignedTo = teamToAdd.name;
            teamToAdd.playerList.Add(playerToAdd);
            return teamToAdd;
        }

        /***
         * Subroutine that edits existing listview objects to display the players new team correctly.
         * @param [in] teamToAdd, the name of the players new team. To fill the appropriate listview columns
         ***/
        private void updateExistingPlayerDisplays(string teamToAdd) {
            //< Update the player listview.
            foreach (ListViewItem item in playersListView.Items) {
                if (item.SubItems[1].Text == selectEnrolPlayerText.Text) {
                    item.SubItems[6].Text = teamToAdd;
                    break;
                }
            }
            //< Update the player enrol listview
            foreach (ListViewItem item in playerEnrolListView.Items) {
                if (item.SubItems[0].Text == selectEnrolPlayerText.Text) {
                    item.SubItems[1].Text = teamToAdd;
                    break;
                }
            }
        }

        /***
         * Subroutine that saves all players in the system to file when the save players option is selected
         ***/
        private void playersSaveMenuTool_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "PlayerSaveList.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK) {
                FileStream fs;
                fs = File.Create(save.FileName);
                StreamWriter writer;
                writer = new StreamWriter(fs);
                for (int i = 0; i < allPlayers.Count; i++) {
                    writer.WriteLine(allPlayers[i].savePlayer());
                }
                writer.Close();
            }
        }

        /***
         * Subroutine that saves all teams in the system to file when the save teams option is selected
         ***/
        private void teamsSaveMenuTool_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "TeamSaveList.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK) {
                FileStream fs;
                fs = File.Create(save.FileName);
                StreamWriter writer;
                writer = new StreamWriter(fs);
                for (int i = 0; i < allTeams.Count; i++) {
                    writer.WriteLine(allTeams[i].saveTeam());
                }
                writer.Close();
            }
        }

        /***
         * Subroutine that changes the team details display based on what player is selected
         ***/
        private void playersListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (playersListView.SelectedItems.Count > 0) {
                int index = playersListView.SelectedIndices[0];
                Team playersTeam = (from t in allTeams where t.name == playersListView.Items[index].SubItems[6].Text select t).SingleOrDefault();
                if (playersTeam != null) {
                    teamDetailsNameDisplay.Text = playersTeam.name;
                    teamDetailsGroundDisplay.Text = playersTeam.ground;
                    teamDetailsCoachDisplay.Text = playersTeam.coachName;
                    teamDetailsYearDisplay.Text = playersTeam.yearFounded.ToString();
                    teamDetailsRegionDisplay.Text = playersTeam.region;
                } else {
                    teamDetailsNameDisplay.Text = "";
                    teamDetailsGroundDisplay.Text = "";
                    teamDetailsCoachDisplay.Text = "";
                    teamDetailsYearDisplay.Text = "";
                    teamDetailsRegionDisplay.Text = "";
                }
            }
        }

        /***
         * Subroutine which updates the player roster display to match the roster of the selected team.
         ***/
        private void teamListView_SelectedIndexChanged(object sender, EventArgs e) {
            if (teamListView.SelectedItems.Count > 0) {
                int index = teamListView.SelectedIndices[0];
                Team selectedTeam = (from t in allTeams where t.name == teamListView.Items[index].SubItems[0].Text select t).SingleOrDefault();
                for(int i =0; i < selectedTeam.playerList.Count; i++) {
                    ListViewItem item = new ListViewItem(selectedTeam.playerList[i].name);
                    rosterListView.Items.Add(item);
                }
            } else {
                rosterListView.Items.Clear();
            }
        }

        /***
         * Subroutine that manages the searching functionality. Provides validation of user input.
         ***/
        private void searchButton_Click(object sender, EventArgs e) {
            searchDisplayListView.Items.Clear();
            if (allPlayers.Count == 0) {
                MessageBox.Show("No players exist to search for.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((!searchAge.Checked) && (!POBSearchBy.Checked)) {
                MessageBox.Show("No parameter for searching provided. Please choose to search by age of by place of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                if (searchAge.Checked) {
                    searchByAge();
                } else if (POBSearchBy.Checked) {
                    checkPOBEntry();
                    searchByPOB();
                }
            }
            catch {
                MessageBox.Show("Input format is incorrect for the selected search parameter. Please re enter your search query.", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /***
         * Subroutine that performs searching based on age
         ***/
        private void searchByAge() {
            IEnumerable<Player> searchedPlayers = (from p in allPlayers where p.getAge() == Convert.ToInt32(searchText.Text) select p);
            inputSearchedPlayers(searchedPlayers);
        }

        /***
         * Subroutine that makes sure no numbers or special characters appear in the string being
         * Used to search for place of birth.
         ***/
        private void checkPOBEntry() {
            foreach (char c in searchText.Text.ToLower()) {
                if (!((c >= 'a') && (c <= 'z')) && (c != ' ') && (c != ',') ) {
                    throw new FormatException();
                }
            }
        }

        /***
         * Subroutine that performs searching based on place of birth
         ***/
        private void searchByPOB() {
            IEnumerable<Player> searchedPlayers = (from p in allPlayers where p.placeOfBirth == searchText.Text select p);
            inputSearchedPlayers(searchedPlayers);
        }

        /***
         * Subroutine that updates the search results listview with the results of the search.
         ***/
        private void inputSearchedPlayers(IEnumerable<Player> searchedPlayers) {
            foreach (Player p in searchedPlayers) {
                ListViewItem item = new ListViewItem(p.name);
                searchDisplayListView.Items.Add(item);
            }
        }

        /***
         * Subroutine that plots a player onto the height and weight chart
         ***/
        private void addPlayerToHeightWeightChart(Player p) {
            heightWeightChart.Series["Height"].Points.AddXY(p.name, p.height);
            heightWeightChart.Series["Weight"].Points.AddXY(p.name, p.weight);
        }
    }
}
