using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class PlayerClassTest
    {
        private Player _p;
        private const String actorName = "subhash";

        [SetUp]
        public void SetUp()
        {
            _p = new Player(actorName);
        }
        [Test]
        public void ActorNameTest()
        {
            Assert.AreEqual("subhash", _p.ActorName);
        }
        [Test]
        public void LocationNameTest()
        {
            Assert.AreEqual(null, _p.ActorLocation);
        }
        [Test]
        public void ToStringTest()
        {
            _p = new Player("test");
            Assert.AreEqual(_p.ActorName, "test");
        }

    }
}
