using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class GlobalVariableTest
    {
        [Test]
        public void TestGlobalVar()
        {
            var j = 0;
            LocationObserverandObservable leet = new LocationLevelTwoWrap(new ContainerLocation(new Location("bboo")));
            LocationObserverandObservable leet2 = new LocationLevelTwoWrap(new ContainerLocation(new Location("bboo2")));
            Player bob = new Player("bob");
            bob.ActorLocation = leet;
            while (bob.ActorLocation == leet)
            {
                j++;
                if (j == 6)
                {
                    bob.ActorLocation = leet2;
                }
            }
            Console.WriteLine(bob.ActorLocation.Name);
        }
    }
}
