//class MoveEventEnter
namespace Project2B
{
    class MoveEventEnter : IMoveEventEnter
    {
        
        private IActor _actor;
        private LocationObserverandObservable _location;
         /// <summary>
	   /// Constructor
	   /// </summary>
        public MoveEventEnter(LocationObserverandObservable location,IActor actor)
        {
                _actor = actor;
                _location = location;
        }
        
         /// <summary>
	   /// Returns location
	   /// </summary>
        public LocationObserverandObservable Location
        {
            get { return _location; }
        }
		 /// <summary>
	   /// Dont need to implement this
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