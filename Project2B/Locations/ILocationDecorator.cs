using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface Location Decorator
namespace Project2B
{
    public interface ILocationDecorator:ILocations
    {
        void AddNeighbor(ILocations to, Directions direction);
        void RemoveNeighbor(Directions direction);
        void EnterLocation(IActor player);
        void ExitLocation(IActor player);
        string Name { get; }
        int Count { get; }
        UpdateRequest Request { get; }
        IEnumerator GetEnumerator();
        object GetPlayerMarker(IActor player);
        bool DeadEndCheck(ILocations location);
        IDictionary<Directions, ILocations> GetNeighbors { get; }
    
    }
}
