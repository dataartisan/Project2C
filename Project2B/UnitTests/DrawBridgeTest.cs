using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class DrawBridgeTest
    {
        private ISwitch iSwitchable;
        [Test]
        public void IsCarriableTest()
        {
            iSwitchable = new DrawBridge();
            Assert.AreEqual(iSwitchable.Carriable, false);
        }
        [Test]
        public void DrawBridge()
        {
            iSwitchable = new DrawBridge {Switch = true};
            Assert.AreEqual(iSwitchable.Switch, true);
        }
    }
}
