using Project2B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject2
{
    
    
    /// <summary>
    ///This is a test class for GameRunTest and is intended
    ///to contain all GameRunTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameRunTest
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
        ///A test for GameRun Constructor
        ///</summary>
        [TestMethod()]
        public void GameRunConstructorTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            GameRun target = new GameRun(name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GameStart
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void GameStartTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            GameRun_Accessor target = new GameRun_Accessor(param0); // TODO: Initialize to an appropriate value
            target.GameStart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetLog
        ///</summary>
        [TestMethod()]
        public void GetLogTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            GameRun target = new GameRun(name); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetLog;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Player
        ///</summary>
        [TestMethod()]
        public void PlayerTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            GameRun target = new GameRun(name); // TODO: Initialize to an appropriate value
            IActor actual;
            actual = target.Player;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Start
        ///</summary>
        [TestMethod()]
        public void StartTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            GameRun target = new GameRun(name); // TODO: Initialize to an appropriate value
            ILocations actual;
            actual = target.Start;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Terrain
        ///</summary>
        [TestMethod()]
        public void TerrainTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            GameRun target = new GameRun(name); // TODO: Initialize to an appropriate value
            ITerrian actual;
            actual = target.Terrain;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
