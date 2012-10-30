using Project2B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace TestProject
{
    
    
    /// <summary>
    ///This is a test class for ContainerLocationTest and is intended
    ///to contain all ContainerLocationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContainerLocationTest
    {
        private ContainerLocation _location;

        []
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
        ///A test for DeadEnd
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void DeadEndTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ContainerLocation_Accessor target = new ContainerLocation_Accessor(param0); // TODO: Initialize to an appropriate value
            ILocations location = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.DeadEnd(location);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

       

        /// <summary>
        ///A test for Enter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void EnterTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ContainerLocation_Accessor target = new ContainerLocation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Enter();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddNeighbor
        ///</summary>
        [TestMethod()]
        public void AddNeighborTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            ILocations to = null; // TODO: Initialize to an appropriate value
            Directions direction = new Directions(); // TODO: Initialize to an appropriate value
            target.AddNeighbor(to, direction);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeadEndCheck
        ///</summary>
        [TestMethod()]
        public void DeadEndCheckTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            ILocations location1 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.DeadEndCheck(location1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EnterLocation
        ///</summary>
        [TestMethod()]
        public void EnterLocationTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            IActor player = null; // TODO: Initialize to an appropriate value
            target.EnterLocation(player);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ExitLocation
        ///</summary>
        [TestMethod()]
        public void ExitLocationTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            IActor player = null; // TODO: Initialize to an appropriate value
            target.ExitLocation(player);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Exit
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Project2B.exe")]
        public void ExitTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ContainerLocation_Accessor target = new ContainerLocation_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Exit();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetEnumerator
        ///</summary>
        [TestMethod()]
        public void GetEnumeratorTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            IEnumerator expected = null; // TODO: Initialize to an appropriate value
            IEnumerator actual;
            actual = target.GetEnumerator();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveNeighbor
        ///</summary>
        [TestMethod()]
        public void RemoveNeighborTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            ILocations from = null; // TODO: Initialize to an appropriate value
            target.RemoveNeighbor(from);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            ILocations location = null; // TODO: Initialize to an appropriate value
            ContainerLocation target = new ContainerLocation(location); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
