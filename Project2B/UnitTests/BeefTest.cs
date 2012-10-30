using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class BeefTest
    {
        AbstractFood a = new Beef();
        [Test]
        public void IsCarriableTest()
        {
            Assert.AreEqual(a.Carriable, true);
        }
        [Test]
        public void IsEdible()
        {
            Assert.AreEqual(a.IsEdible, true);
        }
        [Test]
        public void EnergyValue()
        {
            a.EnergyValue = 100;
            Assert.AreEqual(a.EnergyValue, 100);

        }


    }
}
