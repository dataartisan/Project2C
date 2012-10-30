using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class KnifeTest
    {
        private AbstractWeapon _abstractWeapon;

        [Test]
        public void ConstructorTest()
        {
            _abstractWeapon = new Knife();
            Assert.AreEqual(_abstractWeapon.Name, "Hunting Knife");
        }
        [Test]
        public void IscarriableTest()
        {
            _abstractWeapon = new Knife();
            Assert.AreEqual(_abstractWeapon.Carriable, true);

        }
        [Test]
        public void IsOnTest()
        {
            _abstractWeapon = new Knife();
            Assert.AreEqual(_abstractWeapon.IsOn, false);
        }

        [Test]
        public void NameTest()
        {
            _abstractWeapon = new Knife();
            Assert.AreEqual(_abstractWeapon.Name, "Hunting Knife");
        }

    }
}
