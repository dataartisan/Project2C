using System.Collections.Generic;
using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using Project2B.GameTerrain;

namespace Project2B.UnitTests
{
    [TestFixture]
    class LocationTests
    {
        private IDictionary<Directions, ILocations> _neighbors;
        private Location _l;


        //Test to check the cell counter.
        [Test]
        public void CellCounterTest()
        {
            _l = new Location("testLocation");
            _l.AddNeighbor(_l, Directions.Down);
            Assert.AreEqual(_l.Count, 1);
        }

        //test to check if the neighbors get added 
        [Test]
        public void AddNeighborTest()
        {
            _l = new Location("testLocation");
            Assert.AreEqual(_l.Count, 0);
            _l.AddNeighbor(_l, Directions.Down);
            Assert.AreEqual(_l.Count, 1);

        }

        //Test to see if the neighbors are removed
        [Test]
        public void RemoveNeighborTest()
        {
            _l = new Location("testLocation");
            Assert.AreEqual(_l.Count, 0);
            _l.AddNeighbor(_l, Directions.Down);
            Assert.AreEqual(_l.Count, 1);
            _l.RemoveNeighbor(Directions.Down);
            Assert.AreEqual(_l.Count, 0);

        }
        //test to see if the enter location succeeds
        [Test]
        public void EnterLocationTest()
        {
            _l = new Location("testLocation");
            var p = new Player("testPlayer");
            _l.EnterLocation(p);
            Assert.AreEqual(_l.checkPlayer(p), true);
        }
        //test to see if the player can exit a location
        [Test]
        public void ExitLocationTest()
        {
            _l = new Location("testLocation");
            var p = new Player("testPlayer");
            _l.EnterLocation(p);
            Assert.AreEqual(_l.checkPlayer(p), true);
            _l.ExitLocation(p);
            Assert.AreEqual(_l.checkPlayer(p), true);
        }
        //test to check the enumerator behavior
        [Test]
        public void GetEnumeratorTest()
        {
            _l = new Location("testLocation");
            var p1 = new Player("testPlayer1");
            var p2 = new Player("testPlayer2");
            _l.EnterLocation(p1);
            _l.EnterLocation(p2);
            _l.AddNeighbor(new Location("testLocation"), Directions.Down);
            var e = _l.GetEnumerator();
            //Console.Write(e);
            Assert.AreEqual(e.MoveNext(), true);


        }
        //regular test for Strings
        [Test]
        public void ToStringTest()
        {
            const string a = "test";
            Assert.AreEqual(a.ToString(), "test");
        }

        //Neighbor Counter Test
        [Test]
        public void NeighborCounterTest()
        {
            _l = new Location("testLocation");
            Assert.AreEqual(_l.Count, 0);
            _l.AddNeighbor(_l, Directions.Down);
            Assert.AreEqual(_l.Count, 1);
        }

        //Equals to Test
        [Test]
        public void EqualsToTest()
        {   Terrian1 boo = new Terrian1();
            
            LocationObserverandObservable j = new LocationLevelTwoWrap(new ContainerLocation(new Location("blah")));
            LocationObserverandObservable p = new LocationLevelTwoWrap(new ContainerLocation(new Location("blah2")));
            j.AddNeighbor(p,Directions.Up);
            var t = new Player("bob");
            j.EnterLocation(t);
            LocationObserverandObservable L = (LocationObserverandObservable) boo.Start;
            var r = t.ActorLocationNew.GetNeighbors;

            LocationObserverandObservable y = (LocationObserverandObservable) r[Directions.Up];
            Console.WriteLine(y.Name);
            Console.WriteLine(L.Name);
        }
    }
}
