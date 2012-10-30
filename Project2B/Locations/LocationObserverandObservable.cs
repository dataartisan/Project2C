using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface sets location as observer and observable
namespace Project2B
{
    public abstract class LocationObserverandObservable : LocationObservable, IObserver<object>, ILocationEnchancedWrapper
    {
        protected static List<IDisposable> _unsubscriber = new List<IDisposable>();


        public abstract void OnNext(object request);
        public abstract void OnError(Exception error);
        public abstract void OnCompleted();

        public abstract void AddNeighbor(ILocations to, Directions direction);
        public abstract void RemoveNeighbor(Directions direction);
        public abstract void EnterLocation(IActor player);
        public abstract void ExitLocation(IActor player);
        public abstract string Name { get; }
        public abstract int Count { get; }
        public abstract IList<IActor> Players { get; }
        public abstract UpdateRequest Request { get; }
        public abstract IEnumerator GetEnumerator();
        public abstract object GetPlayerMarker(IActor player);
        public abstract bool DeadEndCheck(ILocations location);
        public abstract IDictionary<Directions, ILocations> GetNeighbors { get; }
        public abstract bool IsDark { get; set; }
        public abstract List<IFixture> Fixture { get; }
        public abstract void AddFixture(IFixture item);
        public abstract bool IsIExit();
        public abstract void AddItem(IItem item);
        public abstract List<IItem> Items { get; }
        public abstract string Description { get; set; }
        public abstract void ClearDescription();
        public abstract bool HasLightSource { get; }
        public abstract bool HasDrawBridge { get; }
        public abstract bool HasTrap { get; }
        public abstract bool IsOn(IFixture fixture);
        public abstract void TurnOnFixture(IFixture val);
        public abstract void TurnOffFixture(IFixture val);
        public abstract bool HasMonster { get; }
    }
}
