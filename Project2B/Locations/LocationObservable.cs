using System;
using System.Collections;
using System.Collections.Generic;
using Project2B.Interfaces;

namespace Project2B
{
    public abstract class LocationObservable : IObservable<object>
    {
        private static List<IObserver<object>> _observers = new List<IObserver<object>>();



        public IDisposable Subscribe(IObserver<object> observers)
        {
            if (!_observers.Contains(observers))
                _observers.Add(observers);
            return new Unsubscriber(_observers, observers);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<object>> _observers;
            private IObserver<object> _observer;

            public Unsubscriber(List<IObserver<object>> observers, IObserver<object> observer)
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

        public void Update(IEvent eEvent)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(eEvent);
            }
        }
        public void Update()
        {
            foreach (var observer in _observers)
            {
                if (observer is IRecord)
                {
                    observer.OnNext(this);
                    
                }


            }

        }
         
        public void EndUpdate()
        {
            for (int index = 0; index < _observers.Count; index++)
            {
                var observer = _observers[index];
                
                    observer.OnCompleted();
            }
            _observers.Clear();
        }



    }
}
