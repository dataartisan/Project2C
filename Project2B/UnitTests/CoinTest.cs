using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class CoinTest
    {
        private AbstractCurrency a = new Coin();

        [Test]
        public void IsCarriable()
        {
            Assert.AreEqual(a.Carriable, true);   
        }
        [Test]
        public void IsEdible()
        {
            Assert.AreEqual(a.IsEdible, false);
        }
        [Test]
        public void CoinName()
        {
            Assert.AreEqual(a.Name, "Coin");
        }
    }
}
