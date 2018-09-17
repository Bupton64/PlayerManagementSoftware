using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment3ClassLibrary;
using System.Globalization;
using System.Collections.Generic;

namespace Assignment3Testing {

    /***
     * Test class for the Player class. Tests all methods and intended functionalities.
     ***/
    [TestClass]
    public class PlayerTestClass {
        [TestMethod]
        /***
         * Tests the Player constructor is initializing correctly
         ***/
        public void TestConstructor() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            Assert.IsNotNull(test);
        }
        [TestMethod]
        /***
         * Tests the ID property get method.
         ***/
        public void TestIDGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 16253;
            int actual = test.ID;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the ID property set method.
         ***/
        public void TestIDSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 10000;
            test.ID = expected;
            int actual = test.ID;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the name property get method.
         ***/
        public void TestNameGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            string expected = "Richie McCaw";
            string actual = test.name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the name property set method.
         ***/
        public void TestNameSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            string expected = "Carl Jones";
            test.name = expected;
            string actual = test.name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the dateOfBirth property get method.
         ***/
        public void TestDateOfBirthGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime expected = DateTime.ParseExact("01/02/2002", "dd/MM/yyyy", provider);
            DateTime actual = test.dateOfBirth;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the dateOfBirth property set method.
         ***/
        public void TestDateOfBirthSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime expected = DateTime.ParseExact("21/02/2002", "dd/MM/yyyy", provider);
            test.dateOfBirth = expected;
            DateTime actual = test.dateOfBirth;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the height property get method.
         ***/
        public void TestHeightGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 180;
            int actual = test.height;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the height property set method.
         ***/
        public void TestHeightSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 100;
            test.height = expected;
            int actual = test.height;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the weight property get method.
         ***/
        public void TestWeightGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 102;
            int actual = test.weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the weight property set method.
         ***/
        public void TestWeightSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            int expected = 110;
            test.weight = expected;
            int actual = test.weight;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the placeOfBirth property get method.
         ***/
        public void TestPlaceofBirthGetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            string expected = "Oamaru, New Zealand";
            string actual = test.placeOfBirth;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the placeOfBirth property set method.
         ***/
        public void TestPlaceofBirthSetter() {
            Player test = new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand");
            string expected = "London, England";
            test.placeOfBirth = expected;
            string actual = test.placeOfBirth;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the calculate age public method, for ages before the current date this year.
         ***/
        public void TestCalculateAgeBefore() {
            Player test = new Player(16253, "Richie McCaw", "27/04/1992", 180, 102, "Oamaru, New Zealand");
            int expected = 26;
            int actual = test.getAge();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        /***
         * Tests the calculate age public method, for ages after the current date this year.
         ***/
        public void TestCalculateAgeAfter() {
            Player test = new Player(16253, "Richie McCaw", "27/08/1992", 180, 102, "Oamaru, New Zealand");
            int expected = 25;
            int actual = test.getAge();
            Assert.AreEqual(expected, actual);
        }

    }
    /***
     * Test class for the Team class object. Tests all methods and intended functionalities.
     ***/
    [TestClass]
    public class Assignment3TeamTesting {
        [TestMethod]
        public void TestTeamConstructor() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            Assert.IsNotNull(testTeam);
        }
        [TestMethod]
        public void TestNameGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Blues";
            string actual = testTeam.name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNameSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Crusaders";
            testTeam.name = expected;
            string actual = testTeam.name;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGroundGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Eden Park";
            string actual = testTeam.ground;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGroundSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "A stadium";
            testTeam.ground = expected;
            string actual = testTeam.ground;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCoachNameGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Tom Coventry";
            string actual = testTeam.coachName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCoachNameSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Jon Doe";
            testTeam.coachName = expected;
            string actual = testTeam.coachName;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestYearFoundedGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            int expected = 1985;
            int actual = testTeam.yearFounded;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestYearFoundedSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            int expected = 1980;
            testTeam.yearFounded = expected;
            int actual = testTeam.yearFounded;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRegionGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Auckland";
            string actual = testTeam.region;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestRegionSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            string expected = "Canterbury";
            testTeam.region = expected;
            string actual = testTeam.region;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestPlayerListGetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            testTeam.playerList.Add(new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand"));
            testTeam.playerList.Add(new Player(10007, "John Doe", "05/02/2002", 170, 102, "Auckland, New Zealand"));
            testTeam.playerList.Add(new Player(16309, "Sam Smith", "01/07/2002", 160, 102, "Southland, New Zealand"));
            List<Player> expected = testTeam.playerList;
            Assert.AreEqual(expected, testTeam.playerList);
        }
        [TestMethod]
        public void TestPlayerListSetter() {
            Team testTeam = new Team("Blues", "Eden Park", "Tom Coventry", 1985, "Auckland");
            List<Player> expected = new List<Player>();
            expected.Add(new Player(16253, "Richie McCaw", "01/02/2002", 180, 102, "Oamaru, New Zealand"));
            expected.Add(new Player(10007, "John Doe", "05/02/2002", 170, 102, "Auckland, New Zealand"));
            expected.Add(new Player(16309, "Sam Smith", "01/07/2002", 160, 102, "Southland, New Zealand"));
            testTeam.playerList = expected;
            Assert.AreEqual(expected, testTeam.playerList);
        }        
    }
}
