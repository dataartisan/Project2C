//Event class: used using the location so that
//it sends the message to the player that
//key needs to be removed.
namespace Project2B
{
    class SurvivedTrap : ISurvivedTrap
    {
        private IActor _actor;
        private LocationObserverandObservable _location;

		///<summary>
		/// Constructor
		///</summary>
        public SurvivedTrap(LocationObserverandObservable location, IActor actor)
        {
                _actor = actor;
                _location = location;
        }
        
		///<summary>
		/// returns location
		///</summary>
        public LocationObserverandObservable Location
        {
            get { return _location; }
        }
		///<summary>
		/// Does not need to be implemented
		///</summary>
		
        public IItem Item
        {
            get { throw new System.NotImplementedException(); }
        }
		///<summary>
		/// returns actor
		///</summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}