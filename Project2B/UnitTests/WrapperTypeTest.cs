using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class WrapperTypeTest
    {
        private ILocations _blah;
        private IExit _blah2 = new ExitLocations(new Location("this really sucks"));

        [Test]
        public void Test1()
        {

        }


    }
}
