using Project2B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for PlayerTest and is intended
    ///to contain all PlayerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlayerTest
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
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest1()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            int health = 0; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName, health);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Player Constructor
        ///</summary>
        [TestMethod()]
        public void PlayerConstructorTest2()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            int health = 0; // TODO: Initialize to an appropriate value
            int carryWeight = 0; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName, health, carryWeight);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Drop
        ///</summary>
        [TestMethod()]
        public void DropTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            IItem item = null; // TODO: Initialize to an appropriate value
            target.Drop(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DropGreen
        ///</summary>
        [TestMethod()]
        public void DropGreenTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            Color expected = new Color(); // TODO: Initialize to an appropriate value
            Color actual;
            actual = target.DropGreen();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DropRed
        ///</summary>
        [TestMethod()]
        public void DropRedTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            Color expected = new Color(); // TODO: Initialize to an appropriate value
            Color actual;
            actual = target.DropRed();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Eat
        ///</summary>
        [TestMethod()]
        public void EatTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            IItem item = null; // TODO: Initialize to an appropriate value
            target.Eat(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExploreTerrain
        ///</summary>
        [TestMethod()]
        public void ExploreTerrainTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            ILocations startingLocations = null; // TODO: Initialize to an appropriate value
            target.ExploreTerrain(startingLocations);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PickUp
        ///</summary>
        [TestMethod()]
        public void PickUpTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            IItem item = null; // TODO: Initialize to an appropriate value
            target.PickUp(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ActorLocation
        ///</summary>
        [TestMethod()]
        public void ActorLocationTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            ILocations expected = null; // TODO: Initialize to an appropriate value
            ILocations actual;
            target.ActorLocation = expected;
            actual = target.ActorLocation;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ActorName
        ///</summary>
        [TestMethod()]
        public void ActorNameTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ActorName;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CarryWeight
        ///</summary>
        [TestMethod()]
        public void CarryWeightTest()
        {
            string actorName = string.Empty; // TODO: Initialize to an appropriate value
            Player target = new Player(actorName); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CarryWeight;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
