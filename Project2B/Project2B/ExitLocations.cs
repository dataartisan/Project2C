using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    class ExitLocations:LocationDecorator
    {
        private readonly ILocations _location;

        public ExitLocations(ILocations location)
        {
            _location = location;

        }
        
        public override void AddNeighbor(ILocations to, Directions direction)
        {
            _location.AddNeighbor(to, direction);
        }

        public override void RemoveNeighbor(Directions direction)
        {
            _location.RemoveNeighbor(direction);
        }

        public override void EnterLocation(IActor player)
        {
            _location.EnterLocation(player);
        }

        public override void ExitLocation(IActor player)
        {
            _location.ExitLocation(player);
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
            
            get
            {
                if (_location is ContainerLocation)
                   return (_location as ContainerLocation).Request;
                throw new ArgumentException();
            
            }
        }

        public override IEnumerator GetEnumerator()
        {
            if (_location is ContainerLocation)
                return (_location as ContainerLocation).GetEnumerator();
            throw new ArgumentException();
        }
    }
}
