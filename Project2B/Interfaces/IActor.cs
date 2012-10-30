using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface IActor is being implemented by corresponding actors/players in the
//class hierarchy.
namespace Project2B
{
    public interface IActor
    {
       void ExploreTerrain(ILocations startingLocation);
       LocationObserverandObservable ActorLocation { get; set; }
       LocationObserverandObservable ActorLocationNew { get; set; }
    }
}
