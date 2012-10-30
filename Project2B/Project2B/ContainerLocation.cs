using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Project2B
{
    class ContainerLocation : LocationDecorator
    {
        
        private readonly ILocations _location;
        private readonly Flag _check;
        private UpdateRequest _update;
        private IDictionary _saveState;

        public ContainerLocation(ILocations location)
        {
            _location = location;
            _saveState = new Dictionary<IActor,Marker>();
            _check = new Flag();
           
        }
       
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
        
        public bool DeadEndCheck(ILocations location)
       {
           if(location != null)
               return DeadEnd(location);
            throw new ArgumentNullException();

       }

        
        public override void AddNeighbor(ILocations to, Directions direction)
        {
            _location.AddNeighbor(to,direction);
        }

        public override void RemoveNeighbor(Directions direction)
        {
            _location.RemoveNeighbor(direction);
        }

       

        public override void EnterLocation(IActor player)
        {
           
            
                DeadEnd(_location);
                Enter();
                _location.EnterLocation(player);
                _update = new UpdateRequest(player,_location, _check);
                if(_saveState.Contains(player))
                {
                    ChangeMarkers(player);
                }
                if (_location.Count == 0)
                {
                    _saveState.Add(player, Marker._red); 

                }
                 _saveState.Add(player,Marker._green);    

        }

        private void ChangeMarkers(IActor player)
        {
            var flag = _saveState[player];
            if (flag.Equals(Marker._green))
                _saveState[player] = Marker._red;

        }

        public override void ExitLocation(IActor player)
        {
            DeadEnd(_location);
            Exit();
            _location.EnterLocation(player);
            _update = new UpdateRequest(player, _location, _check);
            
        }

        public override string Name
        {
            get { return _location.Name; }
        }

        public override int Count
        {
            get { return _location.Count; }
        }

        public override UpdateRequest Request
        {
            get { return _update; }
        }

        private void Enter()
        {
            _check.Enter = true;
            _check.Left = false;

        }
        
        private void Exit()
        {
            _check.Enter = false;
            _check.Left = true;

        }


        public override IEnumerator GetEnumerator()
        {
            return _location.GetEnumerator();
        }
    
        public object GetPlayerMarker(IActor player)
        {
            if (_saveState.Contains(player))
            {
                return _saveState[player];
            }

            return null;

        }
          
    
    }
}
