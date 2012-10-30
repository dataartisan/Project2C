using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class HeathMeterTest
    {
        private HealthMeter _hm;
        private const int Health = 10;

        [Test]
        public void HealthTest()
        {
            _hm = new HealthMeter(Health);
            Assert.AreEqual(_hm.Health, 10);

        }
    }
}
