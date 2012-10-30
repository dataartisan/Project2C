using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    
    internal class Location : ILocations,IComparable,IEnumerable
    {
        private readonly IDictionary<Directions,ILocations> _neighbors;
        private readonly string _name;
        private static int _cellCounter;
        private readonly List<IActor> _player;

        public Location(string name)
        {
            if (name != null)
            {
                _name = name;
                _neighbors = new Dictionary<Directions, ILocations>();
                _cellCounter++;
                _player = new List<IActor>();
            }
        
            throw new ArgumentNullException();        
        }
        
        public int CellCounter
        {
            get { return _cellCounter; }
        }

        public void AddNeighbor(ILocations to, Directions direction)
        {
            if (FindNeighbor(to, direction) == false)
            {
                _neighbors.Add(direction,to);
            }
            throw new Exception();
        }

        public void RemoveNeighbor(Directions direction)
        {
              _neighbors.Remove(direction);
        }

        private bool FindNeighbor(ILocations from, Directions to)
        {
            foreach (KeyValuePair<Directions,ILocations> loc in _neighbors)
            {
                if (loc.Value.Equals(from.Name) && loc.Key.Equals(to))
                    return true;
            }
            return false;
        }
       
        
        
        
        public void EnterLocation(IActor player)
        {

            if (checkPlayer(player))
            {
                _player.Add(player);
                (player as Player).ActorLocation = this;
            }
            throw new Exception();
            
                    
        }

        public void ExitLocation(IActor player)
        {
            if(checkPlayer(player))
              _player.Remove(player);
            throw new Exception();
        }

        private bool checkPlayer(IActor player)
        {
            var hold = player as Player;
            return (hold != null);

        }
        public override string ToString()
        {
            return _name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public IEnumerator GetEnumerator()
        {
            yield return _neighbors.GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            return string.Compare(this.Name, obj.ToString());
        }

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
        
       
        public string Name
        { get { return _name; } }

        public int Count
        {
            get { return _neighbors.Count; }
        }
    }
        
       
       
    }

