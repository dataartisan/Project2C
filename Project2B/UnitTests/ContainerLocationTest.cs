using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class ContainerLocationTest
    {
        private IDictionary<Directions, ILocations> _neighbors;
        private ContainerLocation _cl;

        //check to see if the AddNeighborTest passes
        [Test]
        public void AddNeighborTest()
        {
            _cl = new ContainerLocation(new Location("testContainerLocation"));
            Assert.AreEqual(_cl.Count, 0);
            _cl.AddNeighbor(new Location("testme"), Directions.Down);
            Assert.AreEqual(_cl.Count, 1);

        }
        //check to see if hte RemoveNeighborTest passes
        [Test]
        public void RemoveNeighborTest()
        {
            _cl = new ContainerLocation(new Location("testContainerLocation"));
            Assert.AreEqual(_cl.Count, 0);
            _cl.AddNeighbor(new Location("testme"), Directions.Down);
            Assert.AreEqual(_cl.Count, 1);
            _cl.RemoveNeighbor(Directions.Down);
            Assert.AreEqual(_cl.Count, 0);

        }


    }
}
