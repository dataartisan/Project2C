using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Project2B
{
    class ExitLocations: IExit, ILocationDecorator
    {
        private readonly ILocations _location;
		/// <summary>
		/// Contructor
		/// </summary>
        public ExitLocations(ILocations location)
        {
            _location = location;

        }
        /// <summary>
		/// Adds neighbor to a location in certain direction
		/// </summary>
        public  void AddNeighbor(ILocations to, Directions direction)
        {
            _location.AddNeighbor(to, direction);
        }
		/// <summary>
		/// removes neighbor
		/// </summary>
		
        public void RemoveNeighbor(Directions direction)
        {
            _location.RemoveNeighbor(direction);
        }
		
		/// <summary>
		/// Allows IActor to enter certain location
		/// </summary>
        public  void EnterLocation(IActor player)
        {
            _location.EnterLocation(player);
        }
		/// <summary>
		/// Allows IActor to exit certain location
		/// </summary>
		
        public  void ExitLocation(IActor player)
        {
            _location.ExitLocation(player);
        }
		/// <summary>
		/// returns name
		/// </summary>
        public  string Name
        {
            get { return _location.Name; }
        }
		/// <summary>
		/// returns count
		/// </summary>
		
        public  int Count
        {
            get { return _location.Count; }
        }

        public IList<IActor> Players
        {
            get { return _location.Players; }
        }

        /// <summary>
		/// Update request
		/// </summary>
        public  UpdateRequest Request
        {
            
            get
            {
                
                   return (_location as ContainerLocation).Request;
               
            }
        }
		/// <summary>
		/// returns enumerator
		/// </summary>
        public  IEnumerator GetEnumerator()
        {
            if (_location is ContainerLocation)
                return (_location as ContainerLocation).GetEnumerator();
            throw new ArgumentException();
        }

		/// <summary>
		/// returns the marker of the player
		/// </summary>
		
        public   object GetPlayerMarker(IActor player)
        {
            return (_location as ContainerLocation).GetPlayerMarker(player);

        }
		/// <summary>
		/// checks if it is a deadend
		/// </summary>
		
        public  bool DeadEndCheck(ILocations location)
        {
            return (_location as ContainerLocation).DeadEndCheck(location);

        }
		/// <summary>
		/// retuns the neighbors
		/// </summary>
        public  IDictionary<Directions, ILocations> GetNeighbors
        {
            get { return (_location as ILocationDecorator).GetNeighbors; }
        }
		
		/// <summary>
		/// override toString
		/// </summary>
        public override string ToString()
        {
            return (_location as ILocationDecorator).ToString();
        }
       
    }
}
