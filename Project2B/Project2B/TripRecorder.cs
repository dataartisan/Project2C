using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public sealed class TripRecorder : IObserver<LocationDecorator>, IRecord
    {
           
			private static TripRecorder _instance;
            private StringBuilder _log = new StringBuilder();
            private List<IDisposable> _unsubscriber = new List<IDisposable>();

            private TripRecorder() { }

            public static TripRecorder Instance
            {
                get { return _instance ?? (_instance = new TripRecorder()); }
            }

            public void Subscribe(IObservable<LocationDecorator> provider)
            {
                if (provider != null)
                    _unsubscriber.Add(provider.Subscribe(this));
  
            }
           
        
        
            private void RecordEntrance(UpdateRequest request)
            {
               var hold = request.Player;
               var hold2 = request.Location;
               _log.Append(((Player) hold).ActorName);
               _log.Append(" has entered ");
               _log.Append(((Location) hold2).Name);
               _log.Append(".");
                _log.AppendLine();

            }

            private void RecordExit(UpdateRequest request)
            {
                var hold = request.Player;
                var hold2 = request.Location;
                _log.Append(((Player)hold).ActorName);
                _log.Append(" has left ");
                _log.Append(((Location)hold2).Name);
                _log.Append(".");
                _log.AppendLine();

            }


         public void OnNext(LocationDecorator request)
        {
            if (request.Request.Flag.Enter == true) 
             { RecordEntrance(request.Request); }
            if (request.Request.Flag.Left == true) 
            { RecordExit(request.Request); }
        }


       

        public void OnError(Exception error)
        {
            
        }

        public void OnCompleted()
        {
            Unsubscribe();
        }

        public string GetRecordLog()
        {
            return _log.ToString();
        }
        public  void Unsubscribe()
        {
            foreach (var disposable in _unsubscriber)
            {
                disposable.Dispose();
            }
            
        }
        
    
    }
}
