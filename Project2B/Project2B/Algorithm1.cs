using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    internal class Algorithm1 : IExploreAlgorithm
    {
        
        
        public bool Explore(IActor player, ILocations locations, int count)
        {
            var j = locations.GetEnumerator();
            
            if (locations as ExitLocations != null)
            {
                if (count > 0)
                {
                    while (j.MoveNext())
                    {
                        Explore(player, j.Current as ILocations, count--);

                    }

                }
                else
                {
                    locations.EnterLocation(player);
                    locations.ExitLocation(player);
                    return false;
                }
            
            }

            var t =  (locations as ContainerLocation).GetPlayerMarker(player);
            
            if (t.Equals(null))
            {
                
                locations.EnterLocation(player);
                locations.ExitLocation(player);
                while (j.MoveNext())
                {
                  
                    Explore(player, j.Current as ILocations, count--);
                   
                }

            }
            if(t.Equals(Marker._green))
            {
                locations.EnterLocation(player);
                locations.ExitLocation(player);
                while (j.MoveNext())
                {

                    Explore(player, j.Current as ILocations, count);

                }
                
               

            }
            
            return false;

        }
    }
}
