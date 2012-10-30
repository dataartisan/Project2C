using System.Collections.Generic;
using System.Data;
using Project2B;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject3
{
    
    
    /// <summary>
    ///This is a test class for Terrian1Test and is intended
    ///to contain all Terrian1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Terrian1Test
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
        ///A test for BuildTable
        ///</summary>
        [TestMethod()]
        public void BuildTableTest()
        {
            Terrian1 p = new Terrian1();
            DataTable _items = new DataTable();


            _items.Columns.Add("Location Name");
            _items.Columns.Add("Location Items", typeof(List<IItem>));
            foreach (var j in p.Terrian)
            {
                _items.Rows.Add(j.Name, (j as LocationObserverandObservable).Items);

            }

            DataColumn[] dc = new DataColumn[1];
            dc[0] = _items.Columns["LocationName"];
            _items.PrimaryKey = dc;
            var L = _items.Select("LocationName = " +p.Start.Name);
            


           Console.WriteLine(L.GetType());

        }
    }
}
