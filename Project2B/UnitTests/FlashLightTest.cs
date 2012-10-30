using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class FlashLightTest
    {
        private FlashLight _a;
        [Test]
        public void FlashLightConstructorTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.Name, "Flash Light");
        }
        [Test]
        public void TurnOnTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.IsOn, false); //assuming that it is not already on at first
            _a.TurnON();
            Assert.AreEqual(_a.IsOn, true);
        }
        [Test]
        public void NotAlreadyOnTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.IsOn, false);
        }

        [Test]
        public void IsEdibleTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.IsEdible, false);
        }

        [Test]
        public void IsCarriableTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.Carriable, true);
        }

        [Test]
        public void NameTest()
        {
            _a = new FlashLight();
            Assert.AreEqual(_a.Name, "Flash Light");
        }
    }
}
