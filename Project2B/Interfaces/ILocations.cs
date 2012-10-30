using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//location interface
namespace Project2B
{
    public interface ILocations:IEnumerable
    {
        void AddNeighbor(ILocations to, Directions direction);
        void RemoveNeighbor(Directions direction);
        void EnterLocation(IActor player);
        void ExitLocation(IActor player);
        string Name { get; }
        int Count { get; }
        IList<IActor> Players { get; }
    }
}
