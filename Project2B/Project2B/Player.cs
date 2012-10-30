using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project2B
{
    public class Player:Actor
    {
        private string _actorName;
        private ILocations _actorLocation;

        public Player(string actorName)
        {
            _actorName = actorName;
        }

        public ILocations ActorLocation
        {
            get { return _actorLocation; }
        
           set{
               if (value != null)
               {
                   _actorLocation = value;
               }
           }
        
        
        }

        public Color DropGreen()
        {
            return Marker._green;

        }
        public Color DropRed()
        {
            return Marker._red;

        }


        public string ActorName
        {
            get { return _actorName; }
        }

        public override void ExploreTerrain(ILocations startingLocations)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return _actorName.ToString();
        }
    
    }
}
