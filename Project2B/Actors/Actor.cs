using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Abstract class Actor implements the PlayerObservable and IActor interface.

namespace Project2B
{
    public abstract class Actor: PlayerObservable, IActor
    {

        public abstract string ActorName { get; }
        
        public abstract void ExploreTerrain(ILocations startingLocations);
        public abstract LocationObserverandObservable ActorLocation { get; set; }
        public abstract LocationObserverandObservable ActorLocationNew { get; set; }
        public abstract bool HasKey { get; }
        public abstract bool IsDead { get; }
        public abstract int Coins { get; }
        public abstract HealthMeter Health { get; }
        public abstract bool Drop(IItem item);
        public abstract bool PickUp(IItem item);
        public abstract bool Eat(IItem item);
        public abstract IList<IItem> Items { get; }
        public abstract int StartingHealth { get; }
    }
}
