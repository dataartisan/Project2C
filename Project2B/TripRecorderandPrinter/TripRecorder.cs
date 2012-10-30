using System;
using System.Collections.Generic;
using System.Text;

namespace Project2B
{
	//triprecorder class. this is singleton.
    public sealed class TripRecorder : IObserver<object>, IRecord
	{
		   
			private static TripRecorder _instance;
			private StringBuilder _log = new StringBuilder();
			private List<IDisposable> _unsubscriber = new List<IDisposable>();

			///<summary>
			/// default constructor. this is private to implement singleton.
			///</summary>
            
			private TripRecorder() { }

			///<summary>
			/// any instance is created via this. if the instance is present, it returns the same instance.
			///</summary>
            
			public static TripRecorder Instance
			{
				get { return _instance ?? (_instance = new TripRecorder()); }
			}
			///<summary>
			/// allows the subscribe
			///</summary>
			
            public void Subscribe(IObservable<object> provider)
			{
				if (provider != null)
					_unsubscriber.Add(provider.Subscribe(this));
  
			}
		   
		
			///<summary>
			/// Records the entrance into the log
			///</summary>
			private void RecordEntrance(UpdateRequest request)
			{
			   var hold = request.Player;
			   var hold2 = request.Location;
			   _log.Append(((Player) hold).ActorName);
			   _log.Append(" has entered ");
			   _log.Append(((Location) hold2).ToString());
			   _log.Append(".");
				_log.AppendLine();

			}
			///<summary>
			/// Records the exit into the log
			///</summary>
			private void RecordExit(UpdateRequest request)
			{
				var hold = request.Player;
				var hold2 = request.Location;
				_log.Append(((Player)hold).ActorName);
				_log.Append(" has left ");
				_log.Append(((Location)hold2).ToString());
				_log.Append(".");
				_log.AppendLine();

			}

		///<summary>
		/// onNext evnet
		///</summary>
		 public void OnNext(object request)
		{
		    var locationDecorator = request as ILocationDecorator;
		    if (locationDecorator != null && locationDecorator.Request.Flag.Enter == true)
            { RecordEntrance((request as ILocationDecorator).Request); }
		    var decorator = request as ILocationDecorator;
		    if (decorator != null && decorator.Request.Flag.Left == true)
            { RecordExit((request as ILocationDecorator).Request); }
		}


	   
		///<summary>
		/// error
		///</summary>
		public void OnError(Exception error)
		{
			Console.WriteLine(error.Message);
		}

		
		///<summary>
		/// on trip completion, unsubscribe
		///</summary>
		public void OnCompleted()
		{
			Unsubscribe();
		}
		
		///<summary>
		/// returns log
		///</summary>
		public string GetRecordLog()
		{
		    var j = _log.ToString();
		    _log.Clear();
		    return j;
		}
		
		///<summary>
		/// unsubscribe
		///</summary>
		public  void Unsubscribe()
		{
			foreach (var disposable in _unsubscriber)
			{
				disposable.Dispose();
			}
			
		}
		
	
	}
}
