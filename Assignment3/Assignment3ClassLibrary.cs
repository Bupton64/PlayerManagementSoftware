using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Assignment3ClassLibrary
{
    /**
     * Class that defines a rugby player
     **/
    public class Player {

        /***
         * Found below are the private data members of the Player class.
         * They are encapsulated through associated properties which contain getters
         * And setters for all properties.
         ***/
        private int _ID; //< Contains a unique ID registration number for the player
        public int ID {
            get {
                return _ID;
            }
            set {
                _ID = value;
            }
        }

        private string _name; //< Contains the players name (first and last)
        public string name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        private DateTime _dateOfBirth; //< Contains the players date of birth
        public DateTime dateOfBirth {
            get {
                return _dateOfBirth;
            }
            set {
                _dateOfBirth = value;
            }
        }

        private int _height; //< Contains the players height
        public int height {
            get {
                return _height;
            }
            set {
                _height = value;
            }
        }

        private int _weight; //< Contains the players weight
        public int weight {
            get {
                return _weight;
            }
            set {
                _weight = value;
            }
        }

        private string _placeOfBirth; //< Contains the town or city a player was born in.
        public string placeOfBirth {
            get {
                return _placeOfBirth;
            }
            set {
                _placeOfBirth = value;
            }
        }

        private string _teamSignedTo; //< Contains the name of the team the player is signed to.
        public string teamSignedTo {
            get {
                return _teamSignedTo;
            }
            set {
                _teamSignedTo = value; 
            }
        }

        //< Private Methods

        /***
         * Method for calculating the players age based on their Date of Birth
         * Hidden as private as the functionality is only required internally.
         ***/
        private int calculateAge() {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
            return (now - dob) / 10000;
        }

        //< Public Methods

        /***
         * Constructor for the player class - For Unenrolled Players
         * Sets all values for the class to the values specified by the constructor call
         * Date of birth is read as a string then converted to a DateTime object within the constructor.
         * @param [in] newID, the ID of the player
         * @param [in] newName, the name of the player
         * @param [in] newDateOfBirth, the player's date of birth
         * @param [in] newHeight, the player's height
         * @param [in] newWeight, the player's weight
         * @param [in] newPlaceofBirth, the place of birth of the player
         ***/
        public Player(int newID, string newName, string newDateOfBirth, int newHeight, int newWeight, string newPlaceofBirth) {
            //< Basic Assignments
            _ID = newID;
            _name = newName;
            _height = newHeight;
            _weight = newWeight;
            _placeOfBirth = newPlaceofBirth;
            _teamSignedTo = "";
            //< Conversion of birthdate to DateTime type
            CultureInfo provider = CultureInfo.InvariantCulture;
            _dateOfBirth = DateTime.ParseExact(newDateOfBirth, "dd/MM/yyyy", provider);
        }

        /***
         * Constructor for the player class - For Enrolled Players
         * Sets all values for the class to the values specified by the constructor call
         * Date of birth is read as a string then converted to a DateTime object within the constructor.
         * @param [in] newID, the ID of the player
         * @param [in] newName, the name of the player
         * @param [in] newDateOfBirth, the player's date of birth
         * @param [in] newHeight, the player's height
         * @param [in] newWeight, the player's weight
         * @param [in] newPlaceofBirth, the place of birth of the player
         * @param [in] newTeam, the team the player is signed to
         ***/
        public Player(int newID, string newName, string newDateOfBirth, int newHeight, int newWeight, string newPlaceofBirth, string newTeam) {
            //< Basic Assignments
            _ID = newID;
            _name = newName;
            _height = newHeight;
            _weight = newWeight;
            _placeOfBirth = newPlaceofBirth;
            _teamSignedTo = newTeam;
            //< Conversion to DateTime
            CultureInfo provider = CultureInfo.InvariantCulture;
            _dateOfBirth = DateTime.ParseExact(newDateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        /***
         * A method for producing the classes data in the appropriate string format for saving.
         * @return print, the string format of the class data.
         ***/
        public string savePlayer() {
            string print;
            if (this.teamSignedTo == "") {
                print = this.ID.ToString() + ";" + this.name + ";" + this.dateOfBirth.ToString("dd/MM/yyyy") + ";" + this.height.ToString() + ";" + this.weight.ToString() + ";" + this.placeOfBirth;
            } else {
                print = this.ID.ToString() + ";" + this.name + ";" + this.dateOfBirth.ToString("dd/MM/yyyy") + ";" + this.height.ToString() + ";" + this.weight.ToString() + ";" + this.placeOfBirth + ";" + this.teamSignedTo;
            }
            return print;
        }

        /***
         * Method that provides access to the Player's age, which is derived from their Date of Birth.
         * @return, the age of the player.
         ***/
        public int getAge() {
            return this.calculateAge();
        }
    }
    public class Team{

        /***
         * Found below are the private data members of the Team class.
         * They are encapsulated through associated properties which contain getters
         * And setters for all properties.
         ***/
        private string _name; //< Holds the name of the team.
        public string name{
            get{return _name;}
            set{_name = value;}
        }

        private string _ground; //< Holds the name of the teams home ground.
        public string ground{
            get{return _ground;}
            set{_ground = value;}
        }

        private string _coachName; //< Holds the name of the coach for the team.
        public string coachName{
            get{return _coachName;}
            set{_coachName = value;}
        }

        private int _yearFounded; //< Holds the year the team was founded.
        public int yearFounded{
            get{ return _yearFounded;}
            set{_yearFounded = value;}
        }

        private string _region; //< Holds the region where the team is from.
        public string region {
            get {return _region;}
            set {_region = value;}
        }
        
        private List<Player> _playerList; //< Holds a list of players enrolled to the team.
        public List<Player> playerList{ 
            get{return _playerList;} 
            set{_playerList = value;} 
        }

        //Public Procedures

        /***
         * Constructor for the team class. Initializes members to passed in values.
         * @param [in] newName, name for the team represented.
         * @param [in] newGround, home ground of the team.
         * @param [in] newCoachName, name of the team's coach.
         * @param [in] newYearFounded, the year the team was founded.
         * @param [in] newRegion, the region the team is located in.
         ***/
        public Team(string newName, string newGround, string newCoachName, int newYearFounded, string newRegion) {
            _name = newName;
            _ground = newGround;
            _coachName = newCoachName;
            _yearFounded = newYearFounded;
            _region = newRegion;
            _playerList = new List<Player>();
        }

        /***
         * A method for producing the classes data in the appropriate string format for saving.
         * @return print, the string format of the class data.
         ***/
        public string saveTeam() {
            string print = this.name + ";" + this.ground + ";" + this.coachName + ";" + this.yearFounded + ";" + this.region;
            return print;
        }


    }
}
