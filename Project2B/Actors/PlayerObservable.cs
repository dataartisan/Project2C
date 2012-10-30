using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Interfaces;

namespace Project2B
{
    public abstract class PlayerObservable:PlayerObserver,IObservable<object>
    {

            private static readonly List<IObserver<object>> Observers2 = new List<IObserver<object>>();


			 /// <summary>
			/// Subscribe
			/// </summary>
            public IDisposable Subscribe(IObserver<object> observers)
            {
                if (!Observers2.Contains(observers))
                    Observers2.Add(observers);
                return new Unsubscriber(Observers2, observers);
            }
			/// <summary>
			/// UnSubscribe
			/// </summary>
            private class Unsubscriber : IDisposable
            {
                private readonly List<IObserver<object>> _observers;
                private readonly IObserver<object> _observer;

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
			 /// <summary>
			/// Update
			/// </summary>
            public void Update(IEvent eEvent)
            {
                foreach (var observer in Observers2)
                {
                    if ((observer is LocationObserverandObservable ) && (eEvent is IDropEvent || eEvent is IPickUpEvent))
                    {
                        if((observer).Equals(eEvent.Location))
                        {
                            observer.OnNext(eEvent);

                        }
                        else
                        {
                            observer.OnNext(eEvent);
                        }
                    }
                    
                       
                    else
                    {
                        observer.OnNext(eEvent);
                    }
                }
            }
			 /// <summary>
			/// Endupdate
			/// </summary>
            public void EndUpdate()
            {
                foreach (var observer in Observers2)
                {
                    observer.OnCompleted();
                }
                Observers2.Clear();
            }
    }
    
    
    
}

