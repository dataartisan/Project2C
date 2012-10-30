using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public abstract class LocationDecorator : ILocations, IObservable<LocationDecorator>
    {
        private static List<IObserver<LocationDecorator>> _observers = new List<IObserver<LocationDecorator>>();

        public abstract void AddNeighbor(ILocations to, Directions direction);
        
        public abstract void RemoveNeighbor(Directions direction);
        
        

        public abstract void EnterLocation(IActor player);

        public abstract void ExitLocation(IActor player);

        public abstract string Name { get; }

        public abstract int Count { get; }

        public abstract UpdateRequest Request { get; }
    

        public abstract IEnumerator GetEnumerator();
       
        public IDisposable Subscribe(IObserver<LocationDecorator> observers)
        {
            if (!_observers.Contains(observers))
                _observers.Add(observers);
            return new Unsubscriber(_observers, observers);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<LocationDecorator>> _observers;
            private IObserver<LocationDecorator> _observer;

            public Unsubscriber(List<IObserver<LocationDecorator>> observers, IObserver<LocationDecorator> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void Update()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(this);
            }
        }

        public void EndUpdate()
        {
            foreach (var observer in _observers)
                if (_observers.Contains(observer))
                    observer.OnCompleted();
            _observers.Clear();
        }


       
    }
}
