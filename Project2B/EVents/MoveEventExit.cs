//Class MoveEventExit
namespace Project2B
{
    class MoveEventExit : IMoveEventExit
    {
        
        private IActor _actor;
        private LocationObserverandObservable _location;
         /// <summary>
	   /// Constructor
	   /// </summary>
        public MoveEventExit(LocationObserverandObservable location,IActor actor)
        {
                _actor = actor;
                _location = location;
        }
        
         /// <summary>
	   /// Returns Location
	   /// </summary>
        public LocationObserverandObservable Location
        {
            get { return _location; }
        }
		 /// <summary>
	   /// Do not need this
	   /// </summary>
        public IItem Item
        {
            get { throw new System.NotImplementedException(); }
        }
		 /// <summary>
	   /// Returns Actor
	   /// </summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}
