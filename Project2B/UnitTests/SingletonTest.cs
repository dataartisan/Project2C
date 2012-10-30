using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    //this class tests whether the singleton object creation is working
    [TestFixture]
    class SingletonTest
    {
        private IRecord _log;
        private IRecord _log2;
        
        [Test]
        public void SingletonClassTest()
        {
            _log = TripRecorder.Instance;
            _log2 = TripRecorder.Instance;
            Assert.AreEqual(_log.GetHashCode(), _log2.GetHashCode());
        }

    }
}
