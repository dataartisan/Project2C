using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Project2B.Misc;

namespace Project2B.UnitTests
{
    [TestFixture]
    class HealthSourceTest
    {
        private LightSource _ls;
        [Test]
        public void IsCarryableTest()
        {
            _ls = new LightSource();
            Assert.AreEqual(_ls.Carriable, false);
        }
        [Test]
        public void SwitchTest()
        {
            _ls = new LightSource();
            Assert.AreEqual(_ls.Switch, true);
        }
    }
}
