using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class SurvivalTrapTest
    {
        private SurvivedTrap _sv;
        private LocationObserverandObservable _locations;
        private IActor _actor;


        [Test]
        public void SurvivalTrapConstructor()
        {
            _sv = new SurvivedTrap(_locations, _actor);
            Assert.AreEqual(_sv.Location, _locations);
        }

        [Test]
        public void ActorTest()
        {
            _sv = new SurvivedTrap(_locations, _actor);
            Assert.AreEqual(_sv.Actor, _actor);
        }
    }
}
