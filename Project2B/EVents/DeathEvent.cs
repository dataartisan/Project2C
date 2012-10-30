//class DeathEvent implements the interface IDeathEvent
namespace Project2B
{
    class DeathEvent : IDeathEvent
    {
        private IActor _actor;
		
		/// <summary>
		/// Contructor
		/// </summary>
        public DeathEvent(IActor actor)
        {
            _actor = actor;
        }

		/// <summary>
		/// does not need to be implemented
		/// </summary>
        public LocationObserverandObservable Location
        {
            get { throw new System.NotImplementedException(); }
        }
		/// <summary>
		/// does not need to be implemented
		/// </summary>
        public IItem Item
        {
            get { throw new System.NotImplementedException(); }
        }
		/// <summary>
		/// returns Actor object.
		/// </summary>
        public IActor Actor
        {
            get { return _actor; }
        }
    }
}