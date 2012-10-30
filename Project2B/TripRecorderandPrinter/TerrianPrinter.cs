using System.Collections.Generic;
using System.Text;
//terrain print class prints the terrain explored by the player.

namespace Project2B
{
    class TerrianPrinter
    {
          private StringBuilder _log = new StringBuilder();
          private HashSet<ILocations> _set = new HashSet<ILocations>();
          private IList<ILocations> _list = new List<ILocations>();
          private IDictionary<Directions, ILocations> _location;
          private Player _player;

		///<summary>
		/// Constructor
		///</summary>
        public TerrianPrinter(IList<ILocations> list, Player player)
        {
            _list = list;
            _player = player;
        }
     
		///<summary>
		/// Builds the logs
		///</summary>
        private void BuildLog(ILocations location)
        {

            var j = (location as ILocationDecorator).GetNeighbors;

            _log.Append(location.ToString());
            _log.Append(":");
             GetValue(location);
            _log.AppendLine();
            foreach (KeyValuePair<Directions,ILocations> p in j)
            {
                _log.Append("  ");
                _log.Append(p.Key.ToString());
                _log.Append("-->");
                _log.Append(p.Value.ToString());
                 GetValue(p.Value);
                _log.AppendLine();
            }
        }

		///<summary>
		/// appends the markers to the log
		///</summary>
        private void GetValue(ILocations location)
        {
            if (location as IExit != null)
            {
                _log.Append(" Exit ");
            }

            var t = (location as ILocationDecorator).GetPlayerMarker(_player);
            if (t != null)
            {
                if (t.Equals(Marker._green))
                {
                    _log.Append(" Green Marker");
                }
                else
                {
                    _log.Append(" Red Marker");
                }
            }
        }

		///<summary>
		/// allows the exploration and adds to the build log
		///</summary>
        private void Explore(ILocations location)
        {
            if((_set.Contains(location) ) == false)
            {
                BuildLog(location);
                _set.Add(location);

                var j = location.GetEnumerator();
                while (j.MoveNext())
                {
                    if (j.Current != null)
                    {
                        Explore(j.Current as ILocations);
                    }

                }

            }
            return;

        } 
    
		///<summary>
		/// returns log in the string format
		///</summary>
       public string GetLog()
       {
           Explore(_list[0]);
           return _log.ToString();

       }
    
    
    }
}
