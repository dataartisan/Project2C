using Project2B.Interfaces;

namespace Project2B
{
    public class MonsterEvent : IEvent
    {
        private readonly IActor _player; 
        
        public MonsterEvent(IActor player)
        {
            _player = player;
        }

        public LocationObserverandObservable Location
        {
            get { throw new System.NotImplementedException(); }
        }

        public IItem Item
        {
            get { throw new System.NotImplementedException(); }
        }

        public IActor Actor
        {
            get { return _player; }
        }
    }
}