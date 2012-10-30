using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class FlagTest
    {
        private Flag f;

        //constructor test. this is not usually required when you do actual TDD.
        [Test]
        public void FlagConstructorTest()
        {
            f = new Flag { Enter = true };
            Assert.AreEqual(f.Enter, true);
            f = new Flag { GreenFlag = true };
            Assert.AreEqual(f.GreenFlag, true);
            f = new Flag { Left = true };
            Assert.AreEqual(f.Left, true);
            f = new Flag { RedFlag = true };
            Assert.AreEqual(f.RedFlag, true);
        }
        //test to see if the RedFlagGetterSetter works
        [Test]
        public void RedSetterGetterSet()
        {
            f = new Flag { RedFlag = true };
            Assert.AreEqual(f.RedFlag, true);
        }
        //Test to see if the Enter Getter Setter works
        [Test]
        public void EnterTest()
        {
            f = new Flag { Enter = true };
            Assert.AreEqual(f.Enter, true);
        }

        //Test to see if the left getter setter works
        [Test]
        public void LeftGetterSetter()
        {
            f = new Flag { Left = true };
            Assert.AreEqual(f.Left, true);
        }

        //Test to see if the Green Flag Getter/Setter works
        [Test]
        public void GreenFlagGetterSetter()
        {
            f = new Flag { GreenFlag = true };
            Assert.AreEqual(f.GreenFlag, true);
        }


    }
}
