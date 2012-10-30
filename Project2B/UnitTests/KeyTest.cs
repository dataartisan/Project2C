using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class KeyTest
    {
        private Key _a;
        [Test]
        public void NameTest()
        {
            _a = new Key();
            Assert.AreEqual(_a.Name, "Gold Key");
        }
        [Test]
        public void IsCarriableTest()
        {
            _a = new Key();
            Assert.AreEqual(_a.Carriable, true);
        }
    }
}
