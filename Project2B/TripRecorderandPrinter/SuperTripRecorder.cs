using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//enhanced Trip Recorder which wraps the old trip recorder
namespace Project2B
{
    public sealed class SuperTripRecorder : IObserver<object>, IRecord
    {
        private static IRecord _record;
        private StringBuilder _log;
        private static SuperTripRecorder _instance;
        private List<IDisposable> _unsubscriber = new List<IDisposable>();
		///<summary>
		/// Constructor
		///</summary>
        private SuperTripRecorder()
		{
		    _record = TripRecorder.Instance;
            _log = new StringBuilder();
        }
		
		///<summary>
		/// returns the instnace of the trip recorder by wrapping it with
		/// enhanced trip recorder
		///</summary>
        public static SuperTripRecorder Instance
        {
            get { return _instance ?? (_instance = new SuperTripRecorder()); }
        }

		///<summary>
		/// OnNext Event
		///</summary>
        public void OnNext(object request)
        {

            //if(request is ILocationEnchancedWrapper)
           // {
                //(_record as TripRecorder).OnNext(request);
                //_log.Append((_record as TripRecorder).GetRecordLog());

          //  }
            try
            {

                if (request is IDropEvent)
                {
                    PlayerDrop(request);
                }
                else if (request is IEatEVent)
                {
                    PlayerEat(request);
                }

                else if (request is IPickUpEvent)
                {
                    PlayerPickUp(request);
                }
                else if (request is IMoveEventEnter)
                {
                    PlayerEnter(request);
                }
                else if (request is IMoveEventExit)
                {
                    PlayerExit(request);
                }
            }
            catch(NullReferenceException exception)
            {
                
            }

        }
        ///<summary>
        /// Exit event
        ///</summary>
        private void PlayerExit(object request)
        {
            var j = request as IMoveEventExit;
            if (j != null && j.Location.Name != null)
            {

                _log.Append(j.Actor.ToString());
                _log.Append(" has exited " + j.Location.Name);
                _log.AppendLine();
            
            }
            

        }

        ///<summary>
        /// Enter event
        ///</summary>
        private void PlayerEnter(object request)
        {
            var j = request as IMoveEventEnter;
            if (j != null && j.Location.Name != null)
            {
                _log.Append(j.Actor.ToString());
                _log.Append(" has entered " + j.Location.Name);
                _log.AppendLine();
            }
        }

        ///<summary>
		/// Pick up event
		///</summary>
        private void PlayerPickUp(object request)
        {
            var j = request as IPickUpEvent;


                if (j != null && j.Item.Name != null)
                {

                    _log.Append(j.Actor.ToString());
                    _log.Append(" has picked up the ");
                    _log.Append(j.Item.Name);
                    _log.AppendLine();

                }
          
        }

		
		///<summary>
		/// Eat Event
		///</summary>
        private void PlayerEat(object request)
        {
            var j = request as IEatEVent;
            if (j != null && j.Item.Name != null)
            {
                _log.Append(j.Actor.ToString());
                _log.Append(" has ate the ");
                _log.Append(j.Item.Name);
                _log.AppendLine();
            }
        }
		
		
		///<summary>
		/// drop event
		///</summary>
        private void PlayerDrop(object request)
        {
            var j = request as IDropEvent;

            if (j != null && j.Item.Name != null)
            {
                _log.Append(j.Actor.ToString());
                _log.Append(" has dropped the ");
                _log.Append(j.Item.Name);
                _log.AppendLine();
            }
        }

		///<summary>
		/// Error event
		///</summary>
		
        public void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }
	
		///<summary>
		/// Once the trip is completed, it allows to unsubscribe
		///</summary>
        public void OnCompleted()
        {
            Unsubscribe();
        }


        public void Unsubscribe()
        {
            foreach (var disposable in _unsubscriber)
            {
                disposable.Dispose();
            }

        }
        
        
        ///<summary>
		/// Allows to subscribe
		///</summary>
        public void Subscribe(IObservable<object> provider)
        {
            if (provider != null)
                _unsubscriber.Add(provider.Subscribe(this));
        }
        
		///<summary>
		/// returns the log in string format
		///</summary>
        public string GetRecordLog()
        {
            return _log.ToString();
        }
    }
}
