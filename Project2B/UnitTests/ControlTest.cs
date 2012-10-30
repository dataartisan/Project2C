using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class ControlTest
    {
        private Control c;
        [Test]
        public void FlagTest()
        {
            c = new Control {Flag = true};
            Assert.AreEqual(c.Flag, true);

        }
        [Test]
        public void CountTest()
        {
            c = new Control {Count = 100};
            Assert.AreEqual(c.Count, 100);

        }
    }
}
