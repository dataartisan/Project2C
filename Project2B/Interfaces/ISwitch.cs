using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface ISwitchable implements IFixable.
//whether the corresponding objects (Bridges, FlashLights etc) can switched on and off.
namespace Project2B
{
    interface ISwitch:IFixture
    {
        bool Switch { get; set; }
    }
}
