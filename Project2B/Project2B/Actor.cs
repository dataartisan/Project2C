using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    public abstract class Actor: IActor
    {
        private string _actorName;
        private string _actorLocation;
        public abstract void ExploreTerrain(ILocations startingLocations);

    }
}
