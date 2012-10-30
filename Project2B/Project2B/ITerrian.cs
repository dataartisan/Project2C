using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2B
{
    interface ITerrian
    {
        void BuildTerrian();
        ILocations Start { get; }
    }
}
