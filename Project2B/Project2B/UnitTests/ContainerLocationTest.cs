using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class ContainerLocationTest
    {
        private ILocations locations;
        //private ContainerLocation _cLocations;
        private Flag _check = new Flag();
        
       
        [Test]
        public void DeadEndTest(ContainerLocation cl)
        {
            cl = new ContainerLocation(locations);
            cl.DeadEndCheck(locations);
            Assert.IsTrue(_check.RedFlag);
            Assert.IsFalse(_check.RedFlag);
            Assert.IsFalse(_check.GreenFlag);
        }

        [Test]
        public void ExitTest()
        {
            Assert.IsFalse(_check.Enter);
            Assert.IsTrue(_check.Left);
        }

       

    }
}
