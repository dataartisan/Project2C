using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project2B
{
   public enum Directions
   {
        East,
        West,
        North,
        South,
        Up,
        Down
    }

    public class Location : ILocations,IComparable
    {
        private readonly IDictionary<Directions,ILocations> _neighbors;
        private readonly string _name;
        private static int _cellCounter;
        private readonly List<IActor> _player;

        //location constructor, if the name passed is not null, it creates the object
        public Location(string name)
        {
            if (name != null)
            {
                _name = name;
                _neighbors = new Dictionary<Directions, ILocations>();
                _cellCounter++;
                _player = new List<IActor>();
            }
        
            //throw new ArgumentNullException();        
        }

        //returns CellCount
        public int CellCounter
        {
            get { return _cellCounter; }
        }

        public IList<IActor> Players
        {
            get { return _player; }

        }
        //Allows us to add neighbors of type Location into Particular Direction
        public void AddNeighbor(ILocations to, Directions direction)
        {
            if (FindNeighbor(to, direction) == false)
            {
                _neighbors.Add(direction,to);
            }
            //throw new Exception();
        }

        //allows us to remove neighbors in a particular direction
        public void RemoveNeighbor(Directions direction)
        {
              _neighbors.Remove(direction);
        }

        //returns true if there is a neighbor in a particular direction for a given location
        private bool FindNeighbor(ILocations from, Directions to)
        {
            return _neighbors.Any(loc => loc.Value.Equals(from.Name) && loc.Key.Equals(to));
        }

        //allows players to enter location
        public void EnterLocation(IActor player)
        {

            if (checkPlayer(player))
            {
                _player.Add(player);
                
            }
           // throw new Exception();
            
                    
        }

        //allows players to exit location
        public void ExitLocation(IActor player)
        {
            if(checkPlayer(player))
              _player.Remove(player);
           // throw new Exception();
        }

        //allows to check if the player is present.
        public bool checkPlayer(IActor player)
        {
            var hold = player as Player;
            return (hold != null);

        }

        //overrides default ToString method
        public override string ToString()
        {
            return _name;
        }

        //overrides hashcode
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        //enumerator
        public IEnumerator GetEnumerator()
        {
            return AsArray().GetEnumerator();

        }

        //enemurator utility method
        private ICollection<ILocations> AsArray()
        {
            return _neighbors.Values;

        }
        
        //allows us to compare
        public int CompareTo(object obj)
        {
            return string.Compare(this.Name, obj.ToString());
        }

        //returns true if the objects passed are equal.
        public override bool Equals(object that)
        {
            if (that == null)
                return false;
            if (object.ReferenceEquals(this, that))
                return true;

            var pair = that as Location;

            if (pair == null)
                return false;
            if ((this.Name.Equals(pair.Name))) // could also check to see if neighbors are same in both objects
                return true;

            return false;

        }
        
        //returns name
        public string Name
        { get { return _name; } }

        //returns count
        public int Count
        {
            get { return _neighbors.Count; }
        }
        
        //returns neighbors
        public IDictionary<Directions, ILocations> GetNeighbors
        {
            get { return _neighbors; }
        }

    
    
    }
        
       
       
    }

