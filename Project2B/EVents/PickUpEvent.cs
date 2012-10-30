//implements pickupEvent
namespace Project2B
{
    class PickUpEvent : IPickUpEvent
    {
        private IItem _item;
        private IActor _actor;
        private LocationObserverandObservable _location;
        /// <summary>
		/// Constructor
		/// </summary>
        public PickUpEvent(LocationObserverandObservable location, IItem item, IActor actor)
        {
                _actor = actor;
                _item = item;
                _location = location;
        }
        /// <summary>
		/// Returns location
		/// </summary>
        public LocationObserverandObservable Location
        {
            get {return _location; }
        }
		/// <summary>
		/// Returns items
		/// </summary>
        public IItem Item
        {
            get { return _item; }
        }
		/// <summary>
		/// Returns actor
		/// </summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}