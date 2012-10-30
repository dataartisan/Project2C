using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Project2B.UnitTests
{
    [TestFixture]
    class PickupEventTest
    {
        private PickUpEvent _pe;
        private LocationObserverandObservable location = new LocationLevelTwoWrap(new ContainerLocation(new Location("Place")));
        private IItem item;
        private Actor actor = new Player("bob");
       
        

        [Test]
        public void PickupEventConstructorTest()
        {
            _pe = new PickUpEvent(location, item, actor);
            Assert.AreEqual(_pe.Location, location);
            Assert.AreEqual(_pe.Item, item);
            Assert.AreEqual(_pe.Actor, actor);
        }

        [Test]
        public void LocationTest()
        {
            var j = SuperTripRecorder.Instance;
            j.Subscribe(location);
            j.Subscribe(actor);
            location.Subscribe(actor);
            actor.Subscribe(location);
            location.EnterLocation(actor);
            


            (actor as Actor).ActorLocation = location;
           location.AddItem(new Coin());
            item = new Coin();
            actor.PickUp(new Coin());
            Assert.NotNull(j.GetRecordLog());
            Console.WriteLine(j.GetRecordLog());
            
            //_pe = new PickUpEvent(location, item, actor);
            //location.OnNext(_pe);
            Assert.AreEqual(0, location.Items.Count);
        }

        [Test]
        public void ItemTest()
        {
           IList<IItem> items = new List<IItem>();
            items.Add(new Coin());
            var j = new Coin();
          location.AddItem(new Coin());
            var k = new PickUpEvent(location, new Coin(), actor);
            location.OnNext(k);
            
            Assert.AreEqual(0,location.Items.Count);

        }
        [Test]
        public void ActorTest()
        {
            _pe = new PickUpEvent(location, item, actor);
            Assert.AreEqual(_pe.Actor, actor);
        }
    }
}
