using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project2B.Interfaces;

namespace Project2B.Events
{
    public class MonsterEncounterEvent : IEvent
    {

        private LocationObserverandObservable _location;
        private IActor _actor;

        public MonsterEncounterEvent(LocationObserverandObservable loc, IActor actor)
        {
            _location = loc;
            _actor = actor;

        }

        public LocationObserverandObservable Location
        {
            get { return _location; }
        }

        public IItem Item
        {
            get { throw new NotImplementedException(); }
        }

        public IActor Actor
        {
            get { return _actor; }
        }
    }
}
