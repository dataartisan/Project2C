using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interfaces to set player to observer
namespace Project2B
{
    public abstract class PlayerObserver: IObserver<object>
    {

        protected static List<IDisposable> _unsubscriber = new List<IDisposable>();


        public abstract void OnNext(object request);
        public abstract void OnError(Exception error);
        public abstract void OnCompleted();
    
    }
}
