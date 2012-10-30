using System;
//class DropEvent implements IDropEvent
namespace Project2B
{
    public class DropEvent : IDropEvent
    {
    
        private IItem _item;
        private IActor _actor;
        private LocationObserverandObservable _location;

		/// <summary>
		/// Constructor takes ILocation, IItem, and IActor
		/// </summary>
        public DropEvent(LocationObserverandObservable location, IItem item, IActor actor)
        {
                _actor = actor;
                _item = item;
                _location = location;
        }
       
	    /// <summary>
		/// returns the ILocation
		/// </summary>
        public LocationObserverandObservable Location
        {
            get { return _location; }
        }
		/// <summary>
		/// returns the IItem
		/// </summary>
        public IItem Item
        {
            get { return _item; }
        }
		/// <summary>
		/// returns te IActor
		/// </summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}