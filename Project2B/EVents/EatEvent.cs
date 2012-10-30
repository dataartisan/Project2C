using System;
//class EatEvent implements IEatEvent
namespace Project2B
{
    public class EatEvent:IEatEVent
    {
        private IItem _item;
        private IActor _actor;
        private LocationObserverandObservable _location;
		/// <summary>
		/// Constructor
		/// </summary>
		
        public EatEvent(LocationObserverandObservable location, IItem item, IActor actor)
        {
            
            if(Eat(item))
            {
                _location = location;
                if (actor != null) _actor = actor;
            }
            else
            {
                throw new ArgumentException("Type Mismatch");
            }
        }
		/// <summary>
		/// returns true if eaten
		/// </summary>
        public bool Eat(IItem item)
        {
            if(item is AbstractFood)
            {
                if ((item as AbstractFood).IsEdible)
                {
                    _item = item;
                    return true;
                }
            }

            return false;
        }
        /// <summary>
		/// returns location
		/// </summary>
        public LocationObserverandObservable Location
        {
            get { return _location; }
        }
		/// <summary>
		/// returns item
		/// </summary>
        public IItem Item
        {
            get { return _item; }
        }
		/// <summary>
		/// returns actor
		/// </summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}