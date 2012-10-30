using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface terrain creates a contract for other terrain types
namespace Project2B
{
    interface ITerrian
    {
        void BuildTerrian();
        LocationObserverandObservable Start { get; }
        List<LocationObserverandObservable> Terrian { get; }
        LocationObserverandObservable GetLocation(string name);
    }
}
