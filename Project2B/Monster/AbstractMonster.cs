using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B.Monster
{
    public abstract class AbstractMonster:IMonster,IEquatable<AbstractMonster>
    {
        public abstract bool Equals(AbstractMonster other);
        public abstract string MonsterName { get; }
        public abstract int MonsterHealth { get; }
        public abstract void Search();
        public abstract void Look();
        public abstract void Fight(IActor actor);
        public abstract int AttackPower { get; }
        public abstract void ExploreTerrain(ILocations startingLocation);
        public abstract LocationObserverandObservable ActorLocation { get; set; }
        public abstract LocationObserverandObservable ActorLocationNew { get; set; }
    }
}
