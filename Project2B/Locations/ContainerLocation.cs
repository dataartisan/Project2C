using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
//class ContainerLocation implements LocationObservable and IlocationDecorator
namespace Project2B
{
    public class ContainerLocation : LocationObservable,ILocationDecorator
    {
        //object creation
        private readonly ILocations _location;
        private readonly Flag _check;
        private UpdateRequest _update;
        private IDictionary _saveState;
		
		/// <summary>
		/// Default Constructor
		/// </summary>
        public ContainerLocation(ILocations location)
        {
            _location = location;
            _saveState = new Dictionary<IActor,Color>();
            _check = new Flag();
           
        }
		/// <summary>
		/// utility method. checks to see if it is a deadend.
		/// </summary>
        
        private bool DeadEnd(ILocations location)
        {
           if(_check.GreenFlag == true)
           {
               if (location.Count < 1)
               {
                   _check.GreenFlag = false;
                   _check.RedFlag = true;
                   return true;
               }

           }
           else
           {
               _check.GreenFlag = true;
               
           }
           return false;
       
       
       }
		/// <summary>
		/// checks to see see if its a dead end.
		/// </summary>
        
        public bool DeadEndCheck(ILocations location)
       {
           if (location != null)
               return DeadEnd(location);
           else
               return false;

       }
		/// <summary>
		/// returns the neighbors of the location cells.
		/// </summary>
        public  IDictionary<Directions, ILocations> GetNeighbors
        {
            get { return (_location as Location).GetNeighbors; }
        }
        /// <summary>
		/// Allows adding neighbor
		/// </summary>
        
        public  void AddNeighbor(ILocations to, Directions direction)
        {
            _location.AddNeighbor(to,direction);
        }

        /// <summary>
		/// Allows removing neighbor
		/// </summary>
		
        public  void RemoveNeighbor(Directions direction)
        {
            _location.RemoveNeighbor(direction);
        }
        
        /// <summary>
		/// Allows entering location
		/// </summary>
		
        public  void EnterLocation(IActor player)
        {
           
            
                DeadEnd(_location);
                Enter();
                _location.EnterLocation(player);
                _update = new UpdateRequest(player,_location, _check);
                if(_saveState.Contains(player))
                {
                    ChangeMarkers(player);
                }
                else if (_location.Count == 0)
                {
                    _saveState.Add(player, Marker._red);
                    
                
                }
                else
                {
                    _saveState.Add(player, Marker._green);
                    
                
                }
               // Update();
                
            

        }
		/// <summary>
		/// utility method to change markers.
		/// </summary>
		
        private void ChangeMarkers(IActor player)
        {
           
          _saveState[player] = Marker._red;

        }
		/// <summary>
		/// allows exiting location
		/// </summary>
        
        public  void ExitLocation(IActor player)
        {
            DeadEnd(_location);
            Exit();
            _location.ExitLocation(player);
            _update = new UpdateRequest(player, _location, _check);
            //Update();
        }
		
		/// <summary>
		/// returns location name
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
		/// gets update request
		/// </summary>
        public  UpdateRequest Request
        {
            get { return _update; }
        }
		
		/// <summary>
		/// flips bits to true/false on entering/leaving
		/// </summary>
        private void Enter()
        {
            _check.Enter = true;
            _check.Left = false;

        }
        /// <summary>
		/// flips bits to true/false on entering/leaving
		/// </summary>
        private void Exit()
        {
            _check.Enter = false;
            _check.Left = true;

        }

		/// <summary>
		/// returns Location enumerator
		/// </summary>
        public  IEnumerator GetEnumerator()
        {
            return _location.GetEnumerator();
        }
		/// <summary>
		/// returns Color of the save marker.
		/// </summary>
		
        public object GetPlayerMarker(IActor player)
        {
            if (_saveState.Contains(player))
            {
                return (Color) _saveState[player];
            }

            return null;

        }
		
		/// <summary>
		/// overrides toString method
		/// </summary>
        public override string ToString()
        {
            return _location.ToString();
        } 
    

    }
}
