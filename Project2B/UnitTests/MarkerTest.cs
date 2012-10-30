using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    internal class MarkerTest
    {
        private ICarriable ic;
        [Test]
        private void IsCarriable()
        {
            ic = new Marker();
            Assert.AreEqual(ic.Carriable, true);
        }
    }

}
