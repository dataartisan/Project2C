using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class TrapTest
    {
        private Trap _tp;
        [Test]
        public void IsCarriableTest()
        {
            _tp = new Trap();
            Assert.AreEqual(_tp.Carriable, false);
        }
        [Test]
        public void SwitchTest()
        {
            _tp = new Trap();
            Assert.AreEqual(_tp.Switch, true);
        }
    }
}
