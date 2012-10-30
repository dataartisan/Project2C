using Project2B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject2
{
    
    
    /// <summary>
    ///This is a test class for GameGuiTest and is intended
    ///to contain all GameGuiTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameGuiTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GameGui Constructor
        ///</summary>
        [TestMethod()]
        public void GameGuiConstructorTest()
        {
            GameGui target = new GameGui();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        
        /// <summary>
        ///A test for ClearLogButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void ClearLogButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ClearLogButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CurrentLocation
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void CurrentLocationTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            LocationObserverandObservable expected = null; // TODO: Initialize to an appropriate value
            LocationObserverandObservable actual;
            actual = target.CurrentLocation();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CurrentLocationUpdatePanels
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void CurrentLocationUpdatePanelsTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.CurrentLocationUpdatePanels();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayDownTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplayDown(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayEast
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayEastTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplayEast(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayLocationItems
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayLocationItemsTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.DisplayLocationItems();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayNorth
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayNorthTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplayNorth(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayPlayerCoins
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayPlayerCoinsTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.DisplayPlayerCoins();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayPlayerHealth
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayPlayerHealthTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.DisplayPlayerHealth();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayPlayerItems
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayPlayerItemsTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.DisplayPlayerItems();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplaySouth
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplaySouthTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplaySouth(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayUpTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplayUp(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisplayWest
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisplayWestTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            IDictionary<Directions, ILocations> locationses = null; // TODO: Initialize to an appropriate value
            target.DisplayWest(locationses);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DisposeTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GoButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void GoButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.GoButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for HideMainDisplayShowDes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void HideMainDisplayShowDesTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.HideMainDisplayShowDes();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitalSetup
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void InitalSetupTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.InitalSetup();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void InitializeComponentTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LocationItemButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void LocationItemButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.LocationItemButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LookButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void LookButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.LookButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LookDescriptionHide
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void LookDescriptionHideTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.LookDescriptionHide();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for LookDescriptionShow
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void LookDescriptionShowTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.LookDescriptionShow();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PlayerItemDropButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void PlayerItemDropButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PlayerItemDropButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PlayerItemEatButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void PlayerItemEatButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PlayerItemEatButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PlayerItemTurnOnButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void PlayerItemTurnOnButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PlayerItemTurnOnButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PlayerList_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void PlayerList_SelectedIndexChangedTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PlayerList_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ReturnButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void ReturnButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ReturnButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShowDisplayLocation
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void ShowDisplayLocationTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.ShowDisplayLocation();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShowLogButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void ShowLogButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.ShowLogButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TurnOffButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void TurnOffButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.TurnOffButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void UpButton_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.UpButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpDateHealth
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void UpDateHealthTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.UpDateHealth();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateTopButtons
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void UpdateTopButtonsTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            target.UpdateTopButtons();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button5_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void button5_ClickTest()
        {
            GameGui_Accessor target = new GameGui_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.button5_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
